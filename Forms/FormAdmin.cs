using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.UC;

namespace QuanLyRapChieuPhim.Forms
{
    public partial class FormAdmin : Form
    {
        
        public FormAdmin()
        {
            InitializeComponent();
        }
        private Button currButton;
        private ThongTinRapUC ttruc = new ThongTinRapUC();
        private NhanVienUC nvuc = new NhanVienUC();
        private ChiNhanhUC cnuc = new ChiNhanhUC();
        private TaiKhoanUC tkuc = new TaiKhoanUC();
        private void ClickToChangeColor(Button btn)
        {
            if (btn.ForeColor == Color.White)
                btn.ForeColor = Color.OrangeRed;
            else btn.ForeColor = Color.White;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.OrangeRed;
            else btn.BackColor = Color.White;
        }
        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_DoanhThu;
            ClickToChangeColor(btn_DoanhThu);
        }

        private void btn_ThongTinRap_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_ThongTinRap;
            ClickToChangeColor(btn_ThongTinRap);

            if (!splitContainer1.Panel2.Controls.Contains(ttruc))
            {
                splitContainer1.Panel2.Controls.Clear();
                ttruc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(ttruc);
            }


        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_NhanVien;
            ClickToChangeColor(btn_NhanVien);

            if (!splitContainer1.Panel2.Controls.Contains(nvuc))
            {
                splitContainer1.Panel2.Controls.Clear();
                nvuc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(nvuc);
            }
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_TaiKhoan;
            ClickToChangeColor(btn_TaiKhoan);

            if (!splitContainer1.Panel2.Controls.Contains(tkuc))
            {
                splitContainer1.Panel2.Controls.Clear();
                tkuc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(tkuc);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_DangXuat;
            ClickToChangeColor(btn_DangXuat);
        }

        private void btn_ChiNhanh_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_ChiNhanh;
            ClickToChangeColor(btn_ChiNhanh);

            if (!splitContainer1.Panel2.Controls.Contains(cnuc))
            {
                splitContainer1.Panel2.Controls.Clear();
                cnuc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(cnuc);
            }
        }
    }
}
