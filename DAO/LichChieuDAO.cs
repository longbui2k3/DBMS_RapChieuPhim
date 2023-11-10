using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.DAO
{
    internal class LichChieuDAO
    {
        SqlConnection conn = new DBConnection().conn;
        public DataTable LayDanhSachLichChieuPhim()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from v_HienThiLichChieuPhim", conn);
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

        public void createLichChieu(LichChieuPhim lichChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_InsertLichChieu", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = lichChieuPhim.NgayChieu;
            sql_cmd.Parameters.Add("@GioBatDau", SqlDbType.Time).Value = lichChieuPhim.GioBatDau;
            sql_cmd.Parameters.Add("@GioKetThuc", SqlDbType.Time).Value = lichChieuPhim.GioKetThuc;
            sql_cmd.Parameters.Add("@SoGheConLai", SqlDbType.Int).Value = lichChieuPhim.SoGheConLai;
            sql_cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = lichChieuPhim.MaPhong;
            sql_cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar).Value = lichChieuPhim.MaPhim;
            sql_cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = lichChieuPhim.MaChiNhanh;

            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateLichChieu(LichChieuPhim lichChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_UpdateLichChieu", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@MaLichChieu", SqlDbType.VarChar).Value = lichChieuPhim.MaLichChieu;
            sql_cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = lichChieuPhim.NgayChieu;
            sql_cmd.Parameters.Add("@GioBatDau", SqlDbType.Time).Value = lichChieuPhim.GioBatDau;
            sql_cmd.Parameters.Add("@GioKetThuc", SqlDbType.Time).Value = lichChieuPhim.GioKetThuc;
            sql_cmd.Parameters.Add("@SoGheConLai", SqlDbType.Int).Value = lichChieuPhim.SoGheConLai;
            sql_cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = lichChieuPhim.MaPhong;
            sql_cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar).Value = lichChieuPhim.MaPhim;
            sql_cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = lichChieuPhim.MaChiNhanh;


            sql_cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void deleteLichChieu(LichChieuPhim lichChieuPhim)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_DeleteLichChieu", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.AddWithValue("@MaLichChieu", SqlDbType.VarChar).Value = lichChieuPhim.MaLichChieu;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable searchLichChieu(String search)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM f_SearchLichChieu(@searchStr)", conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
