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
        public DataTable DanhSachGiaVe()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dao.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM view_GiaVe", dao.conn);
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

        public DataTable searchGiaVe(String search)
        {
            DataTable dt = new DataTable();
            dao.conn.Open();
            SqlCommand sql_cmd = new SqlCommand("SELECT * FROM func_SearchGiaVe(@searchStr)", dao.conn);
            sql_cmd.Parameters.AddWithValue("@searchStr", search);
            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);
            adapter.Fill(dt);
            dao.conn.Close();
            return dt;
        }
    }
}
