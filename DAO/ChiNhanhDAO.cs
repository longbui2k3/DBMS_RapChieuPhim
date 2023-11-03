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
    internal class ChiNhanhDAO
    {
        DBConnection dao = new DBConnection();

        public DataTable LayDS(SqlCommand cmd)
        {
            DataTable dskh = new DataTable();
            try
            {
                dao.conn.Open();
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

        public DataTable DanhSachChiNhanh()
        {
            SqlCommand cmd = new SqlCommand("select * from view_ChiNhanh", dao.conn);
            return LayDS(cmd);
        }

        public DataTable TimKiemChiNhanh(string searchCN)
        {
            SqlCommand cmd = new SqlCommand("select * from func_SearchChiNhanh(@searchCN)", dao.conn);
            cmd.Parameters.Add("@searchCN", SqlDbType.NVarChar).Value = searchCN;
            return LayDS(cmd);
        }


        public void ThemChiNhanh(ChiNhanh cn)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_InsertChiNhanh", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenChiNhanh", SqlDbType.NVarChar).Value = cn.TenChiNhanh;
                cmd.Parameters.Add("@TinhTP", SqlDbType.NVarChar).Value = cn.TinhTP;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = cn.DiaChi;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }

        public void XoaChiNhanh(ChiNhanh cn)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_DeleteChiNhanh", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = cn.MaChiNhanh;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }

        public void SuaChiNhanh(ChiNhanh cn)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateChiNhanh", dao.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChiNhanh", SqlDbType.VarChar).Value = cn.MaChiNhanh;
                cmd.Parameters.Add("@TenChiNhanh", SqlDbType.NVarChar).Value = cn.TenChiNhanh;
                cmd.Parameters.Add("@TinhTP", SqlDbType.NVarChar).Value = cn.TinhTP;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = cn.DiaChi;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }

    }
}
