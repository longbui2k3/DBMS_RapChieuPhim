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
        //String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QLRapPhim;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QLRapPhim;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select *from NhanVien", conn);
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
        public void xuLi(NhanVien nhanvien, string action)
        {
            switch (action)
            {
                case "Add":
                    string sqlAddNhanVien = string.Format("INSERT INTO NhanVien(" +
                        "MaNhanVien, HoVaTen, NgaySinh, Email, SoDienThoai, GioiTinh, DiaChi, Luong, CaLamViec, ViTri, TenNguoiDung, MaChiNhanh, MaChiNhanhQuanLy) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                        nhanvien.getMaNhanVien, nhanvien.getHoVaTen, nhanvien.getNgaySinh, nhanvien.getEmail, nhanvien.getSoDienThoai,
                        nhanvien.getGioiTinh, nhanvien.getDiaChi, nhanvien.getLuong, nhanvien.getCaLamViec, nhanvien.getViTri, nhanvien.getTenNguoiDung,
                        nhanvien.getMaChiNhanh, nhanvien.getMaChiNhanhQuanLy);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sqlAddNhanVien, conn);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thanh cong. Bam ok de tiep tuc!");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }

                    break;
                case "Delete":
                    if (MessageBox.Show("Ban co muon xoa nhan vien nay khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sqlDeleteNhanVien = string.Format("delete from NhanVien where MaNhanVien = '{0}'", nhanvien.getMaNhanVien);

                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sqlDeleteNhanVien, conn);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Thanh cong. Bam ok de tiep tuc!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally { conn.Close(); }

                    }

                    break;
                case "Edit":
                    string sqlEditNhanVien = string.Format("Update NhanVien set HoVaTen = '{0}', NgaySinh = '{1}'," +
                        "Email = '{2}', SoDienThoai = '{3}', GioiTinh = '{4}', DiaChi = '{5}'," +
                        "Luong = '{6}', CaLamViec = '{7}', ViTri = '{8}', TenNguoiDung = '{9}'," +
                        "MaChiNhanh = '{10}',MaChiNhanhQuanLy = '{11}' where MaNhanVien = '{12}'",
                        nhanvien.getHoVaTen, nhanvien.getNgaySinh, nhanvien.getEmail, nhanvien.getSoDienThoai,
                        nhanvien.getGioiTinh, nhanvien.getDiaChi, nhanvien.getLuong, nhanvien.getCaLamViec, nhanvien.getViTri, nhanvien.getTenNguoiDung,
                        nhanvien.getMaChiNhanh, nhanvien.getMaChiNhanhQuanLy, nhanvien.getMaNhanVien);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sqlEditNhanVien, conn);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thanh cong. Bam ok de tiep tuc!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                    break;

            }
        }
    }
}
