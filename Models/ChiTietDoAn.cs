using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class ChiTietDoAn
    {
        public String MaDoAn { get; set; }
        public String MaVe { get; set; }
        public Int32 SoLuong { get; set; }

        public ChiTietDoAn(string maDoAn, string maVe, int soLuong)
        {
            MaDoAn = maDoAn;
            MaVe = maVe;
            SoLuong = soLuong;
        }
    }

}
