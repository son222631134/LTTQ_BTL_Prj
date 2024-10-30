using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Prj.Class.DanhMucHangHoa
{
    internal class DataProcess
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        public DataProcess() { }
        public DataProcess(string connectionString)
        {

            string strConnect = "Data Source=.\\SQLEXPRESS;AttachDbFilename="
            + connectionString
            + ";Integrated Security=True;User Instance=True";

            this.connectionString = strConnect;
            return;
        }

        // Mở kết nối cơ sở dữ liệu
        private void OpenConnection()
        {
            if (sqlConnection == null)
                sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        // Đóng kết nối cơ sở dữ liệu
        private void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        // Phương thức lấy dữ liệu từ bất kỳ bảng nào theo truy vấn SQL
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        // Phương thức thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        public void ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Phương thức INSERT tổng quát vào bất kỳ bảng nào
        public void Insert(string tableName, Dictionary<string, object> columnValues)
        {
            string columns = string.Join(", ", columnValues.Keys);
            string values = string.Join(", ", columnValues.Keys.Select(k => "@" + k));

            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            ExecuteQuery(query, columnValues);
        }

        // Phương thức UPDATE tổng quát cho bất kỳ bảng nào
        public void Update(string tableName, Dictionary<string, object> columnValues, string conditionColumn, object conditionValue)
        {
            string setClause = string.Join(", ", columnValues.Keys.Select(k => $"{k} = @{k}"));
            string query = $"UPDATE {tableName} SET {setClause} WHERE {conditionColumn} = @{conditionColumn}";

            columnValues.Add(conditionColumn, conditionValue); // Thêm điều kiện WHERE vào parameters
            ExecuteQuery(query, columnValues);
        }

        // Phương thức DELETE tổng quát cho bất kỳ bảng nào
        public void Delete(string tableName, string conditionColumn, object conditionValue)
        {
            string query = $"DELETE FROM {tableName} WHERE {conditionColumn} = @{conditionColumn}";

            var parameters = new Dictionary<string, object>
            {
                { conditionColumn, conditionValue }
            };

            ExecuteQuery(query, parameters);
        }

        // Phương thức lấy dữ liệu cho ComboBox từ bất kỳ bảng nào
        public DataTable GetComboBoxData(string tableName, string valueColumn, string displayColumn)
        {
            string query = $"SELECT {valueColumn}, {displayColumn} FROM {tableName}";
            return GetData(query);
        }

        // Phương thức tìm kiếm tổng quát cho bất kỳ bảng nào theo cột cụ thể
        public DataTable Search(string tableName, string[] columnsToSearch, string searchValue)
        {
            string condition = string.Join(" OR ", columnsToSearch.Select(c => $"{c} LIKE @searchValue"));
            string query = $"SELECT * FROM {tableName} WHERE {condition}";

            var parameters = new Dictionary<string, object>
            {
                { "@searchValue", "%" + searchValue + "%" }
            };

            return GetData(query, parameters);
        }

    }
}
