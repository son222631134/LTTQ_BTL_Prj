using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HoaDonBan.Class
{
    class Functions
    {
        public static SqlConnection con;

        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MAN4KA\DATABASE_LEARN;Initial Catalog=QLBanHoaQua;User ID=sa;Password=manaka;TrustServerCertificate=True";
            con.Open();
            if (con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            // Đảm bảo rằng kết nối đã được khởi tạo
            if (Functions.con == null)
            {
                Functions.con = new SqlConnection(@"Data Source=MAN4KA\DATABASE_LEARN;Initial Catalog=QLBanHoaQua;User ID=sa;Password=manaka;TrustServerCertificate=True"); // Thay đổi với chuỗi kết nối thực tế
            }

            // Khai báo đối tượng SqlDataAdapter
            using (SqlDataAdapter dap = new SqlDataAdapter())
            {
                // Tạo đối tượng SqlCommand
                dap.SelectCommand = new SqlCommand
                {
                    Connection = Functions.con, // Kết nối cơ sở dữ liệu
                    CommandText = sql // Lệnh SQL
                };

                // Khai báo đối tượng DataTable
                DataTable table = new DataTable();

                try
                {
                    // Mở kết nối nếu chưa mở
                    if (Functions.con.State != ConnectionState.Open)
                    {
                        Functions.con.Open();
                    }

                    // Điền dữ liệu vào DataTable
                    dap.Fill(table);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo kết nối sẽ được đóng
                    if (Functions.con.State == ConnectionState.Open)
                    {
                        Functions.con.Close();
                    }
                }

                return table;
            }
        }


        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp break; 
                    switch ((mLen - i) % 9)
                    {
                        case 0:
                            mTemp = mTemp + " tỷ";
                            for (int j = 0; j < sNumber.Length; j++)
                            {
                                if (i + 3 < sNumber.Length) 
                                {
                                    if (sNumber.Substring(i + 1, 3) == "000")
                                    {
                                        i = i + 3;
                                    }
                                }
                            }

                            //if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            //if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 6:
                            mTemp = mTemp + " triệu";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 3:
                            mTemp = mTemp + " nghìn";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        default:
                            switch ((mLen - i) % 3)
                            {
                                case 2:
                                    mTemp = mTemp + " trăm";
                                    break;
                                case 1:
                                    mTemp = mTemp + " mươi";
                                    break;
                            }
                            break;
                    }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", ""); //Loại bỏ trường hợp 00x 
            mTemp = mTemp.Replace("không mươi ", "linh "); //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
    }
}
