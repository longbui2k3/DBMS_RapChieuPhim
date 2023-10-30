using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.DAO
{
    internal class NhanVienDAO
    {
        SqlConnection conn = new DBConnection().conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from v_HienThiNhanVien", conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        public void createNhanVien(NhanVien nhanvien)
        {
            SqlCommand sql_cmd = new SqlCommand("proc_CreateNhanVien", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = nhanvien.HoVaTen;
            sql_cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanvien.NgaySinh;
            sql_cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
            sql_cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = nhanvien.SoDienThoai;
            sql_cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanvien.GioiTinh;
            sql_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
            sql_cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = nhanvien.Luong;
            sql_cmd.Parameters.Add("@CaLamViec", SqlDbType.NVarChar).Value = nhanvien.CaLamViec;
            sql_cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = nhanvien.ViTri;
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nhanvien.TenNguoiDung;
            sql_cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar, 25).Value = nhanvien.MaChiNhanh;
            sql_cmd.Parameters.Add("@MaChiNhanhQuanLy", SqlDbType.VarChar, 25).Value = nhanvien.MaChiNhanhQuanLy == "" ? (object)DBNull.Value : nhanvien.MaChiNhanhQuanLy;
            conn.Open();
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateNhanVien(NhanVien nhanvien)
        {
            SqlCommand sql_cmd = new SqlCommand("proc_UpdateNhanVien", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
            sql_cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = nhanvien.HoVaTen;
            sql_cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanvien.NgaySinh;
            sql_cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
            sql_cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = nhanvien.SoDienThoai;
            sql_cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanvien.GioiTinh;
            sql_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
            sql_cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = nhanvien.Luong;
            sql_cmd.Parameters.Add("@CaLamViec", SqlDbType.NVarChar).Value = nhanvien.CaLamViec;
            sql_cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = nhanvien.ViTri;
            sql_cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nhanvien.TenNguoiDung;
            sql_cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar, 25).Value = nhanvien.MaChiNhanh;
            sql_cmd.Parameters.Add("@MaChiNhanhQuanLy", SqlDbType.VarChar, 25).Value = nhanvien.MaChiNhanhQuanLy == "" ? (object)DBNull.Value: nhanvien.MaChiNhanhQuanLy;
            conn.Open();
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteNhanVien(NhanVien nhanvien)
        {
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("proc_DeleteNhanVien", conn);
            sql_cmd.CommandType = CommandType.StoredProcedure;
            sql_cmd.Parameters.AddWithValue("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
            sql_cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
