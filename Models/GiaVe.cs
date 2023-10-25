using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class GiaVe
    {
        public String MaGiaVe { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan ThoiGianChieu { get; set; }
        public bool NgayLe { get; set; }
        public int Gia { get; set; }

        public GiaVe(string maGiaVe, DateTime ngayChieu, TimeSpan thoiGianChieu, bool ngayLe, int gia)
        {
            MaGiaVe = maGiaVe;
            NgayChieu = ngayChieu;
            ThoiGianChieu = thoiGianChieu;
            NgayLe = ngayLe;
            Gia = gia;
        }
    }

}
