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
        public bool isAdmin = false;
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
            txt_TaiKhoan.Focus();
            txt_MatKhau.UseSystemPasswordChar = true;

            txt_TaiKhoan.Text = "NV1";
            txt_MatKhau.Text = "123";

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;

            //validate
            if (true)
            {

                if (username =="" || password == "")
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được để trống!");
                    return;
                }
                if (username.Contains(' ') || password.Contains(' '))
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được có dấu cách!");
                    return;
                }
            }

            DataTable dt = ProcessingData.GetData("SELECT * FROM Account" +
                " WHERE Username = " + "\'" + username + "\'" +
                " AND Password   = " + "\'" + password + "\'");

            try
            {
                this.isFail = dt.Rows.Count == 0 ? true : false;
                //MessageBox.Show(dt.Rows.Count.ToString());
            }
            catch (Exception ex)
            {
                this.isFail = false;
            }

            if (this.isFail == true)
            {
                MessageBox.Show("incorrect username or password");
                return;
            }

            this.isFail = false;
            this.isAdmin = bool.Parse(dt.Rows[0]["IsAdmin"].ToString()) ;
            this.username = username;
            this.name = dt.Rows[0]["Username"].ToString();
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

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProcessingData.CloseConnection();
        }

        private void txt_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_MatKhau.Focus();
            }
        }
        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_DangNhap_Click(sender, e);
            }

        }
    }
}
