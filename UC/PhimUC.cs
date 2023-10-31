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
    public partial class PhimUC : UserControl
    {
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
                System.Text.Encoding.UTF8.GetString(PhimDAO.imageToByteArray(picFilm.Image)), 
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
    }
}
