namespace QLTVT.Report
{
    partial class FormDanhSachNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sÐTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiXoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVatTuDataSet = new QLTVT.QLVatTuDataSet();
            this.nhanVienTableAdapter = new QLTVT.QLVatTuDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager1 = new QLTVT.QLVatTuDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVatTuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi Nhánh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(158, 135);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(198, 28);
            this.cmbChiNhanh.TabIndex = 13;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(384, 130);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 37);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(966, 192);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 37);
            this.btnXuat.TabIndex = 15;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sÐTDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.trangThaiXoaDataGridViewTextBoxColumn,
            this.phaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 237);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Ho";
            this.hoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            this.hoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sÐTDataGridViewTextBoxColumn
            // 
            this.sÐTDataGridViewTextBoxColumn.DataPropertyName = "SÐT";
            this.sÐTDataGridViewTextBoxColumn.HeaderText = "SÐT";
            this.sÐTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sÐTDataGridViewTextBoxColumn.Name = "sÐTDataGridViewTextBoxColumn";
            this.sÐTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiXoaDataGridViewTextBoxColumn
            // 
            this.trangThaiXoaDataGridViewTextBoxColumn.DataPropertyName = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.HeaderText = "TrangThaiXoa";
            this.trangThaiXoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiXoaDataGridViewTextBoxColumn.Name = "trangThaiXoaDataGridViewTextBoxColumn";
            this.trangThaiXoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // phaiDataGridViewTextBoxColumn
            // 
            this.phaiDataGridViewTextBoxColumn.DataPropertyName = "Phai";
            this.phaiDataGridViewTextBoxColumn.HeaderText = "Phai";
            this.phaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phaiDataGridViewTextBoxColumn.Name = "phaiDataGridViewTextBoxColumn";
            this.phaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLVatTuDataSet;
            // 
            // qLVatTuDataSet
            // 
            this.qLVatTuDataSet.DataSetName = "QLVatTuDataSet";
            this.qLVatTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CT_DonDatHangTableAdapter = null;
            this.tableAdapterManager1.CT_HoaDonTableAdapter = null;
            this.tableAdapterManager1.CT_NhanVienTableAdapter = null;
            this.tableAdapterManager1.CT_PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.DonDatHangTableAdapter = null;
            this.tableAdapterManager1.HangHoaTableAdapter = null;
            this.tableAdapterManager1.HoaDonTableAdapter = null;
            this.tableAdapterManager1.KhachHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.LoaiHangTableAdapter = null;
            this.tableAdapterManager1.NhaCungCapTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLTVT.QLVatTuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDanhSachNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDanhSachNhanVien";
            this.Text = "FormDanhSachNhanVien";
            this.Load += new System.EventHandler(this.FormDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVatTuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLVatTuDataSet qLVatTuDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLVatTuDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sÐTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiXoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaiDataGridViewTextBoxColumn;
        private QLVatTuDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}