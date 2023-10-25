using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class LichChieuPhim
    {
        public String MaLichChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public Int32 SoGheConLai { get; set; }
        public String MaPhong { get; set; }
        public String MaPhim { get; set; }
        public String MaChiNhanh { get; set; }

        public LichChieuPhim(string maLichChieu, DateTime ngayChieu, TimeSpan gioBatDau, TimeSpan gioKetThuc, int soGheConLai, string maPhong, string maPhim, string maChiNhanh)
        {
            MaLichChieu = maLichChieu;
            NgayChieu = ngayChieu;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            SoGheConLai = soGheConLai;
            MaPhong = maPhong;
            MaPhim = maPhim;
            MaChiNhanh = maChiNhanh;
        }
    }

}
