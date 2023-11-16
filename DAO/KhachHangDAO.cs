using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;

namespace QuanLyRapChieuPhim.DAO
{
    internal class KhachHangDAO
    {
        DBConnection dao = new DBConnection();

        public DataTable DanhSachKhachHang()
        { 
            DataTable dskh = new DataTable();
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("select * from view_KhachHang", dao.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dskh);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return dskh;
        }
        
        public DataTable TimKiemKhachHang(string searchKH)
        {
            DataTable dskh = new DataTable();
            try
            {
                dao.conn.Open(); 
                SqlCommand cmd = new SqlCommand("select * from func_SearchKhachHang(@searchKH)", dao.conn);
                cmd.Parameters.Add("@searchKH", SqlDbType.NVarChar).Value = searchKH;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dskh);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return dskh;
        }

      

        public void ThemKhachHang(KhachHang kh)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_InsertKhachHang", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = kh.HoVaTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = kh.Email;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = kh.SoDienThoai;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại \n" + ex.Message.Split('\n')[0]);
            }
            finally
            {
                dao.conn.Close();
            }
        }

        public void XoaKhachHang(KhachHang kh)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_DeleteKhachHang", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = kh.MaKhachHang;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại \n" + ex.Message.Split('\n')[0]);
            }
            finally
            {
                dao.conn.Close();
            }
        }

        public void SuaKhachHang(KhachHang kh)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateKhachHang", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = kh.MaKhachHang;
                cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar).Value = kh.HoVaTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = kh.Email;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = kh.SoDienThoai;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message.Split('\n')[0]);
            }
            finally
            {
                dao.conn.Close();
            }
        }


    }
}
