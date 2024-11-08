using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BTL_Prj.Class;
using BTL_Prj.Frm.Report.ReportChiTietHoaDonNhap;

namespace BTL_Prj.Frm.HoaDonNhap
{
    public partial class ChildfrmChiTietHDNhap : Form
    {
        private string selectedSoHDN; // Biến lưu số hóa đơn được chọn từ Form
        public ChildfrmChiTietHDNhap()
        {
            InitializeComponent();
        }
        public ChildfrmChiTietHDNhap(string soHDN)
        {
            InitializeComponent();
            selectedSoHDN = soHDN; // Nhận số hóa đơn từ Form1
            SoHDNTB.Text = soHDN.ToString();
        }
        private void ChildfrmChiTietHDNhap_Load(object sender, EventArgs e)
        {
            Prepare.setFormProperties(this);
            Prepare.setDgvProperties(dgvChiTietHoaDonNhap);

            LoadDataToGridView();
            LoadComboBoxData(); // Tải dữ liệu vào ComboBox
        }
        private void LoadDataToGridView()
        {
            // Hiển thị dữ liệu chi tiết hóa đơn nhập vào DataGridView
            string query = $"SELECT * FROM ChiTietHoaDonNhap WHERE SOHDN = '{selectedSoHDN}'"; // Chọn dữ liệu theo số hóa đơn
            DataTable dt = ProcessingData.GetData(query);
            dgvChiTietHoaDonNhap.DataSource = dt;
        }
        private void LoadComboBoxData()
        {
            // Load mã hàng vào ComboBox CBBMAHANG
            DataTable dtMaHang = ProcessingData.GetComboBoxData("DMHangHoa", "MaHang", "MaHang"); // Lấy dữ liệu từ bảng DMHangHoa
            CBBMAHANG.DataSource = dtMaHang;
            CBBMAHANG.DisplayMember = "MaHang"; // Hiển thị mã hàng trong ComboBox
            CBBMAHANG.ValueMember = "MaHang"; // Giá trị tương ứng với mã hàng
            CBBMAHANG.SelectedIndex = -1; // Không chọn giá trị mặc định
        }
        private void ClearFields()
        {
            // Xóa các trường đầu vào
            SoHDNTB.Clear();
            CBBMAHANG.SelectedIndex = -1; // Xóa lựa chọn mã hàng
            TBSOLUONG.Clear();
            TBDONGIA.Clear();
            TBGIAMGIA.Clear();
        }
        private void BTADDCTHDN_Click(object sender, EventArgs e)
        {
            try
            {
                var columnValues = new Dictionary<string, object>
                {
                    { "SOHDN", selectedSoHDN },
                    { "MaHang", CBBMAHANG.Text },
                    { "SoLuong", Convert.ToInt32(TBSOLUONG.Text) },
                    { "DonGia", Convert.ToDecimal(TBDONGIA.Text) },
                    { "GiamGia", Convert.ToDecimal(TBGIAMGIA.Text) }
                };

                // Tính thành tiền
                decimal donGia = Convert.ToDecimal(TBDONGIA.Text);
                int soLuong = Convert.ToInt32(TBSOLUONG.Text);
                decimal giamGia = Convert.ToDecimal(TBGIAMGIA.Text);
                decimal thanhTien = (donGia * soLuong) - giamGia;

                columnValues.Add("ThanhTien", thanhTien);

                ProcessingData.Insert("ChiTietHoaDonNhap", columnValues);
                MessageBox.Show("Thêm chi tiết hóa đơn nhập thành công!");
                LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
                ClearFields(); // Xóa các trường sau khi thêm
                CapNhatTongTien(selectedSoHDN); // Cập nhật tổng tiền
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn nhập: " + ex.Message);
            }
        }
        private void BTSUA_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDonNhap.CurrentRow != null)
            {
                // Lấy dữ liệu từ hàng được chọn
                string maHang = dgvChiTietHoaDonNhap.CurrentRow.Cells["MaHang"].Value.ToString();

                // Kiểm tra xem mã hàng có được chọn không
                if (CBBMAHANG.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã hàng.");
                    return;
                }

                // Lấy các giá trị từ các TextBox
                int soLuong = int.Parse(TBSOLUONG.Text);
                decimal donGia = decimal.Parse(TBDONGIA.Text);
                decimal giamGia = decimal.Parse(TBGIAMGIA.Text);

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(maHang) || soLuong < 0 || donGia < 0 || giamGia < 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin hợp lệ.");
                    return;
                }

