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
using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Forms;
using QuanLyRapChieuPhim.UC;

namespace QuanLyRapChieuPhim
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private DBConnection dao = new DBConnection();
        private Button currButton;
        private ThongTinCaNhanUC ttcnUC = new ThongTinCaNhanUC();
        private BanVeUC bvUC = new BanVeUC();
        private void ClickToChangeColor(Button btn)
        {
            if (btn.ForeColor == Color.White)
                btn.ForeColor = Color.OrangeRed;
            else btn.ForeColor = Color.White;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.OrangeRed;
            else btn.BackColor = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_ThongTinCaNhan;
            ClickToChangeColor(btn_ThongTinCaNhan); 

            FormDangNhap formDN = new FormDangNhap();
            formDN.Show();
            this.Hide();
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_ThongTinCaNhan;
            ClickToChangeColor(btn_ThongTinCaNhan);

            if (!splitContainer1.Panel2.Controls.Contains(ttcnUC))
            {
                splitContainer1.Panel2.Controls.Clear();
                ttcnUC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(ttcnUC);
            }
        }

        private void btn_BanVe_Click(object sender, EventArgs e)
        {
            if (currButton != null)
                ClickToChangeColor(currButton);
            currButton = btn_BanVe;
            ClickToChangeColor(btn_BanVe);

            if (!splitContainer1.Panel2.Controls.Contains(bvUC))
            {
                splitContainer1.Panel2.Controls.Clear();
                bvUC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(bvUC);
            }
        }
    }
}
