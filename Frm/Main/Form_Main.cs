using BTL_Prj.Frm.DanhMucHangHoa;
using BTL_Prj.Frm.DanhMucKhachHang;
using BTL_Prj.Frm.HoaDonBan;
using BTL_Prj.Frm.HoaDonNhap;
using BTL_Prj.Frm.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Prj.Frm.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadIcon();
        }
        private void LoadIcon()
        {
            string stringCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;  //get current directory
            string stringDirectory = stringCurrentDirectory.Substring(0, stringCurrentDirectory.IndexOf("BTL_Prj")) + "BTL_Prj\\Media\\32x32-LogoUTC.ico";
            this.Icon = new Icon(stringDirectory);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNhanVien"] as frmNhanVien) == null)
            {
                frmNhanVien frm = new frmNhanVien();
                frm.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmDanhMucKhachHang"] as frmDanhMucKhachHang) == null)
            {
                frmDanhMucKhachHang frm = new frmDanhMucKhachHang();
                frm.Show();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmDanhMucHangHoa"] as frmDanhMucHangHoa) == null)
            {
                frmDanhMucHangHoa frm = new frmDanhMucHangHoa();
                frm.Show();
            }
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmThongTinHDNhap"] as frmThongTinHDNhap) == null)
            {
                frmThongTinHDNhap frm = new frmThongTinHDNhap();
                frm.Show();
            }

        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmHoaDonBan"] as frmHoaDonBan) == null)
            {
            }
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();

        }
    }
}
