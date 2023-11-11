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
        public String LoaiVe { get; set; }
        public int TangGia { get; set; }
        public int Gia { get; set; }

        public GiaVe(string maGiaVe, string loaiVe, int gia)
        {
            MaGiaVe = maGiaVe;
            LoaiVe = loaiVe;
            Gia = gia;
        }

        public GiaVe(string maGiaVe, string loaiVe, int tangGia, int gia)
        {
            MaGiaVe = maGiaVe;
            LoaiVe = loaiVe;
            TangGia = tangGia;
            Gia = gia;
        }
    }

}
