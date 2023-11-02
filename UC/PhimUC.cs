using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UC
{
    public partial class PhimUC : UserControl
    {
        string nameImage = null;
        DataTable dt = new DataTable();
        PhimDAO phimDAO = new PhimDAO();
        public PhimUC()
        {
            InitializeComponent();
        }
        private void PhimUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPhim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPhim();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadPhim()
        {
            PhimDAO phimDAO = new PhimDAO();
            dgvPhim.DataSource = phimDAO.DanhSachPhim();
        }

        private void dgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhim.CurrentRow.Index;
            txt_Maphim.Text = dgvPhim.Rows[i].Cells[0].Value.ToString();
            txt_Tenphim.Text = dgvPhim.Rows[i].Cells[1].Value.ToString();
            picFilm.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..",@"Images\" + dgvPhim.Rows[i].Cells[2].Value.ToString()));
            txt_Thoiluong.Text = dgvPhim.Rows[i].Cells[3].Value.ToString();
            dtm_Ngaykhoichieu.Value = (DateTime)dgvPhim.Rows[i].Cells[4].Value;
            txt_Daodien.Text = dgvPhim.Rows[i].Cells[5].Value.ToString();
            txt_Quocgia.Text = dgvPhim.Rows[i].Cells[6].Value.ToString();
            txt_Dienvienchinh.Text = dgvPhim.Rows[i].Cells[7].Value.ToString();
            txt_Nhasanxuat.Text = dgvPhim.Rows[i].Cells[8].Value.ToString();
            txtTomtat.Text = dgvPhim.Rows[i].Cells[9].Value.ToString();
            txt_Dotuoi.Text = dgvPhim.Rows[i].Cells[10].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemPhim();
        }

        private void btn_chonimg_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    picFilm.Image = Image.FromFile(filePathImage.ToString());
                    nameImage = filePathImage.Substring(filePathImage.LastIndexOf('\\') + 1);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        void ThemPhim()
        {
            Phim phim = new Phim(txt_Maphim.Text, 
                txt_Tenphim.Text,
                nameImage,
                int.Parse(txt_Thoiluong.Text), dtm_Ngaykhoichieu.Value,
                txt_Daodien.Text, 
                txt_Quocgia.Text, 
                txt_Dienvienchinh.Text, 
                txt_Nhasanxuat.Text, txtTomtat.Text, 
                int.Parse(txt_Dotuoi.Text),0);
            phimDAO.createPhim(phim);
            emptyTextBox();
            LoadPhim();

        }

        private void txtTomtat_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_Ngaykhoichieu(object sender, EventArgs e)
        {

        }
        void emptyTextBox()
        {
            txt_Maphim.Text = "";
            txt_Tenphim.Text = "";
            picFilm = null;
            txt_Thoiluong.Text = "";
            txt_Daodien.Text = "";
            txt_Quocgia.Text = "";
            txt_Dienvienchinh.Text = "";
            txt_Nhasanxuat.Text = "";
            txtTomtat.Text = "";
            txt_Dotuoi.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            PhimDAO phimDAO = new PhimDAO();
            dgvPhim.DataSource = phimDAO.TimKiemPhim(txt_search.Text);
        }
    }
}
