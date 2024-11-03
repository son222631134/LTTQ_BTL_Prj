namespace BTL_Prj.Frm.DanhMucHangHoa
{
    partial class frmDanhMucHangHoa
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picHangHoa = new System.Windows.Forms.PictureBox();
            this.cboMaDacDiem = new System.Windows.Forms.ComboBox();
            this.cboMaMau = new System.Windows.Forms.ComboBox();
            this.cboMaCongDung = new System.Windows.Forms.ComboBox();
            this.cboMaNoiSanXuat = new System.Windows.Forms.ComboBox();
            this.cboMaDonVi = new System.Windows.Forms.ComboBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel_button = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1_ThongTinChung = new System.Windows.Forms.TabPage();
            this.tabPage_TimKiem = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangHoa)).BeginInit();
            this.panel_button.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1_ThongTinChung.SuspendLayout();
            this.tabPage_TimKiem.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThem.Location = new System.Drawing.Point(20, 10);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLuu.Location = new System.Drawing.Point(644, 10);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDong.Location = new System.Drawing.Point(800, 10);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoa.Location = new System.Drawing.Point(332, 10);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvHangHoa
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(3, 205);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(0);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(940, 322);
            this.dgvHangHoa.TabIndex = 5;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.picHangHoa);
            this.panel1.Controls.Add(this.cboMaDacDiem);
            this.panel1.Controls.Add(this.cboMaMau);
            this.panel1.Controls.Add(this.cboMaCongDung);
            this.panel1.Controls.Add(this.cboMaNoiSanXuat);
            this.panel1.Controls.Add(this.cboMaDonVi);
            this.panel1.Controls.Add(this.txtDonGiaBan);
            this.panel1.Controls.Add(this.txtDonGiaNhap);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 202);
            this.panel1.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(727, 152);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 27);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Chọn ảnh";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picHangHoa
            // 
            this.picHangHoa.Location = new System.Drawing.Point(703, 36);
            this.picHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.picHangHoa.Name = "picHangHoa";
            this.picHangHoa.Size = new System.Drawing.Size(121, 106);
            this.picHangHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHangHoa.TabIndex = 6;
            this.picHangHoa.TabStop = false;
            // 
            // cboMaDacDiem
            // 
            this.cboMaDacDiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboMaDacDiem.FormattingEnabled = true;
            this.cboMaDacDiem.Location = new System.Drawing.Point(487, 155);
            this.cboMaDacDiem.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaDacDiem.Name = "cboMaDacDiem";
            this.cboMaDacDiem.Size = new System.Drawing.Size(119, 27);
            this.cboMaDacDiem.TabIndex = 3;
            // 
            // cboMaMau
            // 
            this.cboMaMau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboMaMau.FormattingEnabled = true;
            this.cboMaMau.Location = new System.Drawing.Point(487, 122);
            this.cboMaMau.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaMau.Name = "cboMaMau";
            this.cboMaMau.Size = new System.Drawing.Size(119, 27);
            this.cboMaMau.TabIndex = 3;
            // 
            // cboMaCongDung
            // 
            this.cboMaCongDung.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboMaCongDung.FormattingEnabled = true;
            this.cboMaCongDung.Location = new System.Drawing.Point(487, 90);
            this.cboMaCongDung.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaCongDung.Name = "cboMaCongDung";
            this.cboMaCongDung.Size = new System.Drawing.Size(119, 27);
            this.cboMaCongDung.TabIndex = 3;
            // 
            // cboMaNoiSanXuat
            // 
            this.cboMaNoiSanXuat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboMaNoiSanXuat.FormattingEnabled = true;
            this.cboMaNoiSanXuat.Location = new System.Drawing.Point(487, 57);
            this.cboMaNoiSanXuat.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNoiSanXuat.Name = "cboMaNoiSanXuat";
            this.cboMaNoiSanXuat.Size = new System.Drawing.Size(119, 27);
            this.cboMaNoiSanXuat.TabIndex = 3;
            // 
            // cboMaDonVi
            // 
            this.cboMaDonVi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboMaDonVi.FormattingEnabled = true;
            this.cboMaDonVi.Location = new System.Drawing.Point(487, 25);
            this.cboMaDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaDonVi.Name = "cboMaDonVi";
            this.cboMaDonVi.Size = new System.Drawing.Size(119, 27);
            this.cboMaDonVi.TabIndex = 3;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDonGiaBan.Location = new System.Drawing.Point(139, 151);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(115, 26);
            this.txtDonGiaBan.TabIndex = 2;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDonGiaNhap.Location = new System.Drawing.Point(139, 119);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(115, 26);
            this.txtDonGiaNhap.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(139, 86);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 26);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenHang.Location = new System.Drawing.Point(139, 54);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(115, 26);
            this.txtTenHang.TabIndex = 2;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaHang.Location = new System.Drawing.Point(139, 21);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(115, 26);
            this.txtMaHang.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label11.Location = new System.Drawing.Point(374, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã đặc điểm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(374, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã màu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(374, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã công dụng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(374, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã nơi sản xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(374, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(34, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(34, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(788, 201);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(67, 20);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(676, 201);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 20);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(701, 178);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(122, 20);
            this.txtTimKiem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HOÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSua.Location = new System.Drawing.Point(176, 10);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHuy.Location = new System.Drawing.Point(488, 10);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.btnThem);
            this.panel_button.Controls.Add(this.btnSua);
            this.panel_button.Controls.Add(this.btnDong);
            this.panel_button.Controls.Add(this.btnXoa);
            this.panel_button.Controls.Add(this.btnLuu);
            this.panel_button.Controls.Add(this.btnHuy);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(3, 530);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(940, 60);
            this.panel_button.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1_ThongTinChung);
            this.tabControl1.Controls.Add(this.tabPage_TimKiem);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 619);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1_ThongTinChung
            // 
            this.tabPage1_ThongTinChung.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1_ThongTinChung.Controls.Add(this.dgvHangHoa);
            this.tabPage1_ThongTinChung.Controls.Add(this.panel1);
            this.tabPage1_ThongTinChung.Controls.Add(this.panel_button);
            this.tabPage1_ThongTinChung.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tabPage1_ThongTinChung.Location = new System.Drawing.Point(4, 4);
            this.tabPage1_ThongTinChung.Name = "tabPage1_ThongTinChung";
            this.tabPage1_ThongTinChung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_ThongTinChung.Size = new System.Drawing.Size(946, 593);
            this.tabPage1_ThongTinChung.TabIndex = 0;
            this.tabPage1_ThongTinChung.Text = "Thông tin chung";
            // 
            // tabPage_TimKiem
            // 
            this.tabPage_TimKiem.Controls.Add(this.txtTimKiem);
            this.tabPage_TimKiem.Controls.Add(this.btnTimKiem);
            this.tabPage_TimKiem.Controls.Add(this.btnQuayLai);
            this.tabPage_TimKiem.Location = new System.Drawing.Point(4, 4);
            this.tabPage_TimKiem.Name = "tabPage_TimKiem";
            this.tabPage_TimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TimKiem.Size = new System.Drawing.Size(946, 593);
            this.tabPage_TimKiem.TabIndex = 1;
            this.tabPage_TimKiem.Text = "Tìm Kiếm";
            this.tabPage_TimKiem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 80);
            this.panel3.TabIndex = 12;
            // 
            // frmDanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhMucHangHoa";
            this.Text = "DANH MỤC HÀNG HOÁ";
            this.Load += new System.EventHandler(this.frmDanhMucHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangHoa)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1_ThongTinChung.ResumeLayout(false);
            this.tabPage_TimKiem.ResumeLayout(false);
            this.tabPage_TimKiem.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaDacDiem;
        private System.Windows.Forms.ComboBox cboMaMau;
        private System.Windows.Forms.ComboBox cboMaCongDung;
        private System.Windows.Forms.ComboBox cboMaNoiSanXuat;
        private System.Windows.Forms.ComboBox cboMaDonVi;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox picHangHoa;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_ThongTinChung;
        private System.Windows.Forms.TabPage tabPage_TimKiem;
        private System.Windows.Forms.Panel panel3;
    }
}

