using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.Models;

namespace QuanLyRapChieuPhim.DAO
{
    internal class GiaVeDAO
    {
        private DBConnection dao = new DBConnection();

        public DataTable LayDanhSachGiaVe(SqlCommand cmd)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dao.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
            return dataTable;
        }

        public DataTable DanhSachGiaVe()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM view_GiaVe", dao.conn);
            return LayDanhSachGiaVe(cmd);
        }

        public void CreateGiaVe(GiaVe giaVe)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_InsertGiaVe", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGiaVe", SqlDbType.NVarChar, 25).Value = giaVe.MaGiaVe;
            cmd.Parameters.Add("@LoaiVe", SqlDbType.NVarChar, 255).Value = giaVe.LoaiVe;
            cmd.Parameters.Add("@GiaVe", SqlDbType.Int).Value = giaVe.Gia;
            cmd.ExecuteNonQuery();
            dao.conn.Close();
        }

        public void UpdateGiaVe(GiaVe giaVe)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_UpdateGiaVe", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaGiaVe", SqlDbType.NVarChar, 25).Value = giaVe.MaGiaVe;
            cmd.Parameters.Add("@LoaiVe", SqlDbType.NVarChar, 255).Value = giaVe.LoaiVe;
            cmd.Parameters.Add("@GiaVe", SqlDbType.Int).Value = giaVe.Gia;
            cmd.ExecuteNonQuery();
            dao.conn.Close();
        }

        public void DeleteGiaVe(GiaVe giaVe)
        {
            dao.conn.Open();
            SqlCommand cmd = new SqlCommand("proc_DeleteGiaVe", dao.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaGiaVe", SqlDbType.VarChar).Value = giaVe.MaGiaVe;
            cmd.ExecuteNonQuery();
            dao.conn.Close();
        }

        public void ThucThi(string sqlStr)
        {
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
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
