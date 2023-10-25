using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class PhongChieuPhim
    {
        public String MaPhong { get; set; }
        public String TenPhong { get; set; }
        public Int32 SoLuongGhe { get; set; }

        public PhongChieuPhim(string maPhong, string tenPhong, int soLuongGhe)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            SoLuongGhe = soLuongGhe;
        }
    }
}
