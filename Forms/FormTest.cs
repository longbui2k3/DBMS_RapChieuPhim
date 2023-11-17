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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

            DoanhThuUC doanhThuUC = new DoanhThuUC();
            doanhThuUC.Dock = DockStyle.Fill;
            this.Controls.Add(doanhThuUC);
        }
    }
}
