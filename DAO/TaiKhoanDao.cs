using System;
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
        public DataTable LayDanhSachTaiKhoan()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from v_HienThiTaiKhoan", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
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
        public DataTable searchTaiKhoan(String search)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM f_SearchTaiKhoan(@searchStr)", conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
