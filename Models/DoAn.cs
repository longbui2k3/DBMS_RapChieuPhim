using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class DoAn
    {
        public String MaDoAn { get; set; }
        public String TenDoAn { get; set; }
        public Int32 DonGia { get; set; }
        public Int32 SoLuongCon { get; set; }

        public DoAn(string maDoAn, string tenDoAn, int donGia, int soLuongCon)
        {
            MaDoAn = maDoAn;
            TenDoAn = tenDoAn;
            DonGia = donGia;
            SoLuongCon = soLuongCon;
        }
    }

}
