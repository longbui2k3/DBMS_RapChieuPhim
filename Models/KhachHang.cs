using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class KhachHang
    {
        public String MaKhachHang { get; set; }
        public String HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Email { get; set; }
        public String SoDienThoai { get; set; }
        public String GioiTinh { get; set; }
        public String DiaChi { get; set; }

        public KhachHang(string maKhachHang, string hoVaTen, DateTime ngaySinh, string email, string soDienThoai, string gioiTinh, string diaChi)
        {
            MaKhachHang = maKhachHang;
            HoVaTen = hoVaTen;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
    }

}
