namespace QLTVT
{
    partial class FormTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtXacNhanMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rdChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.btnChonNhanVien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(348, 140);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(207, 26);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(348, 219);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(207, 26);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(348, 305);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtXacNhanMatKhau.Properties.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(207, 26);
            this.txtXacNhanMatKhau.TabIndex = 3;
            this.txtXacNhanMatKhau.EditValueChanged += new System.EventHandler(this.txtXacNhanMatKhau_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(178, 143);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(178, 222);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 20);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(178, 311);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 20);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Xác nhận mật khẩu";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(178, 385);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Vai trò";
            // 
            // rdChiNhanh
            // 
            this.rdChiNhanh.AutoSize = true;
            this.rdChiNhanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChiNhanh.Location = new System.Drawing.Point(348, 385);
            this.rdChiNhanh.Name = "rdChiNhanh";
            this.rdChiNhanh.Size = new System.Drawing.Size(104, 24);
            this.rdChiNhanh.TabIndex = 8;
            this.rdChiNhanh.TabStop = true;
            this.rdChiNhanh.Text = "Chi nhánh";
            this.rdChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUser.Location = new System.Drawing.Point(491, 383);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(64, 24);
            this.rdUser.TabIndex = 9;
            this.rdUser.TabStop = true;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // btnChonNhanVien
            // 
            this.btnChonNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChonNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNhanVien.Location = new System.Drawing.Point(592, 138);
            this.btnChonNhanVien.Name = "btnChonNhanVien";
            this.btnChonNhanVien.Size = new System.Drawing.Size(60, 28);
            this.btnChonNhanVien.TabIndex = 10;
            this.btnChonNhanVien.Text = "Chọn";
            this.btnChonNhanVien.UseVisualStyleBackColor = false;
            this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tạo tài khoản";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormTaoTaiKhoan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChonNhanVien);
            this.Controls.Add(this.rdUser);
            this.Controls.Add(this.rdChiNhanh);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormLapTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RadioButton rdChiNhanh;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.Button btnChonNhanVien;
        private System.Windows.Forms.Button button1;
    }
}