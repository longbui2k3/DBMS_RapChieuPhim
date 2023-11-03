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
    public partial class ChiNhanhUC : UserControl
    {
        ChiNhanhDAO cndao = new ChiNhanhDAO();
        public ChiNhanhUC()
        {
            InitializeComponent();
        }

        private void ChiNhanhUC_Load(object sender, EventArgs e)
        {
            HienThiDS();
        }
        private void HienThiDS()
        {
            this.data_ChiNhanh.DataSource = cndao.DanhSachChiNhanh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ChiNhanh cn = new ChiNhanh(txt_MaChiNhanh.Text, txt_TenChiNhanh.Text, txt_TinhTP.Text, txt_DiaChi.Text);
            cndao.ThemChiNhanh(cn);
            HienThiDS();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ChiNhanh cn = new ChiNhanh(txt_MaChiNhanh.Text, txt_TenChiNhanh.Text, txt_TinhTP.Text, txt_DiaChi.Text);
            cndao.XoaChiNhanh(cn);
            HienThiDS();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ChiNhanh cn = new ChiNhanh(txt_MaChiNhanh.Text, txt_TenChiNhanh.Text, txt_TinhTP.Text, txt_DiaChi.Text);
            cndao.SuaChiNhanh(cn);
            HienThiDS();
        }

        private void data_ChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_ChiNhanh.Rows[e.RowIndex];

                txt_MaChiNhanh.Text = row.Cells[0].Value.ToString();
                txt_TenChiNhanh.Text = row.Cells[1].Value.ToString();
                txt_TinhTP.Text = row.Cells[2].Value.ToString();
                txt_DiaChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            this.data_ChiNhanh.DataSource = cndao.TimKiemChiNhanh(txt_Search.Text);
        }
    }
}
