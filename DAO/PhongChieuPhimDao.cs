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
    internal class PhongChieuPhimDao
    {
        SqlConnection conn = new DBConnection().conn;

        public DataTable LayDanhSachPhongChieuPhim()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from v_HienThiPhongChieuPhim", conn);
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
        public void createPhongChieuPhim(PhongChieuPhim phongChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_InsertPhongChieuPhim", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = phongChieuPhim.TenPhong;
            sql_cmd.Parameters.Add("@SoLuongGhe", SqlDbType.NVarChar).Value = phongChieuPhim.SoLuongGhe;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updatePhongChieuPhim(PhongChieuPhim phongChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_UpdatePhongChieuPhim", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = phongChieuPhim.MaPhong;
            sql_cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = phongChieuPhim.TenPhong;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deletePhongChieuPhim(PhongChieuPhim phongChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_DeletePhongChieuPhim", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = phongChieuPhim.MaPhong;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable searchPhongChieuPhim(String search)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM f_SearchPhongChieuPhim(@searchStr)", conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
