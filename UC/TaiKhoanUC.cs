using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;

namespace QuanLyRapChieuPhim.UC
{
    public partial class TaiKhoanUC : UserControl
    {
        TaiKhoanDao taiKhoanDAO = new TaiKhoanDao();
        public TaiKhoanUC()
        {
            InitializeComponent();
        }

        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            createTaiKhoan();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            deleteTaiKhoan();
        }
        private void TaiKhoanUC_Load(object sender, EventArgs e)
        {
            LoadTaiKhoanList();
        }

        void LoadTaiKhoanList()
        {
            SqlConnection conn = new DBConnection().conn;
            TaiKhoanDao taiKhoanDAO = new TaiKhoanDao();
            SqlDataReader reader = taiKhoanDAO.LayDanhSachTaiKhoan();
            dtgvAccount.Rows.Clear();
            List<object[]> list = new List<object[]>();
            while (reader.Read())
            {
                dtgvAccount.Rows.Add(new object[] { reader[0], reader[1], reader[2], reader[3], Convert.ToBase64String((byte[])reader[4]) });
            }
            conn.Close();
            
        }

        void deleteTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, "", cb_LoaiTaiKhoan.Text);
            taiKhoanDAO.deleteTaiKhoan(taiKhoan);
            emptyTextBox();
            LoadTaiKhoanList();
        }

        void createTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, "", cb_LoaiTaiKhoan.Text);
            taiKhoanDAO.createTaiKhoan(taiKhoan, txtMaNV.Text);
            emptyTextBox();
            LoadTaiKhoanList();
        }
        
        void emptyTextBox()
        {
            txtUsername.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cb_LoaiTaiKhoan.Text = "";
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            taiKhoanDAO.searchTaiKhoan(txtSearchAccount.Text);
        }

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadTaiKhoanList();
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvAccount.CurrentRow.Index;
            txtUsername.Text = dtgvAccount.Rows[i].Cells[0].Value.ToString();
            cb_LoaiTaiKhoan.Text=dtgvAccount.Rows[i].Cells[1].Value.ToString();
            txtMaNV.Text = dtgvAccount.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text = dtgvAccount.Rows[i].Cells[3].Value.ToString();
        }
    }
}
