namespace QLTVT
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sÐTLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label phaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            System.Windows.Forms.Label ngayBatDauLabel;
            System.Windows.Forms.Label ngayKetThucLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLTVT.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLTVT.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLTVT.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSÐT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.cbTrangThaiXoa = new System.Windows.Forms.CheckBox();
            this.dteNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.bdsCTNV = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NhanVienTableAdapter = new QLTVT.DSTableAdapters.CT_NhanVienTableAdapter();
            this.ngayBatDauDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayKetThucDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.donDatHangTableAdapter = new QLTVT.DSTableAdapters.DonDatHangTableAdapter();
            this.bdsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new QLTVT.DSTableAdapters.HoaDonTableAdapter();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DSTableAdapters.PhieuNhapTableAdapter();
            maNVLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sÐTLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            ngayBatDauLabel = new System.Windows.Forms.Label();
            ngayKetThucLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDauDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDauDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(55, 28);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(49, 16);
            maNVLabel.TabIndex = 0;
            maNVLabel.Text = "Ma NV:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(257, 28);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(27, 16);
            hoLabel.TabIndex = 2;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(443, 31);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(34, 16);
            tenLabel.TabIndex = 4;
            tenLabel.Text = "Ten:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(54, 73);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(52, 16);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // sÐTLabel
            // 
            sÐTLabel.AutoSize = true;
            sÐTLabel.Location = new System.Drawing.Point(247, 76);
            sÐTLabel.Name = "sÐTLabel";
            sÐTLabel.Size = new System.Drawing.Size(37, 16);
            sÐTLabel.TabIndex = 8;
            sÐTLabel.Text = "SÐT:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(433, 77);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(69, 16);
            ngaySinhLabel.TabIndex = 10;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(727, 91);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(101, 16);
            trangThaiXoaLabel.TabIndex = 12;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // phaiLabel
            // 
            phaiLabel.AutoSize = true;
            phaiLabel.Location = new System.Drawing.Point(83, 111);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(36, 16);
            phaiLabel.TabIndex = 14;
            phaiLabel.Text = "Phai:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac,
            this.btnLamMoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(558, 283);
            this.bar1.FloatSize = new System.Drawing.Size(46, 22);
            this.bar1.Offset = 4;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(484, 217);
            this.bar2.FloatSize = new System.Drawing.Size(162, 27);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 0);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 0);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 0);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 4;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(80, 0);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 5;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 0);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(961, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(961, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(961, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(961, 75);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(112, 26);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(198, 24);
            this.cmbChiNhanh.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.dS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CT_DonDatHangTableAdapter = null;
            this.tableAdapterManager.CT_HoaDonTableAdapter = null;
            this.tableAdapterManager.CT_NhanVienTableAdapter = null;
            this.tableAdapterManager.CT_PhieuNhapTableAdapter = null;
            this.tableAdapterManager.DonDatHangTableAdapter = null;
            this.tableAdapterManager.HangHoaTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdsNhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 126);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(961, 164);
            this.nhanVienGridControl.TabIndex = 6;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHo,
            this.colTen,
            this.colDiaChi,
            this.colSÐT,
            this.colNgaySinh,
            this.colTrangThaiXoa,
            this.colPhai});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            this.colDiaChi.Width = 94;
            // 
            // colSÐT
            // 
            this.colSÐT.FieldName = "SÐT";
            this.colSÐT.MinWidth = 25;
            this.colSÐT.Name = "colSÐT";
            this.colSÐT.Visible = true;
            this.colSÐT.VisibleIndex = 4;
            this.colSÐT.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 5;
            this.colNgaySinh.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 6;
            this.colTrangThaiXoa.Width = 94;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 25;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 7;
            this.colPhai.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(ngayKetThucLabel);
            this.panelControl2.Controls.Add(this.ngayKetThucDateEdit);
            this.panelControl2.Controls.Add(ngayBatDauLabel);
            this.panelControl2.Controls.Add(this.ngayBatDauDateEdit);
            this.panelControl2.Controls.Add(phaiLabel);
            this.panelControl2.Controls.Add(this.cmbPhai);
            this.panelControl2.Controls.Add(trangThaiXoaLabel);
            this.panelControl2.Controls.Add(this.cbTrangThaiXoa);
            this.panelControl2.Controls.Add(ngaySinhLabel);
            this.panelControl2.Controls.Add(this.dteNgaySinh);
            this.panelControl2.Controls.Add(sÐTLabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(diaChiLabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(tenLabel);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(hoLabel);
            this.panelControl2.Controls.Add(this.txtHo);
            this.panelControl2.Controls.Add(maNVLabel);
            this.panelControl2.Controls.Add(this.txtMaNV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 290);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(961, 194);
            this.panelControl2.TabIndex = 7;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "Phai", true));
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(125, 108);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(121, 24);
            this.cmbPhai.TabIndex = 15;
            // 
            // cbTrangThaiXoa
            // 
            this.cbTrangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNhanVien, "TrangThaiXoa", true));
            this.cbTrangThaiXoa.Location = new System.Drawing.Point(834, 86);
            this.cbTrangThaiXoa.Name = "cbTrangThaiXoa";
            this.cbTrangThaiXoa.Size = new System.Drawing.Size(104, 24);
            this.cbTrangThaiXoa.TabIndex = 13;
            this.cbTrangThaiXoa.UseVisualStyleBackColor = true;
            // 
            // dteNgaySinh
            // 
            this.dteNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NgaySinh", true));
            this.dteNgaySinh.EditValue = null;
            this.dteNgaySinh.Location = new System.Drawing.Point(508, 74);
            this.dteNgaySinh.MenuManager = this.barManager1;
            this.dteNgaySinh.Name = "dteNgaySinh";
            this.dteNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgaySinh.Size = new System.Drawing.Size(125, 22);
            this.dteNgaySinh.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "SÐT", true));
            this.txtSDT.Location = new System.Drawing.Point(290, 73);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 23);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(112, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(483, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 23);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "Ho", true));
            this.txtHo.Location = new System.Drawing.Point(290, 25);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 23);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(110, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 23);
            this.txtMaNV.TabIndex = 1;
            // 
            // bdsCTNV
            // 
            this.bdsCTNV.DataMember = "CT_NhanVien";
            this.bdsCTNV.DataSource = this.dS;
            // 
            // cT_NhanVienTableAdapter
            // 
            this.cT_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ngayBatDauLabel
            // 
            ngayBatDauLabel.AutoSize = true;
            ngayBatDauLabel.Location = new System.Drawing.Point(705, 29);
            ngayBatDauLabel.Name = "ngayBatDauLabel";
            ngayBatDauLabel.Size = new System.Drawing.Size(88, 16);
            ngayBatDauLabel.TabIndex = 16;
            ngayBatDauLabel.Text = "Ngay Bat Dau:";
            // 
            // ngayBatDauDateEdit
            // 
            this.ngayBatDauDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV, "NgayBatDau", true));
            this.ngayBatDauDateEdit.EditValue = null;
            this.ngayBatDauDateEdit.Location = new System.Drawing.Point(799, 26);
            this.ngayBatDauDateEdit.MenuManager = this.barManager1;
            this.ngayBatDauDateEdit.Name = "ngayBatDauDateEdit";
            this.ngayBatDauDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDauDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDauDateEdit.Size = new System.Drawing.Size(125, 22);
            this.ngayBatDauDateEdit.TabIndex = 17;
            // 
            // ngayKetThucLabel
            // 
            ngayKetThucLabel.AutoSize = true;
            ngayKetThucLabel.Location = new System.Drawing.Point(716, 64);
            ngayKetThucLabel.Name = "ngayKetThucLabel";
            ngayKetThucLabel.Size = new System.Drawing.Size(94, 16);
            ngayKetThucLabel.TabIndex = 18;
            ngayKetThucLabel.Text = "Ngay Ket Thuc:";
            // 
            // ngayKetThucDateEdit
            // 
            this.ngayKetThucDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV, "NgayKetThuc", true));
            this.ngayKetThucDateEdit.EditValue = null;
            this.ngayKetThucDateEdit.Location = new System.Drawing.Point(816, 61);
            this.ngayKetThucDateEdit.MenuManager = this.barManager1;
            this.ngayKetThucDateEdit.Name = "ngayKetThucDateEdit";
            this.ngayKetThucDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThucDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThucDateEdit.Size = new System.Drawing.Size(125, 22);
            this.ngayKetThucDateEdit.TabIndex = 19;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DonDatHang";
            this.bdsDDH.DataSource = this.dS;
            // 
            // donDatHangTableAdapter
            // 
            this.donDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHoaDon
            // 
            this.bdsHoaDon.DataMember = "HoaDon";
            this.bdsHoaDon.DataSource = this.dS;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.dS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FormNV
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 504);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNV";
            this.Text = "FormNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDauDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDauDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DS dS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.CheckBox cbTrangThaiXoa;
        private DevExpress.XtraEditors.DateEdit dteNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSÐT;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private System.Windows.Forms.BindingSource bdsCTNV;
        private DSTableAdapters.CT_NhanVienTableAdapter cT_NhanVienTableAdapter;
        private DevExpress.XtraEditors.DateEdit ngayKetThucDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayBatDauDateEdit;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DSTableAdapters.DonDatHangTableAdapter donDatHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsHoaDon;
        private DSTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
    }
}