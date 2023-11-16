using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Forms;
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
    public partial class ThongTinCaNhanUC : UserControl
    {
        NhanVienDAO nvd = new NhanVienDAO();
        public ThongTinCaNhanUC()
        {
            InitializeComponent();
        }

        private void ThongTinCaNhanUC_Load(object sender, EventArgs e)
        {
            var reader = nvd.ThongTinCaNhan(FormDangNhap.txtUsernameCopy.Text);
            if (reader.Read())
            {
                txtMaNhanVien.Text = reader["MaNhanVien"].ToString().Trim();
                txtHoTen.Text = reader["HoVaTen"].ToString().Trim();
                dtBirth.Text = reader["NgaySinh"].ToString().Trim();
                txtEmail.Text = reader["Email"].ToString().Trim();
                txtSdt.Text = reader["SoDienThoai"].ToString().Trim();
                txtGioiTinh.Text = reader["GioiTinh"].ToString().Trim();
                txtDiaChi.Text = reader["DiaChi"].ToString().Trim();
                txtLuong.Text = reader["Luong"].ToString().Trim();
                txtCaLamViec.Text = reader["CaLamViec"].ToString().Trim();
                txtViTri.Text = reader["ViTri"].ToString().Trim();
                txtTenNguoiDung.Text = reader["TenNguoiDung"].ToString().Trim();
                txtMaChiNhanh.Text = reader["MaChiNhanh"].ToString().Trim();
                txtMaChiNhanhQL.Text = reader["MaChiNhanhQuanLy"].ToString().Trim();
            }
            nvd.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResetPwd formReset = new FormResetPwd();
            formReset.Show();
        }

        private void txtTenNguoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
