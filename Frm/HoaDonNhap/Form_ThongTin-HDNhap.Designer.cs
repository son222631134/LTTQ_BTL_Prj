namespace BTL_Prj.Frm.HoaDonNhap

{
    partial class frmHoaDonNhap
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
            this.CBBNCC = new System.Windows.Forms.ComboBox();
            this.CBBMNV = new System.Windows.Forms.ComboBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatetimeNC = new System.Windows.Forms.DateTimePicker();
            this.TBHDN = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_button = new System.Windows.Forms.Panel();
            this.panel_input = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_ThongTinChung = new System.Windows.Forms.TabPage();
            this.tabPage_ChiTietHoaDon = new System.Windows.Forms.TabPage();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.panel_button.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_ThongTinChung.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBBNCC
            // 
            this.CBBNCC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CBBNCC.FormattingEnabled = true;
            this.CBBNCC.Location = new System.Drawing.Point(619, 25);
            this.CBBNCC.Name = "CBBNCC";
            this.CBBNCC.Size = new System.Drawing.Size(254, 27);
            this.CBBNCC.TabIndex = 40;
            this.CBBNCC.SelectedIndexChanged += new System.EventHandler(this.CBBNCC_SelectedIndexChanged);
            // 
            // CBBMNV
            // 
            this.CBBMNV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CBBMNV.FormattingEnabled = true;
            this.CBBMNV.Location = new System.Drawing.Point(181, 65);
            this.CBBMNV.Name = "CBBMNV";
            this.CBBMNV.Size = new System.Drawing.Size(254, 27);
            this.CBBMNV.TabIndex = 39;
            this.CBBMNV.SelectedIndexChanged += new System.EventHandler(this.CBBMNV_SelectedIndexChanged);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(3, 109);
            this.dgvHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.ReadOnly = true;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(940, 419);
            this.dgvHoaDonNhap.TabIndex = 36;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHDN_CellClick);
            this.dgvHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellContentClick);
            this.dgvHoaDonNhap.Click += new System.EventHandler(this.dtgrvHDN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(500, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày cấp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(500, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã nhà cung cấp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(62, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Số hoá đơn nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatetimeNC
            // 
            this.DatetimeNC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DatetimeNC.Location = new System.Drawing.Point(619, 62);
            this.DatetimeNC.Name = "DatetimeNC";
            this.DatetimeNC.Size = new System.Drawing.Size(254, 26);
            this.DatetimeNC.TabIndex = 30;
            this.DatetimeNC.ValueChanged += new System.EventHandler(this.DatetimeNC_ValueChanged);
            // 
            // TBHDN
            // 
            this.TBHDN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBHDN.Location = new System.Drawing.Point(181, 20);
            this.TBHDN.Name = "TBHDN";
            this.TBHDN.Size = new System.Drawing.Size(254, 26);
            this.TBHDN.TabIndex = 23;
            this.TBHDN.TextChanged += new System.EventHandler(this.TBHDN_TextChanged);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button6.Location = new System.Drawing.Point(174, 10);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 40);
            this.button6.TabIndex = 27;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SUA_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button5.Location = new System.Drawing.Point(641, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 40);
            this.button5.TabIndex = 28;
            this.button5.Text = "Chi tiết hoá đơn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Chitiethoadon_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button4.Location = new System.Drawing.Point(483, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 25;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button3.Location = new System.Drawing.Point(800, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 29;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.THoat_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(20, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "Thêm hoá đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.THEM_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(329, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.XOA_Click);
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.Transparent;
            this.panel_button.Controls.Add(this.button1);
            this.panel_button.Controls.Add(this.button2);
            this.panel_button.Controls.Add(this.button3);
            this.panel_button.Controls.Add(this.button4);
            this.panel_button.Controls.Add(this.button5);
            this.panel_button.Controls.Add(this.button6);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(3, 531);
            this.panel_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(940, 60);
            this.panel_button.TabIndex = 41;
            this.panel_button.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_input
            // 
            this.panel_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_input.BackColor = System.Drawing.Color.Transparent;
            this.panel_input.Controls.Add(this.label1);
            this.panel_input.Controls.Add(this.TBHDN);
            this.panel_input.Controls.Add(this.CBBNCC);
            this.panel_input.Controls.Add(this.DatetimeNC);
            this.panel_input.Controls.Add(this.CBBMNV);
            this.panel_input.Controls.Add(this.label2);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.Controls.Add(this.label4);
            this.panel_input.Location = new System.Drawing.Point(3, 3);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(940, 100);
            this.panel_input.TabIndex = 42;
            this.panel_input.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_ThongTinChung);
            this.tabControl1.Controls.Add(this.tabPage_ChiTietHoaDon);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 620);
            this.tabControl1.TabIndex = 43;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_ThongTinChung
            // 
            this.tabPage_ThongTinChung.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_ThongTinChung.Controls.Add(this.dgvHoaDonNhap);
            this.tabPage_ThongTinChung.Controls.Add(this.panel_input);
            this.tabPage_ThongTinChung.Controls.Add(this.panel_button);
            this.tabPage_ThongTinChung.Location = new System.Drawing.Point(4, 4);
            this.tabPage_ThongTinChung.Name = "tabPage_ThongTinChung";
            this.tabPage_ThongTinChung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongTinChung.Size = new System.Drawing.Size(946, 594);
            this.tabPage_ThongTinChung.TabIndex = 0;
            this.tabPage_ThongTinChung.Text = "Thông tin chung";
            this.tabPage_ThongTinChung.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage_ChiTietHoaDon
            // 
            this.tabPage_ChiTietHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_ChiTietHoaDon.Location = new System.Drawing.Point(4, 4);
            this.tabPage_ChiTietHoaDon.Name = "tabPage_ChiTietHoaDon";
            this.tabPage_ChiTietHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChiTietHoaDon.Size = new System.Drawing.Size(946, 594);
            this.tabPage_ChiTietHoaDon.TabIndex = 1;
            this.tabPage_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(954, 80);
            this.label_title.TabIndex = 38;
            this.label_title.Text = "THÔNG TIN HOÁ ĐƠN NHẬP";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(954, 80);
            this.panel_title.TabIndex = 44;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 700);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHoaDonNhap";
            this.Text = "DANH MỤC HÓA ĐƠN NHẬP";
            this.Load += new System.EventHandler(this.FrmThongTinHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_ThongTinChung.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBBNCC;
        private System.Windows.Forms.ComboBox CBBMNV;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatetimeNC;
        private System.Windows.Forms.TextBox TBHDN;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ThongTinChung;
        private System.Windows.Forms.TabPage tabPage_ChiTietHoaDon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_title;
    }
}

