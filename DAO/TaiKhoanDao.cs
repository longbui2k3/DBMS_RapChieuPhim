using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Models;
using QuanLyRapChieuPhim.UC;

namespace QuanLyRapChieuPhim.DAO
{
    internal class TaiKhoanDao
    {
        SqlConnection conn = new DBConnection().conn;
        public SqlDataReader LayDanhSachTaiKhoan()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from v_HienThiTaiKhoan", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable DangNhap(TaiKhoan taiKhoan)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sql_cmd = new SqlCommand("Select * from func_DangNhap(@TenNguoiDung, @MatKhau)", conn);
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
            sql_cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;

            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public void createTaiKhoan(TaiKhoan taiKhoan)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_InsertTaiKhoan", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
            sql_cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
            sql_cmd.Parameters.Add("@LoaiTaiKhoan", SqlDbType.VarChar).Value = taiKhoan.LoaiTaiKhoan;

            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateTaiKhoan(TaiKhoan taiKhoan)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_UpdateTaiKhoan", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
            sql_cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;

            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteTaiKhoan(TaiKhoan taiKhoan)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_DeleteTaiKhoan", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public SqlDataReader searchTaiKhoan(String search)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM f_SearchTaiKhoan(@searchStr)", conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataReader reader = sql_cmd.ExecuteReader();
            return reader;
        }
    }
}
