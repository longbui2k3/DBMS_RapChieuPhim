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
    public partial class KhachHangUC : UserControl
    {
        KhachHangDAO khdao = new KhachHangDAO();
        public KhachHangUC()
        {
            InitializeComponent();
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {
            HienThiDS();
        }

        private void HienThiDS()
        {
            this.data_KhachHang.DataSource = khdao.DanhSachKhachHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(txt_MaKhachHang.Text, txt_HoVaTen.Text, date_NgaySinh.Value, txt_Email.Text, txt_SoDienThoai.Text, cb_GioiTinh.Text, txt_DiaChi.Text);
            khdao.ThemKhachHang(kh);
            HienThiDS();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(txt_MaKhachHang.Text, txt_HoVaTen.Text, date_NgaySinh.Value, txt_Email.Text, txt_SoDienThoai.Text, cb_GioiTinh.Text, txt_DiaChi.Text);
            khdao.XoaKhachHang(kh);
            HienThiDS();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(txt_MaKhachHang.Text, txt_HoVaTen.Text, date_NgaySinh.Value, txt_Email.Text, txt_SoDienThoai.Text, cb_GioiTinh.Text, txt_DiaChi.Text);
            khdao.SuaKhachHang(kh);
            HienThiDS();
        }

        private void data_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_KhachHang.Rows[e.RowIndex];

                txt_MaKhachHang.Text = row.Cells[0].Value.ToString();
                txt_HoVaTen.Text = row.Cells[1].Value.ToString();
                date_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txt_Email.Text = row.Cells[3].Value.ToString();
                txt_SoDienThoai.Text = row.Cells[4].Value.ToString();
                cb_GioiTinh.Text = row.Cells[5].Value.ToString();
                txt_DiaChi.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            this.data_KhachHang.DataSource = khdao.TimKiemKhachHang(txt_Search.Text);
        }
    }
}
