using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UC
{
    public partial class NhanVienUC : UserControl
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        public NhanVienUC()
        {         
            InitializeComponent();        
        }

        private void btnXemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NhanVienUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadNhanVienList()
        {
            NhanVienDAO nhanVienDAO = new NhanVienDAO();     
            dgvNhanVien.DataSource = nhanVienDAO.LayDanhSachNhanVien();
        }

        void DeleteNhanVien()
        {
            NhanVien nhanVien = new NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtBirth.Value.Date,
                txtEmail.Text, txtSdt.Text, txtGioiTinh.Text, txtDiaChi.Text, int.Parse(txtLuong.Text), txtCaLamViec.Text,
                txtViTri.Text, txtTenNguoiDung.Text, txtMaChiNhanh.Text, txtMaChiNhanhQL.Text);
            /*nvDAO.xuLi(nhanVien, "Delete");*/
            nvDAO.deleteNhanVien(nhanVien);
            emptyTextBox();
            LoadNhanVienList();
        }

        void ThemNhanVien()
        {
            NhanVien nhanVien = new NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtBirth.Value.Date,
                txtEmail.Text, txtSdt.Text, txtGioiTinh.Text, txtDiaChi.Text, int.Parse(txtLuong.Text), txtCaLamViec.Text,
                txtViTri.Text, txtTenNguoiDung.Text, txtMaChiNhanh.Text, txtMaChiNhanhQL.Text == "" ? txtMaChiNhanhQL.Text: null);
            /*nvDAO.xuLi(nhanVien, "Add");*/
            nvDAO.createNhanVien(nhanVien);
            emptyTextBox();
            LoadNhanVienList();
        }

        void editNhanVien()
        {
            NhanVien nhanVien = new NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtBirth.Value.Date,
                txtEmail.Text, txtSdt.Text, txtGioiTinh.Text, txtDiaChi.Text, int.Parse(txtLuong.Text), txtCaLamViec.Text,
                txtViTri.Text, txtTenNguoiDung.Text, txtMaChiNhanh.Text.Trim(), txtMaChiNhanhQL.Text.Trim());
            /*nvDAO.xuLi(nhanVien, "Edit");*/
            nvDAO.updateNhanVien(nhanVien);
            emptyTextBox();
            LoadNhanVienList();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ThemNhanVien();
        }
        void emptyTextBox()
        {
            txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            txtCaLamViec.Text = "";
            txtViTri.Text = "";
            txtTenNguoiDung.Text = "";
            txtMaChiNhanh.Text = "";
            txtMaChiNhanhQL.Text = "";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtBirth.Value = (DateTime)dgvNhanVien.Rows[i].Cells[2].Value;
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSdt.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            txtCaLamViec.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            txtViTri.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
            txtTenNguoiDung.Text = dgvNhanVien.Rows[i].Cells[10].Value.ToString();
            txtMaChiNhanh.Text = dgvNhanVien.Rows[i].Cells[11].Value.ToString();
            txtMaChiNhanhQL.Text = dgvNhanVien.Rows[i].Cells[12].Value.ToString();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteNhanVien();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            editNhanVien();
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            NhanVienDAO nhanVienDAO = new NhanVienDAO();
            dgvNhanVien.DataSource = nhanVienDAO.searchNhanVien(txtSearchCus.Text);
        }

        private void grpCustomer_Enter(object sender, EventArgs e)
        {

        }
    }
}
