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
    public partial class DoAnUC : UserControl
    {
        DoAnDAO doAnDAO = new DoAnDAO();
        public DoAnUC()
        {
            InitializeComponent();
        }

        private void DoAnUC_Load(object sender, EventArgs e)
        {
            LoadDoAnList();
        }

        private void btnXemDoAn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDoAnList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadDoAnList()
        {
            dgvDoAn.DataSource = doAnDAO.layDanhSachDoAn();
        }
        void ThemDoAn()
        {
            DoAn doAn = new DoAn(txtMaDoAn.Text, txtTenDoAn.Text, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongCon.Text));
            doAnDAO.createDoAn(doAn);
            EmptyBox();
            LoadDoAnList();
        }
        void EditDoAn()
        {
            DoAn doAn = new DoAn(txtMaDoAn.Text, txtTenDoAn.Text, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongCon.Text));
            doAnDAO.updateDoAn(doAn);
            EmptyBox();
            LoadDoAnList();
        }
        void DeleteDoAn()
        {
            DoAn doAn = new DoAn(txtMaDoAn.Text, txtTenDoAn.Text, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongCon.Text));
            doAnDAO.deleteDoAn(doAn);
            LoadDoAnList();
        }
        void EmptyBox()
        {
            txtMaDoAn.Text = "";
            txtTenDoAn.Text = "";
            txtDonGia.Text = "";
            txtSoLuongCon.Text = "";
            txtSearchDoAn.Text = "";
        }

        private void btnThemDoAn_Click(object sender, EventArgs e)
        {
            ThemDoAn();
        }

        private void btnSuaDoAn_Click(object sender, EventArgs e)
        {
            EditDoAn();
        }

        private void btnXoaDoAn_Click(object sender, EventArgs e)
        {
            DeleteDoAn();
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDoAn.CurrentRow.Index;
            txtMaDoAn.Text = dgvDoAn.Rows[i].Cells[0].Value.ToString();
            txtTenDoAn.Text = dgvDoAn.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dgvDoAn.Rows[i].Cells[2].Value.ToString();
            txtSoLuongCon.Text = dgvDoAn.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSearchDoAn_Click(object sender, EventArgs e)
        {
            dgvDoAn.DataSource = doAnDAO.searchDoAn(txtSearchDoAn.Text);
        }
    }
}
