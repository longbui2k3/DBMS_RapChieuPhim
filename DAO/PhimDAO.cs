using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Models;
using System.IO;
using System.Drawing;


namespace QuanLyRapChieuPhim.DAO
{
    internal class PhimDAO
    {
        DBConnection dao = new DBConnection();

        public DataTable LayDanhSachPhim(SqlCommand cmd)
        {
            DataTable dash = new DataTable();
            try
            {
                dao.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { dao.conn.Close(); }
            return dash;
        }
        public DataTable DanhSachPhim()
        {
            SqlCommand cmd = new SqlCommand("Select *from view_Phim", dao.conn);
            return LayDanhSachPhim(cmd);
        }

        public void createPhim(Phim phim) 
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_InsertPhim", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.NVarChar, 25).Value = phim.MaPhim;
            cmd.Parameters.Add("@TenPhim", SqlDbType.NVarChar, 255).Value = phim.TenPhim;
            cmd.Parameters.Add("@Anh", SqlDbType.NVarChar, 255).Value = phim.Anh;
            cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = phim.ThoiLuong;
            cmd.Parameters.Add("@NgayKhoiChieu", SqlDbType.Date).Value = phim.NgayKhoiChieu;
            cmd.Parameters.Add("@DaoDien", SqlDbType.NVarChar, 255).Value = phim.DaoDien;
            cmd.Parameters.Add("@QuocGia", SqlDbType.NVarChar, 255).Value = phim.QuocGia;
            cmd.Parameters.Add("@DienVienChinh", SqlDbType.NVarChar, 255).Value = phim.DienVienChinh;
            cmd.Parameters.Add("@NhaSanXuat", SqlDbType.NVarChar, 255).Value = phim.NhaSanXuat;
            cmd.Parameters.Add("@TomTatPhim", SqlDbType.NVarChar, 255).Value = phim.TomTatPhim;
            cmd.Parameters.Add("@DoTuoi", SqlDbType.Int).Value = phim.DoTuoi;
            cmd.ExecuteNonQuery();
            dao.conn.Close();

        }
        public void updatePhim(Phim phim)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_UpdatePhim", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.NVarChar, 25).Value = phim.MaPhim;
            cmd.Parameters.Add("@TenPhim", SqlDbType.NVarChar, 255).Value = phim.TenPhim;
            cmd.Parameters.Add("@Anh", SqlDbType.NVarChar, 255).Value = phim.Anh;
            cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = phim.ThoiLuong;
            cmd.Parameters.Add("@NgayKhoiChieu", SqlDbType.Date).Value = phim.NgayKhoiChieu;
            cmd.Parameters.Add("@DaoDien", SqlDbType.NVarChar, 255).Value = phim.DaoDien;
            cmd.Parameters.Add("@QuocGia", SqlDbType.NVarChar, 255).Value = phim.QuocGia;
            cmd.Parameters.Add("@DienVienChinh", SqlDbType.NVarChar, 255).Value = phim.DienVienChinh;
            cmd.Parameters.Add("@NhaSanXuat", SqlDbType.NVarChar, 255).Value = phim.NhaSanXuat;
            cmd.Parameters.Add("@TomTatPhim", SqlDbType.NVarChar, 255).Value = phim.TomTatPhim;
            cmd.Parameters.Add("@DoTuoi", SqlDbType.Int).Value = phim.DoTuoi;
            cmd.ExecuteNonQuery();
            dao.conn.Close();
        }
        public void deletePhim(Phim phim)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_DeletePhim", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhim", SqlDbType.VarChar).Value = phim.MaPhim;
            cmd.ExecuteNonQuery();
            dao.conn.Close();
        }
        public void ThucThi(string sqlStr) 
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        
    }
}
