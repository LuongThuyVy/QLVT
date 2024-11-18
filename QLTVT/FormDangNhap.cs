using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);


            connPublisher.Close();
            Program.bindingSource.DataSource = dt;

            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        public FormDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Canh giữa màn hình

        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
            txtLogin.Text = "NT";// chi nhanh
            txtPass.Text = "123";
            if (KetNoiDatabaseGoc() == 0)
                return;

            layDanhSachPhanManh("SELECT  * FROM view_DanhSachPhanManh");
            cmbChiNhanh.SelectedIndex = 0;
            cmbChiNhanh.SelectedIndex = 1;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Step 1: Kiểm tra tài khoản & mật khẩu xem có bị trống không ?
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            /* Step 2: gán loginName & loginPassword với tài khoản mật khẩu được nhập*/
            Program.loginName = txtLogin.Text.Trim();
            Program.loginPassword = txtPass.Text.Trim();
            if (Program.KetNoi() == 0)
                return;
            /* Step 3: cập nhật currentLogin & currentPassword*/
            Program.brand = cmbChiNhanh.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;


            /* Step 4:  chạy stored procedure DANG NHAP de lay thong tin nguoi dung*/
            String statement = "EXEC sp_DangNhap '" + Program.loginName + "'";// exec sp_DangNhap 'TP'
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
            Program.myReader.Read();


            /* Step 5: gán giá trị Mã nhân viên - họ tên - vai trò ở góc màn hình*/
            Program.userName = Program.myReader.GetString(0);// lấy userName
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }



            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            Program.formMain.MaNV.Text = "MÃ NHÂN VIÊN: " + Program.userName;
            Program.formMain.HoTen.Text = "HỌ TÊN: " + Program.staff;
            Program.formMain.Nhom.Text = "VAI TRÒ: " + Program.role;

            /*Step 6: ẩn form hiện tại & hiện các nút chức năng còn lại*/
            this.Visible = false;
            Program.formMain.enableButtons();
        }
    }
}