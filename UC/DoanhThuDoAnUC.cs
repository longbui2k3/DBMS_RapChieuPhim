using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.DAO;

namespace QuanLyRapChieuPhim.UC
{
    public partial class DoanhThuDoAnUC : UserControl
    {
        public DoanhThuDoAnUC()
        {
            InitializeComponent();
        }
        DoAnDAO dad = new DoAnDAO();
        void TaiDoanhThu()
        {
            DataTable doanhThu = dad.DoanhThuDoAn(dtmFromDate.Value, dtmToDate.Value);
            dtgvRevenue.DataSource = doanhThu;
            txtDoanhThu.Text = dad.TongDoanhThuDoAn(dtmFromDate.Value, dtmToDate.Value).ToString();
        }
        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            TaiDoanhThu();
        }
    }
}
