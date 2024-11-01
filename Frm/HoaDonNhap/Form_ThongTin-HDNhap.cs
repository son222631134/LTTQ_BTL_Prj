﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_Prj.Class;
using BTL_Prj.Class.HoaDonNhap;

namespace BTL_Prj.Frm.HoaDonNhap
{
    public partial class frmHoaDonNhap : Form
    {
        private  DataProcess dataProcess = new DataProcess();
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void FrmThongTinHDNhap_Load(object sender, EventArgs e)
        {
            Prepare prepare = new Prepare();
            prepare.setFormProperties(this);
            prepare.setDgvProperties(dgvHoaDonNhap);
            dataProcess = new DataProcess(prepare.getDatabaseDirectory());

            LoadComboBoxData();
            LoadDataToGridView();
        }
        private void LoadComboBoxData()
        {
            // Load MaNV vào ComboBox CBBMNV
            DataTable dtMaNV = dataProcess.GetComboBoxData("NhanVien", "MaNV", "MaNV");
            CBBMNV.DataSource = dtMaNV;
            CBBMNV.DisplayMember = "TenNV";
            CBBMNV.ValueMember = "MaNV";
            CBBMNV.SelectedIndex = -1; // Không chọn giá trị mặc định

            // Load MaNCC vào ComboBox CBBNCC
            DataTable dtMaNCC = dataProcess.GetComboBoxData("NhaCungCap", "MaNCC", "MaNCC");
            CBBNCC.DataSource = dtMaNCC;
            CBBNCC.DisplayMember = "TenNCC";
            CBBNCC.ValueMember = "MaNCC";
            CBBNCC.SelectedIndex = -1; // Không chọn giá trị mặc định
        }
        private void LoadDataToGridView()
        {
            // Hiển thị dữ liệu bảng HoaDonNhap vào DataGridView
            string query = "SELECT * FROM HoaDonNhap";
            DataTable dt = dataProcess.GetData(query);
            dgvHoaDonNhap.DataSource = dt;
        }
        private void TBHDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBBMNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBBNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatetimeNC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TONGTIENTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            TBHDN.Clear();
            CBBMNV.SelectedIndex = -1;
            CBBNCC.SelectedIndex = -1;
            DatetimeNC.Value = DateTime.Now;
            
        }

        private void Chitiethoadon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgvHoaDonNhap.CurrentRow != null)
            {
                // Lấy giá trị SoHDN từ hàng được chọn
                string soHDN = dgvHoaDonNhap.CurrentRow.Cells["SoHDN"].Value.ToString();

                // Mở Formchitiethoadonnhap và truyền SoHDN
                frmChiTietHDNhap formCTHDN = new frmChiTietHDNhap(soHDN);
                formCTHDN.Show(); // Hiển thị form chi tiết hóa đơn nhập
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.");
            }
        }

        private void THEM_Click(object sender, EventArgs e)
        {
            try
            {
                var columnValues = new Dictionary<string, object>
                {
                    { "SoHDN", TBHDN.Text },
                    { "MaNV", CBBMNV.SelectedValue },
                    { "MaNCC", CBBNCC.SelectedValue },
                    { "NgayNhap", DatetimeNC.Value },

                };

                dataProcess.Insert("HoaDonNhap", columnValues);
                MessageBox.Show("Thêm hóa đơn nhập thành công!");
                LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn nhập: " + ex.Message);
            }
        }

        private void SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBHDN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để cập nhật.");
                return;
            }

            if (CBBMNV.SelectedValue == null || CBBNCC.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn giá trị hợp lệ cho Mã NV và Mã NCC.");
                return;
            }

            try
            {
                var columnValues = new Dictionary<string, object>
                {
                    { "MaNV", CBBMNV.SelectedValue },
                    { "MaNCC", CBBNCC.SelectedValue },
                    { "NgayNhap", DatetimeNC.Value },
                };

                dataProcess.Update("HoaDonNhap", columnValues, "SoHDN", TBHDN.Text);
                MessageBox.Show("Cập nhật hóa đơn nhập thành công!");
                LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hóa đơn nhập: " + ex.Message);
            }
        }
    

        private void XOA_Click(object sender, EventArgs e)
        {
            try
            {
                dataProcess.Delete("HoaDonNhap", "SoHDN", TBHDN.Text);
                MessageBox.Show("Xóa hóa đơn nhập thành công!");
                LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn nhập: " + ex.Message);
            }
        }

        private void THoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgrvHDN_Click(object sender, EventArgs e)
        {

        }

        private void dtgrvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị dữ liệu từ hàng đã chọn lên các TextBox và ComboBox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDonNhap.Rows[e.RowIndex];
                TBHDN.Text = row.Cells["SoHDN"].Value.ToString();
                CBBMNV.SelectedValue = row.Cells["MaNV"].Value;
                CBBNCC.SelectedValue = row.Cells["MaNCC"].Value;
                DatetimeNC.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
