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
using QuanLyRapChieuPhim.Forms;

namespace QuanLyRapChieuPhim.UC
{
    public partial class DoanhThuUC : UserControl
    {
        private PhimDAO pdDao = new PhimDAO();
        String currMaPhim = "All";
        public DoanhThuUC()
        {
            InitializeComponent();
            
        }

        private void lblSelectMovie_Click(object sender, EventArgs e)
        {

        }
        List<String> maPhimList = new List<String>();
        private void DoanhThuUC_Load(object sender, EventArgs e)
        {
            cboSelectMovie.Text = "----All----";
            maPhimList.Add("All");
            DataTable dt = pdDao.DanhSachPhim();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSelectMovie.Items.Add(dt.Rows[i]["TenPhim"]);
                maPhimList.Add((String)dt.Rows[i]["MaPhim"]);
            }
        }
        void TaiDoanhThu()
        {
            DataTable doanhThuPhim = pdDao.DoanhThuPhim(currMaPhim, dtmFromDate.Value, dtmToDate.Value);
            dtgvRevenue.DataSource = doanhThuPhim;
            txtDoanhThu.Text = pdDao.TongDoanhThu(currMaPhim, dtmFromDate.Value, dtmToDate.Value).ToString();
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
           

        }

        private void dtmFromDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtmToDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnReportRevenue_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport(currMaPhim, dtmFromDate.Value, dtmToDate.Value);
            formReport.Show();
        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            TaiDoanhThu();
        }
    }
}
