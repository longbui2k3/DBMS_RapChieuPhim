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
using Microsoft.Reporting.WinForms;
using QuanLyRapChieuPhim.DAO;

namespace QuanLyRapChieuPhim.Forms
{
    public partial class FormReport : Form
    {
        private String maPhim;
        private DateTime tuNgay;
        private DateTime denNgay;
        private DBConnection dao = new DBConnection();
        public FormReport(String maPhim, DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.maPhim = maPhim;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
        }
       
        private void FormReport_Load(object sender, EventArgs e)
        {
            this.rpViewer.RefreshReport();
            TaiDoanhThu(maPhim, tuNgay, denNgay);
            this.rpViewer.RefreshReport();
        }
        private void TaiDoanhThu(String maPhim, DateTime tuNgay, DateTime denNgay)
        {
            dao.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("proc_DoanhThuPhim", dao.conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@MaPhim", SqlDbType.VarChar).Value = maPhim;
            adapter.SelectCommand.Parameters.Add("@TuNgay", SqlDbType.Date).Value = tuNgay;
            adapter.SelectCommand.Parameters.Add("@DenNgay", SqlDbType.Date).Value = denNgay;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "proc_DoanhThuPhim");
            dao.conn.Close();
            this.rpViewer.LocalReport.ReportEmbeddedResource = "QuanLyRapChieuPhim.ReportDoanhThu.rdlc";
/*            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(dataSet.Tables[0].Rows[i][0]);
            }*/
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "proc_DoanhThuPhim";
            rds.Value = dataSet.Tables[0];
            this.rpViewer.LocalReport.DataSources.Add(rds);

            ReportParameter[] reportParameter = new ReportParameter[2];
            reportParameter[0] = new ReportParameter("TuNgay");
            reportParameter[0].Values.Add(tuNgay.ToShortDateString());
            reportParameter[1] = new ReportParameter("DenNgay");
            reportParameter[1].Values.Add(denNgay.ToShortDateString());

            this.rpViewer.LocalReport.SetParameters(reportParameter);


        }
    }
}
