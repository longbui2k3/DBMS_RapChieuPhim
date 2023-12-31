﻿using QuanLyRapChieuPhim.Models;
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
        public SqlConnection conn = new DBConnection().conn;

        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from v_HienThiNhanVien", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Split('\n')[0]);
            }
            finally { conn.Close(); }
            return dt;
        }
        public void createNhanVien(NhanVien nhanvien)
        {
            try
            {
                conn.Open();
                SqlCommand sql_cmd = new SqlCommand("proc_InsertNhanVien", conn);
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

                sql_cmd.ExecuteNonQuery();
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.Split('\n')[0]);
            } finally
            {
                conn.Close();
            }
        }
        public void updateNhanVien(NhanVien nhanvien)
        {
            try
            {
                conn.Open();
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
                sql_cmd.Parameters.Add("@MaChiNhanhQuanLy", SqlDbType.VarChar, 25).Value = nhanvien.MaChiNhanhQuanLy == "" ? (object)DBNull.Value : nhanvien.MaChiNhanhQuanLy;

                sql_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Split('\n')[0]);
            }
            finally
            {
                conn.Close();
            }
        }
        public SqlDataReader ThongTinCaNhan(string username)
        {
            try
            {
                conn.Open();
                SqlCommand sql_cmd = new SqlCommand("SELECT * FROM func_ThongTinCaNhan(@username)", conn);
                sql_cmd.Parameters.AddWithValue("@username", username);
                var reader = sql_cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void deleteNhanVien(NhanVien nhanvien)
        {
            try
            {
                conn.Open();
                SqlCommand sql_cmd = new SqlCommand("proc_DeleteNhanVien", conn);
                sql_cmd.CommandType = CommandType.StoredProcedure;
                sql_cmd.Parameters.AddWithValue("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
                sql_cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }
        public DataTable searchNhanVien(String search)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM f_SearchNhanVien(@searchStr)", conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
