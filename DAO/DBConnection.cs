using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.DAO
{
    internal class DBConnection
    {
        public static string TenNguoiDung = "";
        public static string MatKhau = "";
        public SqlConnection conn;
        public DBConnection()
        {
            /*if (TenNguoiDung != "")
            {
                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Database=QLRapPhim;User Id=" + TenNguoiDung + ";Password=" + MatKhau);
            }
            else*/
                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Database=QLRapPhim;Integrated Security=True");
        }
    }
}