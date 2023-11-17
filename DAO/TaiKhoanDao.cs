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
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand sql_cmd = new SqlCommand("proc_DangNhap", conn);
                sql_cmd.CommandType = CommandType.StoredProcedure;
                sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
                sql_cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;

                SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.Split('\n')[0]);

            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public void resetMatKhau(String tenNguoiDung, String matKhauCu, String matKhauMoi)
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand sql_cmd = new SqlCommand("proc_UpdateTaiKhoan", conn);
                sql_cmd.CommandType = CommandType.StoredProcedure;
                sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = tenNguoiDung;
                sql_cmd.Parameters.Add("@MatKhauMoi", SqlDbType.VarChar).Value = matKhauMoi;
                sql_cmd.Parameters.Add("@MatKhauCu", SqlDbType.VarChar).Value = matKhauCu;
                sql_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Split('\n')[0]);

            }
            finally
            {
                conn.Close();
            }
        }
        public void createTaiKhoan(TaiKhoan taiKhoan, string maNhanVien)
        {
            try
            {
                conn.Open();
                SqlCommand sql_cmd = new SqlCommand("proc_InsertTaiKhoan", conn);
                sql_cmd.CommandType = CommandType.StoredProcedure;
                sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = taiKhoan.TenNguoiDung;
                sql_cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
                sql_cmd.Parameters.Add("@LoaiTaiKhoan", SqlDbType.VarChar).Value = taiKhoan.LoaiTaiKhoan;
                sql_cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = maNhanVien;
                sql_cmd.ExecuteNonQuery();
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Split('\n')[0]);
            }
            finally { conn.Close(); }
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
