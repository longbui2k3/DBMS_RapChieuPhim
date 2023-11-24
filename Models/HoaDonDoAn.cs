using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class HoaDonDoAn
    {
        public String MaDoAn { get; set; }
        public String MaVe { get; set; }
        public Int32 SoLuong { get; set; }

        public DateTime NgayXuat { get; set; }

        public HoaDonDoAn(string maDoAn, string maVe, int soLuong, DateTime ngayXuat)
        {
            MaDoAn = maDoAn;
            MaVe = maVe;
            SoLuong = soLuong;
            NgayXuat = ngayXuat;
        }
    }

}
