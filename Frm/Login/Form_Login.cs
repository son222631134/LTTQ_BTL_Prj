using BTL_Prj.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Prj
{
    public partial class Form_Login : Form
    {
        public bool isFail = true;
        public string username;
        public string name;
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            ProcessingData.OpenConnection();
            Prepare.setFormProperties(this);
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
            DataTable dt = ProcessingData.NhanVien_SearchNhanVien(username);

            if (username == string.Empty)
            {
                MessageBox.Show("incorrect username or password");
                return;
            }

            string result = "";
            try
            {
                result = dt.Rows[0]["MaNV"].ToString();
            }
            catch (Exception ex)
            {
                result = null;
            }

            if (result == null && username.ToLower() != "admin")
            {
                MessageBox.Show("incorrect username or password");
                return;
            }

            this.isFail = false;
            this.username = username;
            this.name = username.ToLower()=="admin" ? "Admin" :  dt.Rows[0]["TenNV"].ToString();
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.isFail = true;
            this.Close();
            return;
            DialogResult result = MessageBox.Show("Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form_Login_FormClosed(object sender, FormClosingEventArgs e)
        {
            ProcessingData.CloseConnection();
        }
    }
}
