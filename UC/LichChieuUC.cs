using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UC
{
    public partial class LichChieuUC : UserControl
    {
        LichChieuDAO lichChieuDAO = new LichChieuDAO();
        public LichChieuUC()
        {
            InitializeComponent();
        }

        void emptyTextBox()
        {
            txtMaChiNhanh.Text = "";
            txtMaLichChieu.Text = "";
            txtMaPhim.Text = "";
            txtMaPhong.Text = "";
            txtSoGheConLai.Text = "";
            txtSearch.Text = "";
        }

        void LoadLichChieu()
        {
            dgvLichChieu.DataSource = lichChieuDAO.LayDanhSachLichChieuPhim();
        }

        void DeleteLichChieu()
        {
            TimeSpan gioBatDau = dtmGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtmGioKetThuc.Value.TimeOfDay;
            LichChieuPhim lichChieuPhim = new LichChieuPhim(txtMaLichChieu.Text, DateTime.Parse(dtmNgayChieu.Text),
                gioBatDau, gioKetThuc, int.Parse(txtSoGheConLai.Text), txtMaPhong.Text, 
                txtMaPhim.Text, txtMaChiNhanh.Text); 
            lichChieuDAO.deleteLichChieu(lichChieuPhim);
            emptyTextBox();
            LoadLichChieu();
        }

        void ThemLichChieu()
        {
            TimeSpan gioBatDau = dtmGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtmGioKetThuc.Value.TimeOfDay;
            LichChieuPhim lichChieuPhim = new LichChieuPhim(txtMaLichChieu.Text, DateTime.Parse(dtmNgayChieu.Text),
               gioBatDau, gioKetThuc, int.Parse(txtSoGheConLai.Text), txtMaPhong.Text,
               txtMaPhim.Text, txtMaChiNhanh.Text);
            lichChieuDAO.createLichChieu(lichChieuPhim);
            emptyTextBox();
            LoadLichChieu();
        }

        void editLichChieu()
        {
            TimeSpan gioBatDau = dtmGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtmGioKetThuc.Value.TimeOfDay;
            LichChieuPhim lichChieuPhim = new LichChieuPhim(txtMaLichChieu.Text, DateTime.Parse(dtmNgayChieu.Text),
              gioBatDau, gioKetThuc, int.Parse(txtSoGheConLai.Text), txtMaPhong.Text,
              txtMaPhim.Text, txtMaChiNhanh.Text);
            lichChieuDAO.updateLichChieu(lichChieuPhim);
            emptyTextBox();
            LoadLichChieu();
        }

        private void LichChieuUC_Load_1(object sender, EventArgs e)
        {
            try
            {
                LoadLichChieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLichChieu.CurrentRow.Index;
            txtMaLichChieu.Text = dgvLichChieu.Rows[i].Cells[0].Value.ToString();
            dtmNgayChieu.Text = dgvLichChieu.Rows[i].Cells[1].Value.ToString();
            dtmGioBatDau.Text = dgvLichChieu.Rows[i].Cells[2].Value.ToString();
            dtmGioKetThuc.Text = dgvLichChieu.Rows[i].Cells[3].Value.ToString();
            txtSoGheConLai.Text = dgvLichChieu.Rows[i].Cells[4].Value.ToString();
            txtMaPhong.Text = dgvLichChieu.Rows[i].Cells[5].Value.ToString();
            txtMaPhim.Text = dgvLichChieu.Rows[i].Cells[6].Value.ToString();
            txtMaChiNhanh.Text = dgvLichChieu.Rows[i].Cells[7].Value.ToString();


        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DeleteLichChieu();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThemLichChieu();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            editLichChieu();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            LoadLichChieu();
        }

        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            dgvLichChieu.DataSource = lichChieuDAO.searchLichChieu(txtSearch.Text);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
