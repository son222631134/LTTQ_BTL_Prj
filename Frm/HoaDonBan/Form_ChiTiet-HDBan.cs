using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BTL_Prj.Class.HoaDonBan;

namespace BTL_Prj.Frm.HoaDonBan
{
    public partial class frmChiTietHoaDonBan : Form
    {
        private DataProcess dataProcess;
        private int soHDB;

        public frmChiTietHoaDonBan(int soHDB)
        {
            InitializeComponent();
            this.soHDB = soHDB;
            dataProcess = new DataProcess();
        }
        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadIcon();
            LoadDatabase();

            dgvChiTietHoaDonBan.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            LoadDataGridView();
            LoadMaHang();
            cboMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtThanhTien.Enabled = false;
            SetFieldsState(false);
            cboMaHang.SelectedIndexChanged += cboMaHang_SelectedIndexChanged;
            txtSoLuong.Leave += txtSoLuong_Leave;
            txtGiamGia.Leave += txtGiamGia_Leave;
            dgvChiTietHoaDonBan.CellDoubleClick += dgvChiTietHoaDonBan_CellDoubleClick;
            dgvChiTietHoaDonBan.CellClick += dgvChiTietHoaDonBan_CellClick;
        }
        private void LoadIcon()
        {
            string stringProjectName = Assembly.GetExecutingAssembly().GetName().Name;
            string stringCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;  //get current directory
            string stringDirectory = stringCurrentDirectory.Substring(0, stringCurrentDirectory.IndexOf(stringProjectName)) + stringProjectName+"\\Media\\32x32-LogoUTC.ico";
            this.Icon = new Icon(stringDirectory);
        }
        private void LoadDatabase()
        {
            string stringProjectName = Assembly.GetExecutingAssembly().GetName().Name;
            string stringCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;  //get current directory
            string stringDataDirectory = stringCurrentDirectory.Substring(0, stringCurrentDirectory.IndexOf(stringProjectName)) + stringProjectName + "\\Database\\Database_BTL.mdf"; //get data directory by find Project directory, then combine with Database directory
            dataProcess = new DataProcess(stringDataDirectory);
        }

        private void SetFieldsState(bool enabled)
        {
            btnClearCT.Enabled = enabled;
            btnHuy.Enabled = enabled;
            txtSoLuong.Enabled = enabled;
            txtGiamGia.Enabled = enabled;
        }


        private void LoadDataGridView()
        {
            try
            {
                string query = "SELECT * FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB";
                var parameters = new Dictionary<string, object> { { "@SoHDB", soHDB } };
                DataTable dt = dataProcess.GetData(query, parameters);
                dgvChiTietHoaDonBan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemThongTinHDVaoCDSL()
        {
            try
            {
                // Truy vấn để kiểm tra sự tồn tại của hàng hóa trong hóa đơn
                string checkQuery = "SELECT * FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB AND MaHang = @MaHang";
                var checkParams = new Dictionary<string, object>
                {
                    { "@SoHDB", soHDB },
                    { "@MaHang", int.Parse(cboMaHang.Text) }
                };

                // Lấy dữ liệu từ cơ sở dữ liệu
                DataTable dt = dataProcess.GetData(checkQuery, checkParams);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hàng đã tồn tại trong hóa đơn. Vui lòng chọn mã hàng khác.", "Thông báo");
                    return;
                }

                // Thực hiện thêm thông tin vào cơ sở dữ liệu
                string query = "INSERT INTO ChiTietHoaDonBan (SoHDB, MaHang, SoLuong, GiamGia, ThanhTien) VALUES (@SoHDB, @MaHang, @SoLuong, @GiamGia, @ThanhTien)";
                var parameters = new Dictionary<string, object>
                {
                    { "@SoHDB", soHDB },
                    { "@MaHang", int.Parse(cboMaHang.Text) },
                    { "@SoLuong", int.Parse(txtSoLuong.Text) },
                    { "@GiamGia", decimal.Parse(txtGiamGia.Text) },
                    { "@ThanhTien", decimal.Parse(txtThanhTien.Text) }
                };
                dataProcess.ExecuteQuery(query, parameters);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thêm: " + e.Message);
            }
        }

        private void ResetValues()
        {
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            txtGiamGia.Text = "0";
            txtDonGiaBan.Text = "";
            txtThanhTien.Text = "0";
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaHang.SelectedItem != null)
            {
                string selectedMaHang = cboMaHang.SelectedItem.ToString();
                GetHangHoa(selectedMaHang);
                CalculateThanhTien();
            }
        }

