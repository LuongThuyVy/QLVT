using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        bool dangThemMoi = false;
        String maChiNhanh = "";
        Stack undoList = new Stack();
        public FormKho()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            /**Step 1: tat kiem tra khoa ngoai & do du lieu vao form**/

            dS.EnforceConstraints = false;
            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.dS.HoaDon);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            maChiNhanh = ((DataRowView)bdsKho[0])["MACN"].ToString();

            //Step 2: lay du lieu dang nhap tu form dang nhap
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.brand;


            this.txtMaCN.Enabled = false;

            //Step 3: bat cac nut chuc nang theo nhom quyen
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnThoat.Enabled = true;
                this.s.Enabled = true; //button hoan tac
                this.btnChuyenChiNhanh.Enabled = true;
                this.btnThoat.Enabled = true;
                //form nhap lieu
                this.panelControl2.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
     chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.s.Enabled = true;
                this.btnThoat.Enabled = true;

                this.panelControl2.Enabled = true;
                this.txtMaKho.Enabled = false;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //button thoat
            this.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
           /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbChiNhanh.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbChiNhanh.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

                this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hoaDonTableAdapter.Fill(this.dS.HoaDon);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dS.Kho);
            }
        }

        private bool kiemTraDuLieuDauVao()
        {
            /*kiem tra txtMaKho
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaKho.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            if (txtMaKho.Text.Length > 4)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            */
            /*kiem tra txtTenKho*/
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            /**
            if (Regex.IsMatch(txtTenKho.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Tên kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            **/
            if (txtTenKho.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            /*kiem tra txtDiaChi*/
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDiaChi.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ gồm chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void s_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);
                this.gcKHO.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsKho.Position;
            this.panelControl2.Enabled = true;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsKho.AddNew();
            txtMaCN.Text = maChiNhanh;

            /*Step 3*/
            this.txtMaKho.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.s.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaKho.Enabled = false;

            this.gcKHO.Enabled = false;
            this.panelControl2.Enabled = true;
        }

        private void khoGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC*/
            //String maKhoHang = txtMaKho.Text;// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsKho[bdsKho.Position]);
            String tenKhoHang = drv["TenKho"].ToString();
            String diaChi = drv["DiaChi"].ToString();

            /*declare @returnedResult int
              exec @returnedResult = sp_KiemTraMaVatTu '20'
              select @returnedResult*/
            String cauTruyVan =
                   "DECLARE @result int " +
        "EXEC @result = sp_KiemTraMaKho N'" + tenKhoHang + "' " +
        "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine(result);
            Program.myReader.Close();

            /*Step 2*/
            int viTriConTro = bdsKho.Position;
            int viTriTenKho = bdsKho.Find("TenKho", txtTenKho.Text);

            if (result == 1 && viTriConTro != viTriTenKho)
            {
                MessageBox.Show("Tên kho hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnGhi.Enabled = true;
                        btnHoanTac.Enabled = true;

                        s.Enabled = true;
                        btnChuyenChiNhanh.Enabled = true;
                        btnThoat.Enabled = true;
                        this.txtMaKho.Enabled = false;

                        this.gcKHO.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.Kho " +
                                 "WHERE TenKho = N'" + tenKhoHang + "' AND DiaChi = N'" + diaChi + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin kho*/
                        else
                        {
                            cauTruyVanHoanTac =
                              "UPDATE DBO.Kho " +
                "SET TenKho = N'" + tenKhoHang + "', DiaChi = N'" + diaChi + "' " +
                "WHERE MaKho = " + drv["MaKho"].ToString();
                        }
                        //Console.WriteLine("CAU TRUY VAN HOAN TAC");
                        //Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsKho.EndEdit();
                        this.khoTableAdapter.Update(this.dS.Kho);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsKho.RemoveCurrent();
                        MessageBox.Show("Tên vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnThem.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaKho.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = true;

                this.btnHoanTac.Enabled = false;
                this.s.Enabled = true;
                this.btnThoat.Enabled = true;


                this.gcKHO.Enabled = true;
                this.panelControl2.Enabled = true;

                bdsKho.CancelEdit();
                /*xoa dong hien tai*/
                bdsKho.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsKho.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

            /*Step 2*/
            bdsKho.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            bdsKho.Position = viTri;
            this.khoTableAdapter.Fill(this.dS.Kho);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            if (bdsDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            string cauTruyVanHoanTac =
            "INSERT INTO DBO.KHO(TENKHO,DIACHI,MACN) " +
            " VALUES( '" + txtTenKho.Text + "','" +
                        txtDiaChi.Text + "', '" +
                        txtMaCN.Text.Trim() + "' ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);
          
            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bdsKho.Position;
                    bdsKho.RemoveCurrent();

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dS.Kho);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.dS.Kho);
                    bdsKho.Position = viTri;
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }
    }
}