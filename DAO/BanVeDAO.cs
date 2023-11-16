using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.DAO
{
    internal class BanVeDAO
    {
        SqlConnection conn = new DBConnection().conn;
        public DataTable LayDS(SqlCommand cmd)
        {
            DataTable dskh = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dskh);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dskh;
        }
        public void updateGhe(String lichchieu)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateSeatStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLichChieu", SqlDbType.NVarChar).Value = lichchieu;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void updateGiaVe(DateTime ngaychieu, TimeSpan giobatdau)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_TangTienVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgayChieu", SqlDbType.DateTime).Value = ngaychieu;
                cmd.Parameters.Add("@GioBatDau", SqlDbType.Time).Value = giobatdau;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public DataTable searchGhe(String maPhong)
        {
            DataTable dskh = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM f_TimGheTrong(@MaPhong)", conn);
                cmd.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value = maPhong;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dskh);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dskh;
        }
        public void updateoneGhe(int maghe)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_CapNhatTrangThaiGhe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaGhe", SqlDbType.Int).Value = maghe;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void createVe(String manv, String makh, int maghe,  String magiave, String malichchieu,int tongtien )
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_TaoVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", manv);
                cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                cmd.Parameters.AddWithValue("@MaGhe", maghe);
                cmd.Parameters.AddWithValue("@MaGiaVe", magiave);
                cmd.Parameters.AddWithValue("@MaLichChieu", malichchieu);
                cmd.Parameters.AddWithValue("@TongTien", tongtien);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void CreateHoaDonDoAn(string maDoAn, string maKhachHang, int soLuong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_ThemHoaDonDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDoAn", maDoAn);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