        private void LoadMaHang()
        {
            try
            {
                string query = "SELECT MaHang FROM DMHangHoa";
                DataTable dt = dataProcess.GetData(query);
                foreach (DataRow row in dt.Rows)
                {
                    cboMaHang.Items.Add(row["MaHang"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã hàng: " + ex.Message);
            }
        }

        private void GetHangHoa(string maHang)
        {
            try
            {
                string query = "SELECT TenHang, DonGiaBan FROM DMHangHoa WHERE MaHang = @MaHang";
                var parameters = new Dictionary<string, object> { { "@MaHang", maHang } };
                DataTable dt = dataProcess.GetData(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    txtTenHang.Text = dt.Rows[0]["TenHang"].ToString();
                    txtDonGiaBan.Text = dt.Rows[0]["DonGiaBan"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy hàng: " + ex.Message);
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Xác nhận đóng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClearCT_Click(object sender, EventArgs e)
        {
            cboMaHang.Enabled = false;
            if (btnThem.Enabled == false)
            {
                ThemThongTinHDVaoCDSL();
                ResetValues();
                SetFieldsState(false);
                LoadDataGridView();
                btnThem.Enabled = true;
            }
            if (btnChinhSua.Enabled == false)
            {
                ChinhSuaThongTinHang();
                ResetValues();
                SetFieldsState(false);
                LoadDataGridView();
                btnChinhSua.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaHang.Enabled = true;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = true;
            
            ResetValues();
            SetFieldsState(true);
        }

        private void dgvChiTietHoaDonBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHang = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteMatHang(maHang);
                    LoadDataGridView();
                    ResetValues();
                    SetFieldsState(false);
                    btnThem.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
        }

        private void DeleteMatHang(string maHang)
        {
            try
            {
                string query = "DELETE FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB AND MaHang = @MaHang";
                var parameters = new Dictionary<string, object>
                {
                    { "@SoHDB", soHDB },
                    { "@MaHang", int.Parse(maHang) }
                };
                dataProcess.ExecuteQuery(query, parameters);
                MessageBox.Show("Xóa mặt hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa mặt hàng: " + ex.Message);
            }
        }

        private void dgvChiTietHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDonBan.Rows[e.RowIndex];

                cboMaHang.Text = row.Cells["MaHang"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                txtGiamGia.Text = row.Cells["GiamGia"].Value.ToString();

                cboMaHang.Enabled = false;
                SetFieldsState(false);
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;

                GetTenHang(cboMaHang.Text);
                GetDonGiaBan(cboMaHang.Text);
            }
        }

        private void GetTenHang(string maHang)
        {
            try
            {
                string query = "SELECT TenHang FROM DMHangHoa WHERE MaHang = @MaHang";
                var parameters = new Dictionary<string, object> { { "@MaHang", maHang } };
                DataTable dt = dataProcess.GetData(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    txtTenHang.Text = dt.Rows[0]["TenHang"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tên hàng: " + ex.Message);
            }
        }

        private void GetDonGiaBan(string maHang)
        {
            try
            {
                string query = "SELECT DonGiaBan FROM DMHangHoa WHERE MaHang = @MaHang";
                var parameters = new Dictionary<string, object> { { "@MaHang", maHang } };
                DataTable dt = dataProcess.GetData(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    txtDonGiaBan.Text = dt.Rows[0]["DonGiaBan"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy đơn giá bán: " + ex.Message);
            }
        }

        private void CalculateThanhTien()
        {
            if (!string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                if (int.TryParse(txtSoLuong.Text, out int soLuong) && decimal.TryParse(txtDonGiaBan.Text, out decimal donGia))
                {
                    decimal thanhTien = soLuong * donGia;

                    if (!string.IsNullOrEmpty(txtGiamGia.Text) && decimal.TryParse(txtGiamGia.Text, out decimal giamGia))
                    {
                        thanhTien -= thanhTien * (giamGia / 100);
                    }

                    txtThanhTien.Text = thanhTien.ToString();
                }
                else
                {
                    txtThanhTien.Text = "0";
                }
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        private void txtGiamGia_Leave(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang trong chế độ thêm, vui lòng hoàn tất thêm hoặc hủy thao tác trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cboMaHang.Text) || string.IsNullOrEmpty(txtSoLuong.Text) ||
            string.IsNullOrEmpty(txtDonGiaBan.Text) || string.IsNullOrEmpty(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvChiTietHoaDonBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SetFieldsState(true);
                btnChinhSua.Enabled = false;
            }
        }

        private void ChinhSuaThongTinHang()
        {
            try
            {
                string query = "UPDATE ChiTietHoaDonBan SET SoLuong = @SoLuong, GiamGia = @GiamGia, ThanhTien = @ThanhTien WHERE SoHDB = @SoHDB AND MaHang = @MaHang";
                var parameters = new Dictionary<string, object>
                {
                    { "@SoHDB", soHDB },
                    { "@MaHang", int.Parse(cboMaHang.Text) },
                    { "@SoLuong", int.Parse(txtSoLuong.Text) },
                    { "@GiamGia", decimal.Parse(txtGiamGia.Text) },
                    { "@ThanhTien", decimal.Parse(txtThanhTien.Text) }
                };
                dataProcess.ExecuteQuery(query, parameters);
                MessageBox.Show("Chỉnh sửa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa mặt hàng: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            cboMaHang.Enabled = false;
            SetFieldsState(false);
            btnThem.Enabled = true;
            btnChinhSua.Enabled = true;
        }
    }
}