                try
                {
                    // Lấy mã hàng mới từ ComboBox
                    string maHangMoi = CBBMAHANG.SelectedValue.ToString();

                    var columnValues = new Dictionary<string, object>
            {
                { "MaHang", maHangMoi }, // Cập nhật mã hàng mới
                { "SoLuong", soLuong },
                { "DonGia", donGia },
                { "GiamGia", giamGia },
                { "ThanhTien", (soLuong * donGia) - giamGia } // Tính thành tiền
            };

                    // Cập nhật dữ liệu vào bảng ChiTietHoaDonNhap
                    ProcessingData.Update("ChiTietHoaDonNhap", columnValues, "MaHang", maHang); // Sử dụng mã hàng cũ làm điều kiện

                    MessageBox.Show("Cập nhật chi tiết hóa đơn nhập thành công!");
                    LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
                    CapNhatTongTien(selectedSoHDN); // Cập nhật tổng tiền
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật chi tiết hóa đơn nhập: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chi tiết để sửa.");
            }
        }
        private void BTDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác định mã hàng cần xóa
                if (string.IsNullOrEmpty(CBBMAHANG.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã hàng để xóa.");
                    return;
                }

                ProcessingData.Delete("ChiTietHoaDonNhap", "MaHang", CBBMAHANG.Text);
                MessageBox.Show("Xóa chi tiết hóa đơn nhập thành công!");
                LoadDataToGridView(); // Cập nhật lại dữ liệu trên DataGridView
                ClearFields(); // Xóa các trường sau khi xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn nhập: " + ex.Message);
            }
        }
        private void ExitForm2_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
			return;
        }
        private void dtgrvFORM2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvChiTietHoaDonNhap.RowCount - 1) return;
            // Hiển thị dữ liệu từ hàng đã chọn lên các TextBox
            //if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDonNhap.Rows[e.RowIndex];

                // Hiển thị số hóa đơn
                SoHDNTB.Text = row.Cells["SOHDN"].Value.ToString();

                // Hiển thị mã hàng
                CBBMAHANG.SelectedValue = row.Cells["MaHang"].Value; // Cập nhật ComboBox với mã hàng

                // Hiển thị các thông tin khác
                TBSOLUONG.Text = row.Cells["SoLuong"].Value.ToString();
                TBDONGIA.Text = row.Cells["DonGia"].Value.ToString();
                TBGIAMGIA.Text = row.Cells["GiamGia"].Value.ToString();
            }
        }
        public static void CapNhatTongTien(string soHDN)
        {
            try
            {
                // Tính tổng tiền từ chi tiết hóa đơn
                string query = "SELECT SUM(ThanhTien) AS TongTien FROM ChiTietHoaDonNhap WHERE SoHDN = @SoHDN";
                var parameters = new Dictionary<string, object>
                {
                    { "@SoHDN", soHDN }
                };

                DataTable dt = ProcessingData.GetData(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    decimal tongTien = dt.Rows[0]["TongTien"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["TongTien"]) : 0;

                    // Cập nhật tổng tiền vào hóa đơn
                    var updateValues = new Dictionary<string, object>
                    {
                        { "TongTien", tongTien }
                    };

                    // Gọi phương thức Update tổng quát
                    ProcessingData.Update("HoaDonNhap", updateValues, "SoHDN", soHDN);
                    //MessageBox.Show(tongTien.ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tổng tiền: " + ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport_ChiTietHDN report = new FormReport_ChiTietHDN(selectedSoHDN);
            report.ShowDialog();
        }
    }
}
