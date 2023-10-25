using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Models
{
    internal class ChiNhanh
    {
        public String MaChiNhanh { get; set; }
        public String TenChiNhanh { get; set; }
        public String TinhTP { get; set; }
        public String DiaChi { get; set; }

        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string tinhTP, string diaChi)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            TinhTP = tinhTP;
            DiaChi = diaChi;
        }
    }
}
