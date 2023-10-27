using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class NhanVien
    {
        public String MaNhanVien { get; set; }
        public String HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Email { get; set; }
        public String SoDienThoai { get; set; }
        public String GioiTinh { get; set; }
        public String DiaChi { get; set; }
        public int Luong { get; set; }
        public String CaLamViec { get; set; }
        public String ViTri { get; set; }

        // Foreign key relationships
        public String TenNguoiDung { get; set; }
        public String MaChiNhanh { get; set; }
        public String MaChiNhanhQuanLy { get; set; }

        public NhanVien(string maNhanVien, string hoVaTen, DateTime ngaySinh, string email, string soDienThoai, string gioiTinh, string diaChi, int luong, string caLamViec, string viTri, string tenNguoiDung, string maChiNhanh, string maChiNhanhQuanLy)
        {
            MaNhanVien = maNhanVien;
            HoVaTen = hoVaTen;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Luong = luong;
            CaLamViec = caLamViec;
            ViTri = viTri;
            TenNguoiDung = tenNguoiDung;
            MaChiNhanh = maChiNhanh;
            MaChiNhanhQuanLy = maChiNhanhQuanLy;
        }

        public String getMaNhanVien { get { return MaNhanVien; } }
        public String getHoVaTen { get { return HoVaTen; } }
        public DateTime getNgaySinh { get { return NgaySinh; } }
        public String getEmail { get { return Email; } }
        public String getSoDienThoai { get { return SoDienThoai; } }
        public String getGioiTinh { get { return GioiTinh; } }
        public String getDiaChi { get { return DiaChi; } }
        public int getLuong { get { return Luong; } }
        public String getCaLamViec { get { return CaLamViec; } }
        public String getViTri { get { return ViTri; } }

        public String getTenNguoiDung { get { return TenNguoiDung; } }
        public String getMaChiNhanh { get { return MaChiNhanh; } }
        public String getMaChiNhanhQuanLy { get { return MaChiNhanhQuanLy; } }
    }

}
