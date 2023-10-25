using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class Ghe
    {
        public String MaGhe { get; set; }
        public String TinhTrang { get; set; }
        public String MaPhong { get; set; }

        public Ghe(string maGhe, string tinhTrang, string maPhong)
        {
            MaGhe = maGhe;
            TinhTrang = tinhTrang;
            MaPhong = maPhong;
        }
    }

}
