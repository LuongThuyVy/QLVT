using DevExpress.XtraBars;
using QLTVT.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();

            // Thiết lập chế độ full màn hình với thanh tiêu đề và viền
            this.FormBorderStyle = FormBorderStyle.Sizable; // Giữ viền có thể thay đổi kích thước
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void enableButtons()
        {

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;

            pageNhapXuat.Visible = true;
            pageBaoCao.Visible = true;
            btnLapTaiKhoan.Enabled = true;

            if (Program.role == "USER")
            {
                btnLapTaiKhoan.Enabled = false;
            }

            //pageTaiKhoan.Visible = true;


        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();

            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

            pageNhapXuat.Visible = false;
            pageBaoCao.Visible = false;
            //pageTaiKhoan.Visible = false;

            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.MdiParent = this;
                form.Show();
            }

            Program.formMain.MaNV.Text = "MÃ NHÂN VIÊN:";
            Program.formMain.HoTen.Text = "HỌ TÊN:";
            Program.formMain.Nhom.Text = "VAI TRÒ:";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLapTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTaoTaiKhoan form = new FormTaoTaiKhoan();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachNhanVien form = new FormDanhSachNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}