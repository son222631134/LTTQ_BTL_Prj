namespace BTL_Prj.Frm.HoaDonNhap

{
    partial class frmThongTinHDNhap
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
            this.label6 = new System.Windows.Forms.Label();
            this.XOA = new System.Windows.Forms.Button();
            this.dtgrvHDN = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatetimeNC = new System.Windows.Forms.DateTimePicker();
            this.THoat = new System.Windows.Forms.Button();
            this.Chitiethoadon = new System.Windows.Forms.Button();
            this.SUA = new System.Windows.Forms.Button();
            this.THEM = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.TBHDN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // CBBNCC
            // 
            this.CBBNCC.FormattingEnabled = true;
            this.CBBNCC.Location = new System.Drawing.Point(506, 86);
            this.CBBNCC.Name = "CBBNCC";
            this.CBBNCC.Size = new System.Drawing.Size(121, 21);
            this.CBBNCC.TabIndex = 40;
            this.CBBNCC.SelectedIndexChanged += new System.EventHandler(this.CBBNCC_SelectedIndexChanged);
            // 
            // CBBMNV
            // 
            this.CBBMNV.FormattingEnabled = true;
            this.CBBMNV.Location = new System.Drawing.Point(158, 183);
            this.CBBMNV.Name = "CBBMNV";
            this.CBBMNV.Size = new System.Drawing.Size(121, 21);
            this.CBBMNV.TabIndex = 39;
            this.CBBMNV.SelectedIndexChanged += new System.EventHandler(this.CBBMNV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Thông tin hoá đơn nhập";
            // 
            // XOA
            // 
            this.XOA.Location = new System.Drawing.Point(1092, 201);
            this.XOA.Name = "XOA";
            this.XOA.Size = new System.Drawing.Size(113, 23);
            this.XOA.TabIndex = 37;
            this.XOA.Text = "Xoá";
            this.XOA.UseVisualStyleBackColor = true;
            this.XOA.Click += new System.EventHandler(this.XOA_Click);
            // 
            // dtgrvHDN
            // 
            this.dtgrvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvHDN.Location = new System.Drawing.Point(43, 382);
            this.dtgrvHDN.Name = "dtgrvHDN";
            this.dtgrvHDN.ReadOnly = true;
            this.dtgrvHDN.Size = new System.Drawing.Size(1162, 182);
            this.dtgrvHDN.TabIndex = 36;
            this.dtgrvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHDN_CellClick);
            this.dtgrvHDN.Click += new System.EventHandler(this.dtgrvHDN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Số hoá đơn nhập";
            // 
            // DatetimeNC
            // 
            this.DatetimeNC.Location = new System.Drawing.Point(490, 177);
            this.DatetimeNC.Name = "DatetimeNC";
            this.DatetimeNC.Size = new System.Drawing.Size(200, 20);
            this.DatetimeNC.TabIndex = 30;
            this.DatetimeNC.ValueChanged += new System.EventHandler(this.DatetimeNC_ValueChanged);
            // 
            // THoat
            // 
            this.THoat.Location = new System.Drawing.Point(1092, 265);
            this.THoat.Name = "THoat";
            this.THoat.Size = new System.Drawing.Size(113, 23);
            this.THoat.TabIndex = 29;
            this.THoat.Text = "Thoát";
            this.THoat.UseVisualStyleBackColor = true;
            this.THoat.Click += new System.EventHandler(this.THoat_Click);
            // 
            // Chitiethoadon
            // 
            this.Chitiethoadon.Location = new System.Drawing.Point(849, 181);
            this.Chitiethoadon.Name = "Chitiethoadon";
            this.Chitiethoadon.Size = new System.Drawing.Size(113, 23);
            this.Chitiethoadon.TabIndex = 28;
            this.Chitiethoadon.Text = "Chi tiết hoá đơn nhập";
            this.Chitiethoadon.UseVisualStyleBackColor = true;
            this.Chitiethoadon.Click += new System.EventHandler(this.Chitiethoadon_Click);
            // 
            // SUA
            // 
            this.SUA.Location = new System.Drawing.Point(1092, 140);
            this.SUA.Name = "SUA";
            this.SUA.Size = new System.Drawing.Size(113, 23);
            this.SUA.TabIndex = 27;
            this.SUA.Text = "Sửa ";
            this.SUA.UseVisualStyleBackColor = true;
            this.SUA.Click += new System.EventHandler(this.SUA_Click);
            // 
            // THEM
            // 
            this.THEM.Location = new System.Drawing.Point(1092, 79);
            this.THEM.Name = "THEM";
            this.THEM.Size = new System.Drawing.Size(113, 23);
            this.THEM.TabIndex = 26;
            this.THEM.Text = "Thêm hoá đơn nhập";
            this.THEM.UseVisualStyleBackColor = true;
            this.THEM.Click += new System.EventHandler(this.THEM_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(849, 86);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(113, 23);
            this.ClearBT.TabIndex = 25;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // TBHDN
            // 
            this.TBHDN.Location = new System.Drawing.Point(158, 82);
            this.TBHDN.Name = "TBHDN";
            this.TBHDN.Size = new System.Drawing.Size(131, 20);
            this.TBHDN.TabIndex = 23;
            this.TBHDN.TextChanged += new System.EventHandler(this.TBHDN_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 601);
            this.Controls.Add(this.CBBNCC);
            this.Controls.Add(this.CBBMNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XOA);
            this.Controls.Add(this.dtgrvHDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatetimeNC);
            this.Controls.Add(this.THoat);
            this.Controls.Add(this.Chitiethoadon);
            this.Controls.Add(this.SUA);
            this.Controls.Add(this.THEM);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.TBHDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThongTinHDNhap";
            this.Text = "DANH MỤC HÓA ĐƠN NHẬP";
            this.Load += new System.EventHandler(this.FrmThongTinHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBBNCC;
        private System.Windows.Forms.ComboBox CBBMNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button XOA;
        private System.Windows.Forms.DataGridView dtgrvHDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatetimeNC;
        private System.Windows.Forms.Button THoat;
        private System.Windows.Forms.Button Chitiethoadon;
        private System.Windows.Forms.Button SUA;
        private System.Windows.Forms.Button THEM;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.TextBox TBHDN;
    }
}

