using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using BTL_Prj.Class;
using System.Linq;

namespace BTL_Prj.Frm.DanhMucHangHoa
{
	public partial class frmDanhMucHangHoa : Form
	{
		public frmDanhMucHangHoa()
		{
			InitializeComponent();
		}
		private void frmDanhMucHangHoa_Load(object sender, EventArgs e)
		{
			Prepare.setFormProperties(this);
			Prepare.setDgvProperties(dgvHangHoa);
			Prepare.setDgvProperties(dgvHangHoa_TimKiem);
			
			LoadData();
			LoadComboBoxData();
			SetDefaultState();

			picHangHoa.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadData()
		{
			string query = "SELECT * FROM DMHangHoa";
			dgvHangHoa.DataSource = ProcessingData.GetData(query);
            if (dgvHangHoa.Columns["ImagePath"] != null)
            {
                dgvHangHoa.Columns["ImagePath"].Visible = false;
            }
        }

		private void LoadComboBoxData()
		{
			cboMaDonVi.DataSource = ProcessingData.GetComboBoxData("DonViTinh", "MaDonVi", "TenDonVi");
			cboMaDonVi.DisplayMember = "TenDonVi";
			cboMaDonVi.ValueMember = "MaDonVi";

			cboMaNoiSanXuat.DataSource = ProcessingData.GetComboBoxData("NoiSanXuat", "MaNoiSX", "TenNoiSX");
			cboMaNoiSanXuat.DisplayMember = "TenNoiSX";
			cboMaNoiSanXuat.ValueMember = "MaNoiSX";

			cboMaCongDung.DataSource = ProcessingData.GetComboBoxData("CongDung", "MaCongDung", "TenCongDung");
			cboMaCongDung.DisplayMember = "TenCongDung";
			cboMaCongDung.ValueMember = "MaCongDung";

			cboMaMau.DataSource = ProcessingData.GetComboBoxData("MauSac", "MaMau", "TenMau");
			cboMaMau.DisplayMember = "TenMau";
			cboMaMau.ValueMember = "MaMau";

			cboMaDacDiem.DataSource = ProcessingData.GetComboBoxData("DacDiem", "MaDacDiem", "TenDacDiem");
			cboMaDacDiem.DisplayMember = "TenDacDiem";
			cboMaDacDiem.ValueMember = "MaDacDiem";
        }
				private void ClearForm()
		{
			txtMaHang.Clear();
			txtTenHang.Clear();
			txtSoLuong.Clear();
			txtDonGiaNhap.Clear();
			txtDonGiaBan.Clear();
			cboMaDonVi.SelectedIndex = -1;
			cboMaNoiSanXuat.SelectedIndex = -1;
			cboMaCongDung.SelectedIndex = -1;
			cboMaMau.SelectedIndex = -1;
			cboMaDacDiem.SelectedIndex = -1;
			picHangHoa.ImageLocation = string.Empty;
		}
		private void SetDefaultState()
		{
			ClearForm(); 
			EnableFields(false); 
			btnLuu.Enabled = false; 
		}
		private void EnableFields(bool isEnabled)
		{
			txtMaHang.Enabled = isEnabled;
			txtTenHang.Enabled = isEnabled;
			txtSoLuong.Enabled = isEnabled;
			txtDonGiaNhap.Enabled = isEnabled;
			txtDonGiaBan.Enabled = isEnabled;
			cboMaDonVi.Enabled = isEnabled;
			cboMaNoiSanXuat.Enabled = isEnabled;
			cboMaCongDung.Enabled = isEnabled;
			cboMaMau.Enabled = isEnabled;
			cboMaDacDiem.Enabled = isEnabled;
			btnBrowse.Enabled = isEnabled; 
		}
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picHangHoa.ImageLocation = ofd.FileName;
                    picHangHoa.SizeMode = PictureBoxSizeMode.Zoom; // Thu nhỏ ảnh vừa với PictureBox
                }
            }
        }

		//tabpage_ThongTinChung
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableFields(true);
            txtMaHang.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHang.Text))
            {
                EnableFields(true);
                txtMaHang.Enabled = false;
                btnLuu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHang.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ProcessingData.Delete("DMHangHoa", "MaHang", txtMaHang.Text);
                        MessageBox.Show("Dữ liệu đã được xóa!");
                        LoadData();
                        SetDefaultState();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
		private void btnHuy_Click(object sender, EventArgs e)
		{
			SetDefaultState(); 
		}
        private void btnLuu_Click(object sender, EventArgs e)
		{
			if (txtMaHang.Enabled)
			{
				// Insert scenario
				if (int.TryParse(txtSoLuong.Text, out int soLuong) &&
					decimal.TryParse(txtDonGiaNhap.Text, out decimal donGiaNhap) &&
					decimal.TryParse(txtDonGiaBan.Text, out decimal donGiaBan))	{
					//then
					string src = picHangHoa.ImageLocation;
					string dest = Prepare.getProjectDirectory() + Prepare.getMediaDirectoryInProject() + "\\HangHoa\\" + "ImgHangHoa" + txtMaHang.Text;
					Function.CopyFile(src, dest);
					var columnValues = new Dictionary<string, object> {
						{ "MaHang", txtMaHang.Text },
						{ "TenHang", txtTenHang.Text },
						{ "SoLuong", soLuong },
						{ "DonGiaNhap", donGiaNhap },
						{ "DonGiaBan", donGiaBan },
						{ "MaDonVi", cboMaDonVi.SelectedValue.ToString() },
						{ "MaNoiSX", cboMaNoiSanXuat.SelectedValue.ToString() },
						{ "MaCongDung", cboMaCongDung.SelectedValue.ToString() },
						{ "MaMau", cboMaMau.SelectedValue.ToString() },
						{ "MaDacDiem", cboMaDacDiem.SelectedValue.ToString() },
						{ "ImagePath", dest }
					};

					try
					{
						ProcessingData.Insert("DMHangHoa", columnValues);
						MessageBox.Show("Dữ liệu đã được thêm thành công!");
						LoadData();
						SetDefaultState();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				// Update scenario
				if (int.TryParse(txtSoLuong.Text, out int soLuong) &&
					decimal.TryParse(txtDonGiaNhap.Text, out decimal donGiaNhap) &&
					decimal.TryParse(txtDonGiaBan.Text, out decimal donGiaBan))
                { //then
                    string src = picHangHoa.ImageLocation;
                    string dest = Prepare.getProjectDirectory() + Prepare.getMediaDirectoryInProject() + "HangHoa\\" + "ImgHangHoa" + txtMaHang.Text + ".jpg";
                    Function.CopyFile(src, dest);
					MessageBox.Show(src + "\r\n" + dest);
                    var columnValues = new Dictionary<string, object>
					{
						{ "TenHang", txtTenHang.Text },
						{ "SoLuong", soLuong },
						{ "DonGiaNhap", donGiaNhap },
						{ "DonGiaBan", donGiaBan },
						{ "MaDonVi", cboMaDonVi.SelectedValue.ToString() },
						{ "MaNoiSX", cboMaNoiSanXuat.SelectedValue.ToString() },
						{ "MaCongDung", cboMaCongDung.SelectedValue.ToString() },
						{ "MaMau", cboMaMau.SelectedValue.ToString() },
						{ "MaDacDiem", cboMaDacDiem.SelectedValue.ToString() },
						{ "ImagePath", dest }
					};

					try
					{
						ProcessingData.Update("DMHangHoa", columnValues, "MaHang", txtMaHang.Text);
						MessageBox.Show("Dữ liệu đã được cập nhật!");
						LoadData();
						SetDefaultState();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
		private void btnDong_Click(object sender, EventArgs e)
		{
            this.Close();
			return;
            DialogResult result = MessageBox.Show("Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				dgvHangHoa.CurrentCell = dgvHangHoa.Rows[e.RowIndex].Cells[e.ColumnIndex];
				DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
				txtMaHang.Text = row.Cells["MaHang"].Value.ToString();
				txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
				txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
				txtDonGiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
				txtDonGiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();
				cboMaDonVi.SelectedValue = row.Cells["MaDonVi"].Value;
				cboMaNoiSanXuat.SelectedValue = row.Cells["MaNoiSX"].Value;
				cboMaCongDung.SelectedValue = row.Cells["MaCongDung"].Value;
				cboMaMau.SelectedValue = row.Cells["MaMau"].Value;
				cboMaDacDiem.SelectedValue = row.Cells["MaDacDiem"].Value;
				picHangHoa.ImageLocation = row.Cells["ImagePath"].Value.ToString();
				EnableFields(false); 
			}
		}


        //tabpage_TimKiem		
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            SetDefaultState();
            LoadData();
            txtTimKiem.Clear();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                LoadData();
                return;
            }

            string[] searchColumns = { "MaHang", "TenHang" };
            //dgvHangHoa.DataSource = ProcessingData.Search("DMHangHoa", searchColumns, searchValue);
            dgvHangHoa_TimKiem.DataSource = ProcessingData.Search("DMHangHoa", searchColumns, searchValue);
        }
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(sender, e);
        }
        private void dgvHangHoa_TimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvHangHoa_TimKiem.CurrentRow.Index < 1) return;
            string MaHang = dgvHangHoa_TimKiem.CurrentRow.Cells["MaHang"].Value.ToString();

            int Row_in_dgvHangHoa = -1;
            DataGridViewRow row = dgvHangHoa.Rows
				.Cast<DataGridViewRow>()
				.Where(r => r.Cells["MaHang"].Value.ToString().Equals(MaHang))
				.First();
			Row_in_dgvHangHoa = row.Index;
            dgvHangHoa_CellClick(sender, new DataGridViewCellEventArgs(/*dgvHangHoa_TimKiem.CurrentCell.ColumnIndex*/0, /*dgvHangHoa_TimKiem.CurrentRow.Index*/ Row_in_dgvHangHoa));
            tabControl1.SelectedTab = tabControl1.TabPages[0];

        }

        private void frmDanhMucHangHoa_StyleChanged(object sender, EventArgs e)
        {
        }
    }
}
