using QLTVT.Properties;

namespace QLTVT
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieu = new DevExpress.XtraBars.BarSubItem();
            this.btnDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHangKhongPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoatDongNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.pageNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AutoHideEmptyItems = true;
            this.ribbon.AutoSizeItems = true;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(67, 57, 67, 57);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNhanVien,
            this.barButtonGroup1,
            this.btnVatTu,
            this.btnKho,
            this.btnLapPhieu,
            this.btnDanhSachNhanVien,
            this.btnDanhSachVatTu,
            this.btnChiTietNhapXuat,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnLapTaiKhoan,
            this.btnDonHangKhongPhieuNhap,
            this.btnHoatDongNhanVien,
            this.btnTongHopNhapXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 248;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 736;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageNhapXuat,
            this.pageBaoCao,
            this.pageHeThong});
            this.ribbon.ShowItemCaptionsInPageHeader = true;
            this.ribbon.Size = new System.Drawing.Size(1489, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.LargeWidth = 100;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "Vật tư";
            this.barButtonGroup1.Id = 5;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật tư";
            this.btnVatTu.Id = 6;
            this.btnVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVatTu.ImageOptions.SvgImage")));
            this.btnVatTu.LargeWidth = 100;
            this.btnVatTu.Name = "btnVatTu";
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 7;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.LargeWidth = 100;
            this.btnKho.Name = "btnKho";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Caption = "Lập phiếu";
            this.btnLapPhieu.Id = 8;
            this.btnLapPhieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapPhieu.ImageOptions.SvgImage")));
            this.btnLapPhieu.LargeWidth = 100;
            this.btnLapPhieu.Name = "btnLapPhieu";
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Caption = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.Id = 9;
            this.btnDanhSachNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanhSachNhanVien.ImageOptions.SvgImage")));
            this.btnDanhSachNhanVien.LargeWidth = 100;
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachNhanVien_ItemClick);
            // 
            // btnDanhSachVatTu
            // 
            this.btnDanhSachVatTu.Caption = "Danh sách vật tư";
            this.btnDanhSachVatTu.Id = 10;
            this.btnDanhSachVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanhSachVatTu.ImageOptions.SvgImage")));
            this.btnDanhSachVatTu.LargeWidth = 100;
            this.btnDanhSachVatTu.Name = "btnDanhSachVatTu";
            this.btnDanhSachVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachVatTu_ItemClick);
            // 
            // btnChiTietNhapXuat
            // 
            this.btnChiTietNhapXuat.Caption = "Chi tiết nhập xuất";
            this.btnChiTietNhapXuat.Id = 11;
            this.btnChiTietNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTietNhapXuat.ImageOptions.SvgImage")));
            this.btnChiTietNhapXuat.LargeWidth = 100;
            this.btnChiTietNhapXuat.Name = "btnChiTietNhapXuat";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 12;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.LargeWidth = 100;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 13;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.LargeWidth = 100;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnLapTaiKhoan
            // 
            this.btnLapTaiKhoan.Caption = "Tạo tài khoản";
            this.btnLapTaiKhoan.Id = 14;
            this.btnLapTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapTaiKhoan.ImageOptions.SvgImage")));
            this.btnLapTaiKhoan.LargeWidth = 100;
            this.btnLapTaiKhoan.Name = "btnLapTaiKhoan";
            this.btnLapTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapTaiKhoan_ItemClick);
            // 
            // btnDonHangKhongPhieuNhap
            // 
            this.btnDonHangKhongPhieuNhap.Caption = "Đơn hàng không phiếu nhập";
            this.btnDonHangKhongPhieuNhap.Id = 15;
            this.btnDonHangKhongPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonHangKhongPhieuNhap.ImageOptions.SvgImage")));
            this.btnDonHangKhongPhieuNhap.LargeWidth = 100;
            this.btnDonHangKhongPhieuNhap.Name = "btnDonHangKhongPhieuNhap";
            // 
            // btnHoatDongNhanVien
            // 
            this.btnHoatDongNhanVien.Caption = "Hoạt động nhân viên";
            this.btnHoatDongNhanVien.Id = 17;
            this.btnHoatDongNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoatDongNhanVien.ImageOptions.SvgImage")));
            this.btnHoatDongNhanVien.LargeWidth = 100;
            this.btnHoatDongNhanVien.Name = "btnHoatDongNhanVien";
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "Tổng hợp nhập xuất";
            this.btnTongHopNhapXuat.Id = 18;
            this.btnTongHopNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTongHopNhapXuat.ImageOptions.SvgImage")));
            this.btnTongHopNhapXuat.LargeWidth = 100;
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            // 
            // pageNhapXuat
            // 
            this.pageNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageNhapXuat.Name = "pageNhapXuat";
            this.pageNhapXuat.Text = "Nhập xuất";
            this.pageNhapXuat.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLapPhieu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÝ NHẬP XUẤT";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "Báo cáo";
            this.pageBaoCao.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachVatTu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChiTietNhapXuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonHangKhongPhieuNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHoatDongNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTongHopNhapXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLapTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 923);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1489, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaNV,
            this.HoTen,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 897);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1489, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaNV
            // 
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(115, 20);
            this.MaNV.Text = "MÃ NHÂN VIÊN";
            this.MaNV.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(62, 20);
            this.HoTen.Text = "HỌ TÊN";
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(63, 20);
            this.Nhom.Text = "VAI TRÒ";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kho";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh sách nhân viên";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.LargeWidth = 100;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Danh sách nhân viên";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.LargeWidth = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 953);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ VẬT TƯ - NHÓM 6";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MaNV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem btnLapPhieu;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachVatTu;
        private DevExpress.XtraBars.BarButtonItem btnChiTietNhapXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnLapTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDonHangKhongPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnHoatDongNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
    }
}