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
    public partial class PhongChieuPhimUC : UserControl
    {
        PhongChieuPhimDao phongCPDao = new PhongChieuPhimDao();
        public PhongChieuPhimUC()
        {
            InitializeComponent();
        }
        void LoadPhongChieuPhimList()
        {
            dtgvCinema.DataSource = phongCPDao.LayDanhSachPhongChieuPhim();
        }
        void emptyTextBox()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtSoChoNgoi.Text = "";     
        }
        private void PhongChieuPhimUC_Load(object sender, EventArgs e)
        {
            LoadPhongChieuPhimList();
        }
        private void btnInsertCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.createPhongChieuPhim(phongChieuPhim);
            emptyTextBox();
            LoadPhongChieuPhimList();
        }

        private void btnDeleteCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.deletePhongChieuPhim(phongChieuPhim);
            emptyTextBox();
            LoadPhongChieuPhimList();
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.updatePhongChieuPhim(phongChieuPhim);
            emptyTextBox();
            LoadPhongChieuPhimList();
        }

        private void btnShowCinema_Click(object sender, EventArgs e)
        {
            LoadPhongChieuPhimList();
        }

        private void btnSearchPhongCP_Click(object sender, EventArgs e)
        {
            dtgvCinema.DataSource = phongCPDao.searchPhongChieuPhim(txtSearchPhongCP.Text);
        }

        private void dtgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCinema.Rows[e.RowIndex];

                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtTenPhong.Text=row.Cells[1].Value.ToString();
                txtSoChoNgoi.Text=row.Cells[2].Value.ToString();

            }
        }
    }
}
