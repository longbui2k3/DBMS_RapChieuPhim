using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyRapChieuPhim.UC
{
    public partial class GiaVeUC : UserControl
    {

        DataTable dt = new DataTable();
        GiaVeDAO giaveDAO = new GiaVeDAO();
        public GiaVeUC()
        {
            InitializeComponent();
        }

        private void lblCusID_Click(object sender, EventArgs e)
        {

        }

        private void lblCusBirth_Click(object sender, EventArgs e)
        {

        }

        private void GiaVeUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGiaVe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grpCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCusID_Click_1(object sender, EventArgs e)
        {

        }

        private void clbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCusBirth_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvGiaVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaVe.Rows[e.RowIndex];
                txt_MaGiaVe.Text = row.Cells[0].Value.ToString();
                txt_LoaiVe.Text = row.Cells[1].Value.ToString();
                txt_GiaVe.Text = row.Cells[3].Value.ToString();
            }
        }
        void LoadGiaVe()
        {
            GiaVeDAO giaveDAO = new GiaVeDAO();
            dgvGiaVe.DataSource = giaveDAO.DanhSachGiaVe();
        }
        void emptyTextBox()
        {
            txt_GiaVe.Text = "";
            txt_MaGiaVe.Text = "";
            txt_LoaiVe.Text = "";
            txt_Search.Text = "";
        }
        void ThemGiave()
        {
            GiaVe giave = new GiaVe(txt_MaGiaVe.Text,
                txt_LoaiVe.Text,
                int.Parse(txt_GiaVe.Text)
                );
            giaveDAO.CreateGiaVe(giave);
            emptyTextBox();
            LoadGiaVe();
        }
        void XoaGiave()
        {
            GiaVe giave = new GiaVe(txt_MaGiaVe.Text,
                txt_LoaiVe.Text,
                int.Parse(txt_GiaVe.Text)
                );
            giaveDAO.DeleteGiaVe(giave);
            emptyTextBox();
            LoadGiaVe();
        }
        void SuaGiave()
        {
            GiaVe giave = new GiaVe(txt_MaGiaVe.Text,
                txt_LoaiVe.Text,
                int.Parse(txt_GiaVe.Text)
                );
            giaveDAO.UpdateGiaVe(giave);
            emptyTextBox();
            LoadGiaVe();
        }



        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            try 
            { 
                LoadGiaVe(); 
            } 
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ThemGiave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                XoaGiave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SuaGiave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            dgvGiaVe.DataSource = giaveDAO.searchGiaVe(txt_Search.Text);
        }
    }
}
