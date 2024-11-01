﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_Prj.Class.NhanVien
{
    public class DataProcess
    {
        private string connectionString;

        public DataProcess(string connectionString)
        {
            string strConnect = "Data Source=.\\SQLEXPRESS;AttachDbFilename="
            + connectionString
            + ";Integrated Security=True;User Instance=True";

            this.connectionString = strConnect;
            return;
        }
        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }
        public void AddNhanVien(string maNV, string tenNV, string diaChi, string dienThoai, string gioiTinh, DateTime ngaySinh, string maCV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NhanVien (MaNV, TenNV, DiaChi, DienThoai, GioiTinh, NgaySinh, MaCV) VALUES (@MaNV, @TenNV, @DiaChi, @DienThoai, @GioiTinh, @NgaySinh, @MaCV)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateNhanVien(string maNV, string tenNV, string diaChi, string dienThoai, string gioiTinh, DateTime ngaySinh, string maCV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NhanVien SET TenNV = @TenNV, DiaChi = @DiaChi, DienThoai = @DienThoai, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, MaCV = @MaCV WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteNhanVien(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchNhanVien(string searchValue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @Search OR TenNV LIKE @Search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchValue + "%");
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }
        public DataTable GetMaCVList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaCV FROM CongViec";
                SqlDataAdapter adt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }
    }
}
