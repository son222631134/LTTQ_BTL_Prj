namespace BTL_Prj.Frm.HoaDonNhap

{
    partial class frmChiTietHDNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.BTSUA = new System.Windows.Forms.Button();
            this.BTDELETE = new System.Windows.Forms.Button();
            this.BTADDCTHDN = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ExitForm2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBGIAMGIA = new System.Windows.Forms.TextBox();
            this.TBDONGIA = new System.Windows.Forms.TextBox();
            this.TBSOLUONG = new System.Windows.Forms.TextBox();
            this.SoHDNTB = new System.Windows.Forms.TextBox();
            this.CBBMAHANG = new System.Windows.Forms.ComboBox();
            this.panel_button = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_input = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonNhap)).BeginInit();
            this.panel_button.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(954, 80);
            this.label_title.TabIndex = 52;
            this.label_title.Text = "CHI TIẾT HOÁ ĐƠN NHẬP";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChiTietHoaDonNhap
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dgvChiTietHoaDonNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietHoaDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDonNhap.Location = new System.Drawing.Point(6, 251);
            this.dgvChiTietHoaDonNhap.Margin = new System.Windows.Forms.Padding(0);
            this.dgvChiTietHoaDonNhap.Name = "dgvChiTietHoaDonNhap";
            this.dgvChiTietHoaDonNhap.ReadOnly = true;
            this.dgvChiTietHoaDonNhap.Size = new System.Drawing.Size(939, 386);
            this.dgvChiTietHoaDonNhap.TabIndex = 51;
            this.dgvChiTietHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvFORM2_CellClick);
            // 
            // BTSUA
            // 
            this.BTSUA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BTSUA.Location = new System.Drawing.Point(233, 10);
            this.BTSUA.Name = "BTSUA";
            this.BTSUA.Size = new System.Drawing.Size(120, 40);
            this.BTSUA.TabIndex = 50;
            this.BTSUA.Text = "Sửa";
            this.BTSUA.UseVisualStyleBackColor = true;
            this.BTSUA.Click += new System.EventHandler(this.BTSUA_Click);
            // 
            // BTDELETE
            // 
            this.BTDELETE.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BTDELETE.Location = new System.Drawing.Point(417, 10);
            this.BTDELETE.Name = "BTDELETE";
            this.BTDELETE.Size = new System.Drawing.Size(120, 40);
            this.BTDELETE.TabIndex = 49;
            this.BTDELETE.Text = "Xoá";
            this.BTDELETE.UseVisualStyleBackColor = true;
            this.BTDELETE.Click += new System.EventHandler(this.BTDELETE_Click);
            // 
            // BTADDCTHDN
            // 
            this.BTADDCTHDN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BTADDCTHDN.Location = new System.Drawing.Point(49, 10);
            this.BTADDCTHDN.Name = "BTADDCTHDN";
            this.BTADDCTHDN.Size = new System.Drawing.Size(120, 40);
            this.BTADDCTHDN.TabIndex = 48;
            this.BTADDCTHDN.Text = "Thêm";
            this.BTADDCTHDN.UseVisualStyleBackColor = true;
            this.BTADDCTHDN.Click += new System.EventHandler(this.BTADDCTHDN_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Clear.Location = new System.Drawing.Point(601, 10);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(120, 40);
            this.Clear.TabIndex = 47;
            this.Clear.Text = "Hủy";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ExitForm2
            // 
            this.ExitForm2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ExitForm2.Location = new System.Drawing.Point(785, 10);
            this.ExitForm2.Name = "ExitForm2";
            this.ExitForm2.Size = new System.Drawing.Size(120, 40);
            this.ExitForm2.TabIndex = 46;
            this.ExitForm2.Text = "Đóng";
            this.ExitForm2.UseVisualStyleBackColor = true;
            this.ExitForm2.Click += new System.EventHandler(this.ExitForm2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(531, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Giảm giá";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(102, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Đơn giá ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(531, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Số lượng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(102, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Số hoá đơn nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBGIAMGIA
            // 
            this.TBGIAMGIA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBGIAMGIA.Location = new System.Drawing.Point(619, 118);
            this.TBGIAMGIA.Name = "TBGIAMGIA";
            this.TBGIAMGIA.Size = new System.Drawing.Size(121, 26);
            this.TBGIAMGIA.TabIndex = 38;
            this.TBGIAMGIA.TextChanged += new System.EventHandler(this.TBGIAMGIA_TextChanged);
            // 
            // TBDONGIA
            // 
            this.TBDONGIA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBDONGIA.Location = new System.Drawing.Point(215, 118);
            this.TBDONGIA.Name = "TBDONGIA";
            this.TBDONGIA.Size = new System.Drawing.Size(122, 26);
            this.TBDONGIA.TabIndex = 37;
            this.TBDONGIA.TextChanged += new System.EventHandler(this.TBDONGIA_TextChanged);
            // 
            // TBSOLUONG
            // 
            this.TBSOLUONG.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBSOLUONG.Location = new System.Drawing.Point(619, 69);
            this.TBSOLUONG.Name = "TBSOLUONG";
            this.TBSOLUONG.Size = new System.Drawing.Size(121, 26);
            this.TBSOLUONG.TabIndex = 36;
            this.TBSOLUONG.TextChanged += new System.EventHandler(this.TBSOLUONG_TextChanged);
            // 
            // SoHDNTB
            // 
            this.SoHDNTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SoHDNTB.Location = new System.Drawing.Point(455, 25);
            this.SoHDNTB.Name = "SoHDNTB";
            this.SoHDNTB.Size = new System.Drawing.Size(122, 26);
            this.SoHDNTB.TabIndex = 34;
            this.SoHDNTB.TextChanged += new System.EventHandler(this.SoHDNTB_TextChanged);
            // 
            // CBBMAHANG
            // 
            this.CBBMAHANG.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CBBMAHANG.FormattingEnabled = true;
            this.CBBMAHANG.Location = new System.Drawing.Point(215, 69);
            this.CBBMAHANG.Name = "CBBMAHANG";
            this.CBBMAHANG.Size = new System.Drawing.Size(122, 27);
            this.CBBMAHANG.TabIndex = 53;
            this.CBBMAHANG.SelectedIndexChanged += new System.EventHandler(this.CBBMAHANG_SelectedIndexChanged);
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.BTADDCTHDN);
            this.panel_button.Controls.Add(this.Clear);
            this.panel_button.Controls.Add(this.ExitForm2);
            this.panel_button.Controls.Add(this.BTSUA);
            this.panel_button.Controls.Add(this.BTDELETE);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 640);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(954, 60);
            this.panel_button.TabIndex = 54;
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(954, 80);
            this.panel_title.TabIndex = 55;
            // 
            // panel_input
            // 
            this.panel_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_input.Controls.Add(this.SoHDNTB);
            this.panel_input.Controls.Add(this.TBSOLUONG);
            this.panel_input.Controls.Add(this.TBDONGIA);
            this.panel_input.Controls.Add(this.CBBMAHANG);
            this.panel_input.Controls.Add(this.TBGIAMGIA);
            this.panel_input.Controls.Add(this.label1);
            this.panel_input.Controls.Add(this.label5);
            this.panel_input.Controls.Add(this.label2);
            this.panel_input.Controls.Add(this.label4);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.Location = new System.Drawing.Point(0, 83);
            this.panel_input.Margin = new System.Windows.Forms.Padding(0);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(954, 168);
            this.panel_input.TabIndex = 56;
            // 
            // frmChiTietHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 700);
            this.Controls.Add(this.panel_input);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.dgvChiTietHoaDonNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChiTietHDNhap";
            this.Text = "THÔNG TIN CHI TIẾT HÓA ĐƠN NHẬP";
            this.Load += new System.EventHandler(this.frmChiTietHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonNhap)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDonNhap;
        private System.Windows.Forms.Button BTSUA;
        private System.Windows.Forms.Button BTDELETE;
        private System.Windows.Forms.Button BTADDCTHDN;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ExitForm2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBGIAMGIA;
        private System.Windows.Forms.TextBox TBDONGIA;
        private System.Windows.Forms.TextBox TBSOLUONG;
        private System.Windows.Forms.TextBox SoHDNTB;
        private System.Windows.Forms.ComboBox CBBMAHANG;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_input;
    }
}