using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class TaiKhoan
    {
        public String TenNguoiDung { get; set; }
        public String MatKhau { get; set; }

        public String LoaiTaiKhoan { get; set; }

        public TaiKhoan(string tenNguoiDung, string matKhau, string loaiTaiKhoan)
        {
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
        }
        public TaiKhoan(string tenNguoiDung, string matKhau)
        {
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
        }

    }
}
