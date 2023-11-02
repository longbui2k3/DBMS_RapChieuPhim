using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            editTaiKhoan();
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
            TaiKhoanDao taiKhoanDAO = new TaiKhoanDao();
            dtgvAccount.DataSource = taiKhoanDAO.LayDanhSachTaiKhoan();
        }

        void deleteTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, "", txtVaiTro.Text);
            taiKhoanDAO.deleteTaiKhoan(taiKhoan);
            emptyTextBox();
            LoadTaiKhoanList();
        }

        void createTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, "", txtVaiTro.Text);
            taiKhoanDAO.createTaiKhoan(taiKhoan);
            emptyTextBox();
            LoadTaiKhoanList();
        }

        void editTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, "", txtVaiTro.Text);
            taiKhoanDAO.updateTaiKhoan(taiKhoan);
            emptyTextBox();
            LoadTaiKhoanList();
        }

        
        void emptyTextBox()
        {
            txtUsername.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtVaiTro.Text = "";
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
            txtVaiTro.Text=dtgvAccount.Rows[i].Cells[1].Value.ToString();
            txtMaNV.Text = dtgvAccount.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text = dtgvAccount.Rows[i].Cells[3].Value.ToString();
        }
    }
}
