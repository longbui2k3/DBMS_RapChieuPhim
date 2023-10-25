using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UC
{
    public partial class ThongTinRapUC : UserControl
    {
        public ThongTinRapUC()
        {
            InitializeComponent();
        }
        private Button currButton;
        private PhimUC puc = new PhimUC();
        private KhachHangUC khuc = new KhachHangUC();
        private void ClickToChangeColor(Button btn)
        {
            if (btn.ForeColor == Color.White)
                btn.ForeColor = Color.OrangeRed;
            else btn.ForeColor = Color.White;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.OrangeRed;
            else btn.BackColor = Color.White;
        }
        private void btn_Phim_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_Phim;
            ClickToChangeColor(btn_Phim);

            if (!panel_Main.Controls.Contains(puc))
            {
                panel_Main.Controls.Clear();
                puc.Dock = DockStyle.Fill;
                panel_Main.Controls.Add(puc);
            }

        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_KhachHang;
            ClickToChangeColor(btn_KhachHang);

            if (!panel_Main.Controls.Contains(khuc))
            {
                panel_Main.Controls.Clear();
                khuc.Dock = DockStyle.Fill;
                panel_Main.Controls.Add(khuc);
            }
        }
    }
}
