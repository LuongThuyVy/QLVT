using DevExpress.XtraEditors;
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
    public partial class FormNV : DevExpress.XtraEditors.XtraForm
    {
        public FormNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;  
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            // TODO: This line of code loads data into the 'dS.CT_NhanVien' table. You can move, or remove it, as needed.
            this.cT_NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NhanVienTableAdapter.Fill(this.dS.CT_NhanVien);

            // TODO: This line of code loads data into the 'dS.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.dS.HoaDon);

            // TODO: This line of code loads data into the 'dS.DonDatHang' table. You can move, or remove it, as needed.
            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dS.DonDatHang); 

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}