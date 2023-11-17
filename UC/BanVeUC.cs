using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Forms;
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
    public partial class BanVeUC : UserControl
    {
        NhanVienDAO nvd = new NhanVienDAO();
        SqlConnection conn = new DBConnection().conn;
        PhimDAO phimDAO = new PhimDAO();
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        BanVeDAO bvDao = new BanVeDAO();
        List<String> maPhimList = new List<String>();
        String currMaPhim = "All";
        public static String maKH = "";
        public static String maNV = "";
        String maKHtt = "";
        String tenKH = "";
        private int tuoi;
        DateTime birthday;
        public DateTime date;
        public TimeSpan giobatdau;
        private int check = 0;
        public static String malc;
        public static String maPC;

        public BanVeUC()
        {
            InitializeComponent();
        }

        private void cboSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboSelectMovie.Items.IndexOf(cboSelectMovie.SelectedItem);
            Console.WriteLine(maPhimList.Count);
            if (ind < 0)
                return;
            if (maPhimList.Count == 0)
                return;
            currMaPhim = maPhimList[ind];
            this.dgv_LichChieu.DataSource = phimDAO.DanhSachLichPhim(currMaPhim,lbl_ChiNhanh.Text);
        }

        private void BanVeUC_Load(object sender, EventArgs e)
        {
            cboSelectMovie.Text = "----All----";
            maPhimList.Add("All");
            DataTable dt = phimDAO.DanhSachPhim();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSelectMovie.Items.Add(dt.Rows[i]["TenPhim"]);
                maPhimList.Add((String)dt.Rows[i]["MaPhim"]);
            }
            var reader = nvd.ThongTinCaNhan(FormDangNhap.txtUsernameCopy.Text);
            if (reader.Read())
            {
                lbl_nhanvien.Text = reader["HoVaTen"].ToString().Trim();
                maNV = reader["MaNhanVien"].ToString().Trim();
                lbl_ChiNhanh.Text = reader["MaChiNhanh"].ToString().Trim();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.dgv_KhachHang.DataSource = khachHangDAO.TimKiemKhachHang(txt_ten.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maKH = maKHtt;
            if(maKH!="")
            {
                MessageBox.Show("Lấy thông tin khách hàng thành công");
                lbl_khachhang.Text = tenKH;
                TimeSpan timeDifference = DateTime.Now - birthday;
                tuoi = (int)(timeDifference.TotalDays / 365.2425);
                lbl_tuoi.Text = tuoi.ToString();
            }
            else
            {
                MessageBox.Show("Lấy thông tin khách hàng không thành công");
            }    
        }




        private void btn_chonphim_Click(object sender, EventArgs e)
        {
            if (maKH == "")
            {
                MessageBox.Show("Chưa lấy thông tin khách hàng");
            }
            else if (tuoi < check)
            {
                MessageBox.Show("Không đủ tuổi quy định");
            }
            else if (malc == null)
            {
                MessageBox.Show("chưa chọn lịch chiếu");
            }
            else
            {
                bvDao.updateGhe(malc);
                bvDao.updateGiaVe(date, giobatdau);;
                FormBanVe nvForm = new FormBanVe();
                nvForm.Show();
            } 
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectMovie_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                maKHtt = row.Cells[0].Value.ToString();
                tenKH = row.Cells[1].Value.ToString();
                birthday = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
        }

        private void dgv_LichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LichChieu.Rows[e.RowIndex];
                malc = row.Cells[0].Value.ToString();
                check = int.Parse(row.Cells[8].Value.ToString());
                maPC = row.Cells[9].Value.ToString();
                date = Convert.ToDateTime(row.Cells["NgayChieu"].Value);
                giobatdau = TimeSpan.Parse(row.Cells["GioBatDau"].Value.ToString());

            }
        }

        private void dgv_LichChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LichChieu.Rows[e.RowIndex];
                malc = row.Cells[0].Value.ToString();
                check = int.Parse(row.Cells[8].Value.ToString());
                maPC = row.Cells[9].Value.ToString();
                date = Convert.ToDateTime(row.Cells["NgayChieu"].Value);
                giobatdau = TimeSpan.Parse(row.Cells["GioBatDau"].Value.ToString());

            }
        }
    }
}
