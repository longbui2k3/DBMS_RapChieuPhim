﻿using QuanLyRapChieuPhim.Models;
using QuanLyRapChieuPhim.UC;
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
    internal class DoAnDAO
    {
        SqlConnection conn = new DBConnection().conn;
        public DataTable layDanhSachDoAn()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select *from v_HienThiDoAn", conn);
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
        public void createDoAn(DoAn doAn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_InsertDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenDoAn", SqlDbType.NVarChar).Value = doAn.TenDoAn;
                cmd.Parameters.Add("@Dongia", SqlDbType.Int).Value = doAn.DonGia;
                cmd.Parameters.Add("@SoLuongCon", SqlDbType.Int).Value = doAn.SoLuongCon;

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void updateDoAn(DoAn doAn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_UpdateDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDoAn", SqlDbType.VarChar).Value = doAn.MaDoAn;
                cmd.Parameters.Add("@TenDoAn", SqlDbType.NVarChar).Value = doAn.TenDoAn;
                cmd.Parameters.Add("@SoLuongCon", SqlDbType.Int).Value = doAn.SoLuongCon;
                cmd.Parameters.Add("DonGia", SqlDbType.Int).Value = doAn.DonGia;

                cmd.ExecuteNonQuery( ); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void deleteDoAn(DoAn doAn)
        {
            try
            {
                conn.Open( );
                SqlCommand cmd = new SqlCommand("proc_DeleteDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDoAn", SqlDbType.VarChar).Value = doAn.MaDoAn;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable searchDoAn(String search)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_SearchDoAn", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@searchStr", SqlDbType.NVarChar).Value = search;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
