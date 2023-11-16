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

namespace QuanLyRapChieuPhim.Forms
{
    public partial class FormResetPwd : Form
    {
        TaiKhoanDao tkDao = new TaiKhoanDao();
        public FormResetPwd()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                tkDao.resetMatKhau(FormDangNhap.txtUsernameCopy.Text, txt_MatKhauCu.Text.Trim(), txt_MatKhauMoi.Text.Trim());
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
