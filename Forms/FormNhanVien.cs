using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.DAO;

namespace QuanLyRapChieuPhim
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private DBConnection dao = new DBConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                dao.conn.Open();
                string query = "select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query, dao.conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                Console.WriteLine("Ket noi thanh cong");
            }
            catch(Exception err)
            {
                Console.WriteLine("That bai");
            }*/
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
