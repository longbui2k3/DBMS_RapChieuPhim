using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class Phim
    {
        public String MaPhim { get; set; }
        public String TenPhim { get; set; }
        public String Anh { get; set; }
        public Int32 ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public String DaoDien { get; set; }
        public String QuocGia { get; set; }
        public String DienVienChinh { get; set; }
        public String NhaSanXuat { get; set; }
        public String TomTatPhim { get; set; }
        public Int32 DoTuoi { get; set; }
        public Int32 TongThu { get; set; }

        public Phim(string maPhim, string tenPhim, string anh, int thoiLuong, DateTime ngayKhoiChieu, string daoDien, string quocGia, string dienVienChinh, string nhaSanXuat, string tomTatPhim, int doTuoi, int tongThu)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            Anh = anh;
            ThoiLuong = thoiLuong;
            NgayKhoiChieu = ngayKhoiChieu;
            DaoDien = daoDien;
            QuocGia = quocGia;
            DienVienChinh = dienVienChinh;
            NhaSanXuat = nhaSanXuat;
            TomTatPhim = tomTatPhim;
            DoTuoi = doTuoi;
            TongThu = tongThu;
        }
    }

}
