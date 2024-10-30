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
            this.label7 = new System.Windows.Forms.Label();
            this.dtgrvFORM2 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvFORM2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Chi tiết hoá đơn nhập";
            // 
            // dtgrvFORM2
            // 
            this.dtgrvFORM2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvFORM2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvFORM2.Location = new System.Drawing.Point(26, 358);
            this.dtgrvFORM2.Name = "dtgrvFORM2";
            this.dtgrvFORM2.ReadOnly = true;
            this.dtgrvFORM2.Size = new System.Drawing.Size(1243, 213);
            this.dtgrvFORM2.TabIndex = 51;
            this.dtgrvFORM2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvFORM2_CellClick);
            this.dtgrvFORM2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvFORM2_CellContentClick);
            // 
            // BTSUA
            // 
            this.BTSUA.Location = new System.Drawing.Point(1112, 149);
            this.BTSUA.Name = "BTSUA";
            this.BTSUA.Size = new System.Drawing.Size(75, 23);
            this.BTSUA.TabIndex = 50;
            this.BTSUA.Text = "Sửa";
            this.BTSUA.UseVisualStyleBackColor = true;
            this.BTSUA.Click += new System.EventHandler(this.BTSUA_Click);
            // 
            // BTDELETE
            // 
            this.BTDELETE.Location = new System.Drawing.Point(1112, 213);
            this.BTDELETE.Name = "BTDELETE";
            this.BTDELETE.Size = new System.Drawing.Size(75, 23);
            this.BTDELETE.TabIndex = 49;
            this.BTDELETE.Text = "Xoá";
            this.BTDELETE.UseVisualStyleBackColor = true;
            this.BTDELETE.Click += new System.EventHandler(this.BTDELETE_Click);
            // 
            // BTADDCTHDN
            // 
            this.BTADDCTHDN.Location = new System.Drawing.Point(1112, 95);
            this.BTADDCTHDN.Name = "BTADDCTHDN";
            this.BTADDCTHDN.Size = new System.Drawing.Size(75, 23);
            this.BTADDCTHDN.TabIndex = 48;
            this.BTADDCTHDN.Text = "Thêm";
            this.BTADDCTHDN.UseVisualStyleBackColor = true;
            this.BTADDCTHDN.Click += new System.EventHandler(this.BTADDCTHDN_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(827, 220);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 47;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ExitForm2
            // 
            this.ExitForm2.Location = new System.Drawing.Point(1112, 275);
            this.ExitForm2.Name = "ExitForm2";
            this.ExitForm2.Size = new System.Drawing.Size(75, 23);
            this.ExitForm2.TabIndex = 46;
            this.ExitForm2.Text = "Thoát";
            this.ExitForm2.UseVisualStyleBackColor = true;
            this.ExitForm2.Click += new System.EventHandler(this.ExitForm2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(824, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Đơn giá ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Số hoá đơn nhập";
            // 
            // TBGIAMGIA
            // 
            this.TBGIAMGIA.Location = new System.Drawing.Point(921, 149);
            this.TBGIAMGIA.Name = "TBGIAMGIA";
            this.TBGIAMGIA.Size = new System.Drawing.Size(100, 20);
            this.TBGIAMGIA.TabIndex = 38;
            this.TBGIAMGIA.TextChanged += new System.EventHandler(this.TBGIAMGIA_TextChanged);
            // 
            // TBDONGIA
            // 
            this.TBDONGIA.Location = new System.Drawing.Point(564, 239);
            this.TBDONGIA.Name = "TBDONGIA";
            this.TBDONGIA.Size = new System.Drawing.Size(100, 20);
            this.TBDONGIA.TabIndex = 37;
            this.TBDONGIA.TextChanged += new System.EventHandler(this.TBDONGIA_TextChanged);
            // 
            // TBSOLUONG
            // 
            this.TBSOLUONG.Location = new System.Drawing.Point(564, 145);
            this.TBSOLUONG.Name = "TBSOLUONG";
            this.TBSOLUONG.Size = new System.Drawing.Size(100, 20);
            this.TBSOLUONG.TabIndex = 36;
            this.TBSOLUONG.TextChanged += new System.EventHandler(this.TBSOLUONG_TextChanged);
            // 
            // SoHDNTB
            // 
            this.SoHDNTB.Location = new System.Drawing.Point(218, 142);
            this.SoHDNTB.Name = "SoHDNTB";
            this.SoHDNTB.Size = new System.Drawing.Size(100, 20);
            this.SoHDNTB.TabIndex = 34;
            this.SoHDNTB.TextChanged += new System.EventHandler(this.SoHDNTB_TextChanged);
            // 
            // CBBMAHANG
            // 
            this.CBBMAHANG.FormattingEnabled = true;
            this.CBBMAHANG.Location = new System.Drawing.Point(218, 221);
            this.CBBMAHANG.Name = "CBBMAHANG";
            this.CBBMAHANG.Size = new System.Drawing.Size(121, 21);
            this.CBBMAHANG.TabIndex = 53;
            this.CBBMAHANG.SelectedIndexChanged += new System.EventHandler(this.CBBMAHANG_SelectedIndexChanged);
            // 
            // Formchitiethoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 636);
            this.Controls.Add(this.CBBMAHANG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgrvFORM2);
            this.Controls.Add(this.BTSUA);
            this.Controls.Add(this.BTDELETE);
            this.Controls.Add(this.BTADDCTHDN);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ExitForm2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBGIAMGIA);
            this.Controls.Add(this.TBDONGIA);
            this.Controls.Add(this.TBSOLUONG);
            this.Controls.Add(this.SoHDNTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Formchitiethoadonnhap";
            this.Text = "Formchitiethoadonnhap";
            this.Load += new System.EventHandler(this.frmChiTietHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvFORM2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgrvFORM2;
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
    }
}