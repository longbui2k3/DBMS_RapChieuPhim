using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class Ve
    {
        public string MaVe { get; set; }
        public DateTime ThoiGianXuatVe { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaGhe { get; set; }
        public string MaGiaVe { get; set; }
        public string MaLichChieu { get; set; }

        public Ve(string maVe, DateTime thoiGianXuatVe, string maNhanVien, string maKhachHang, string maGhe, string maGiaVe, string maLichChieu)
        {
            MaVe = maVe;
            ThoiGianXuatVe = thoiGianXuatVe;
            MaNhanVien = maNhanVien;
            MaKhachHang = maKhachHang;
            MaGhe = maGhe;
            MaGiaVe = maGiaVe;
            MaLichChieu = maLichChieu;
        }
    }

}
