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
        void LoadNhanVienList()
        {
            dtgvCinema.DataSource = phongCPDao.LayDanhSachPhongChieuPhim();
        }
        void emptyTextBox()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTinhTrang.Text = "";
            txtSoChoNgoi.Text = "";     
        }
        private void PhongChieuPhimUC_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }
        private void btnInsertCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.createPhongChieuPhim(phongChieuPhim);
            emptyTextBox();
        }

        private void btnDeleteCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.deletePhongChieuPhim(phongChieuPhim);
            emptyTextBox();
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            PhongChieuPhim phongChieuPhim = new PhongChieuPhim(txtMaPhong.Text, txtTenPhong.Text, Int32.Parse(txtSoChoNgoi.Text == "" ? "0" : txtSoChoNgoi.Text));
            phongCPDao.updatePhongChieuPhim(phongChieuPhim);
            emptyTextBox();
        }

        private void btnShowCinema_Click(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }

        private void btnSearchPhongCP_Click(object sender, EventArgs e)
        {
            phongCPDao.searchPhongChieuPhim(txtSearchPhongCP.Text);
        }
    }
}
