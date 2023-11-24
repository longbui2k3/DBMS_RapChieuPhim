using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.Forms
{
    public partial class FormBanVe : Form
    {
        DoAnDAO doan = new DoAnDAO();
        BanVeDAO banve = new BanVeDAO();
        NhanVienDAO nvd = new NhanVienDAO();
        GiaVeDAO giave = new GiaVeDAO();
        private String malc = BanVeUC.malc;
        private String makh = BanVeUC.maKH;
        private String mapc = BanVeUC.maPC;
        private String manv = BanVeUC.maNV;
        private int currmaghe=0;
        List<String> maGiaVeList = new List<String>(); 
        List<String> magvList = new List<String>();
        List<int> maGheList = new List<int>();
        List<String> maDoAnList = new List<String>();
        List<String> maDoAnListMua = new List<string>();
        List<int> soluonglist = new List<int>();
        List<int> giavelist = new List<int>();
        List<int> giadoanlist = new List<int>();
        List<int> tongtien = new List<int>();

        String currMaGiaVe;
        String currDoAn;
        int currgiadoan;
        private int TongTien;
        private int currGiaVe;


        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {
            DataTable dt = giave.DanhSachGiaVe();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSelectGiaVe.Items.Add(dt.Rows[i]["LoaiVe"]);
                maGiaVeList.Add((String)dt.Rows[i]["MaGiaVe"]);
                giavelist.Add(int.Parse(dt.Rows[i]["GiaVe"].ToString()));
            }
            DataTable dt1 = doan.layDanhSachDoAn();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cboDoAn.Items.Add(dt1.Rows[i]["TenDoAn"]);
                maDoAnList.Add((String)dt1.Rows[i]["MaDoAn"]);
                giadoanlist.Add(int.Parse(dt1.Rows[i]["DonGia"].ToString()));
            }
            var reader = nvd.ThongTinCaNhan(FormDangNhap.txtUsernameCopy.Text);
            if (reader.Read())
            {
                lbl_nhanvien.Text = reader["HoVaTen"].ToString().Trim();
                lbl_machinhanh.Text = reader["MaChiNhanh"].ToString().Trim();
            }

            LoadGhe();        }

        private void cboSelectGiaVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboSelectGiaVe.Items.IndexOf(cboSelectGiaVe.SelectedItem);
            Console.WriteLine(maGiaVeList.Count);
            if (ind < 0)
                return;
            if (maGiaVeList.Count == 0)
                return;
            currMaGiaVe = maGiaVeList[ind];
            currGiaVe = giavelist[ind];
        }
        void LoadGhe()
        {
            this.dgv_ghe.DataSource = banve.searchGhe(mapc);
        }

        private void lblCusID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btn_Chonghe_Click(object sender, EventArgs e)
        {
            if(currmaghe==0)
            {
                MessageBox.Show("Chưa chọn ghế");
            }
            else
            {
                maGheList.Add(currmaghe);
                magvList.Add(currMaGiaVe);
                tongtien.Add(currGiaVe);
                TongTien = TongTien + currGiaVe;
                lbl_TongTien.Text = TongTien.ToString();
                lbl_listve.Text = lbl_listve.Text + currmaghe.ToString() + " ";
                banve.updateoneGhe(currmaghe);
                MessageBox.Show("Chọn ghế thành công");
                LoadGhe();
            }
        }

        private void lblSelectMovie_Click(object sender, EventArgs e)
        {

        }

        private void cboDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {
                int ind = cboDoAn.Items.IndexOf(cboDoAn.SelectedItem);
                if (ind < 0)
                    return;
                if (maDoAnList.Count == 0)
                    return;
                currDoAn = maDoAnList[ind];
                currgiadoan = giadoanlist[ind];

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txt_SoLuong.Text);
            if (txt_SoLuong != null)
            {
                maDoAnListMua.Add(currDoAn);
                soluonglist.Add(count);
                TongTien = TongTien + count * currgiadoan;
                lbl_TongTien.Text = TongTien.ToString();
                MessageBox.Show("Chọn đồ ăn thành công");

            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng");
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(maGheList.Count==0)
            {
                MessageBox.Show("Xin chọn vé trước");
            }
            else
            {
                for (int i = 0; i < maGheList.Count; i++)
                {
                    banve.createVe(manv, makh, maGheList[i], maGiaVeList[i], malc, tongtien[i]);
                }

                for (int i = 0; i < maDoAnListMua.Count; i++)
                {
                    banve.CreateHoaDonDoAn(maDoAnListMua[i], makh, soluonglist[i], DateTime.Now);
                }

                MessageBox.Show("Thanh toán thành công");
            }
            this.Close();
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ghe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ghe.Rows[e.RowIndex];
                currmaghe = int.Parse(row.Cells["MaGhe"].Value.ToString());
                MessageBox.Show("Chọn vé thành công");
            }
        }

        private void dgv_ghe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
