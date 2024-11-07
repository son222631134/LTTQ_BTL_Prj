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
using System.Windows.Forms.DataVisualization.Charting;
using BTL_Prj.Class;

namespace BTL_Prj.Frm.Dashboard
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadChart1Data();
            LoadChart2Data();
            DisplayProfitOrLoss();
            chart_chitieu.Font = new Font("Times New Roman", 12, FontStyle.Bold); // Change the font here
            chart_doanhthu.Font = new Font("Times New Roman", 12, FontStyle.Bold); // Change the font here
        }
        private void LoadChart1Data()
        {
            //string connectionString = "Data Source=MAN4KA\\DATABASE_LEARN;Initial Catalog=MoreQLBanHoaQua;Persist Security Info=True;User ID=sa;Password=manaka;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT SoHDB, SUM(TongTien) as TT FROM HoaDonBan GROUP BY SoHDB";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ProcessingData.SqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart_doanhthu.Series.Clear();
                var series = new Series("Doanh Thu")
                {
                    XValueMember = "SoHDB",
                    YValueMembers = "TT",
                    ChartType = SeriesChartType.Column
                };

                chart_doanhthu.DataSource = dataTable;
                chart_doanhthu.Series.Add(series);
                chart_doanhthu.DataBind();
            }
        }
        private void LoadChart2Data()
        {
            //string connectionString = "Data Source=MAN4KA\\DATABASE_LEARN;Initial Catalog=MoreQLBanHoaQua;Persist Security Info=True;User ID=sa;Password=manaka;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT SoHDN, SUM(TongTien) as TT FROM HoaDonNhap GROUP BY SoHDN";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ProcessingData.SqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart_chitieu.Series.Clear();
                var series = new Series("Chi Tiêu")
                {
                    XValueMember = "SoHDN",
                    YValueMembers = "TT",
                    ChartType = SeriesChartType.Column
                };

                chart_chitieu.DataSource = dataTable;
                chart_chitieu.Series.Add(series);
                chart_chitieu.DataBind();
            }
        }

        private void DisplayProfitOrLoss()
        {
            decimal chiTieu = 0;
            decimal doanhThu = 0;
            //string connectionString = "Data Source=MAN4KA\\DATABASE_LEARN;Initial Catalog=MoreQLBanHoaQua;Persist Security Info=True;User ID=sa;Password=manaka;Encrypt=True;TrustServerCertificate=True";
            string query1 = "SELECT SUM(TongTien) AS TongChi FROM HoaDonNhap";
            string query2 = "SELECT SUM(TongTien) AS TongThu FROM HoaDonBan";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, ProcessingData.SqlConnection);
                //connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    chiTieu = reader.GetDecimal(reader.GetOrdinal("TongChi"));
                }

                reader.Close();
            }

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query2, ProcessingData.SqlConnection);
                //connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    doanhThu = reader.GetDecimal(reader.GetOrdinal("TongThu"));
                }
                reader.Close();
            }

            decimal ketQua = doanhThu - chiTieu;
            lblProfitOrLoss.Text = ketQua >= 0 ? "Lãi: " + ketQua : "Lỗ: " + ketQua;
            lblProfitOrLoss.ForeColor = ketQua >= 0 ? Color.Green : Color.Red;
        }
        private void FrmDashboard_SizeChanged(object sender, EventArgs e)
        {
            panel_ChiTieu.Width = panel_DoanhThu.Width = this.Width / 2;
            chart_chitieu.Size = chart_doanhthu.Size = new Size(panel_ChiTieu.Width * 2 / 3, panel_ChiTieu.Height * 2 / 3);
            chart_chitieu.Location = chart_doanhthu.Location = new Point(panel_ChiTieu.Width / 2 - chart_chitieu.Width / 2,
                                                                            panel_ChiTieu.Height / 2 - chart_chitieu.Height / 2);
            label_chitieu.Width = label_doanhthu.Width = this.Width / 2;
        }
    }
}
