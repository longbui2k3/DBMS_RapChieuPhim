﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim.DAO;
using QuanLyRapChieuPhim.Models;

namespace QuanLyRapChieuPhim.Forms
{
    public partial class FormDangNhap : Form
    {
        TaiKhoanDao tkDao = new TaiKhoanDao();
        public static TextBox txtUsernameCopy;
        public FormDangNhap()
        {
            InitializeComponent();
            txtUsernameCopy = txtUsername;
        }
        
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan(txtUsername.Text, txtPassword.Text);
            DataTable obj = tkDao.DangNhap(taiKhoan);
            String userId = null;
            String loaiTk = null;
            if (obj?.Rows.Count > 0)
            {
               userId = (String)obj.Rows[0][0];
               loaiTk = (String)obj.Rows[0][1];
            }
            if (loaiTk == "User" && userId != null)
            {
                DBConnection.TenNguoiDung = txtUsername.Text;
                DBConnection.MatKhau = txtPassword.Text;
                FormNhanVien nvForm = new FormNhanVien();
                nvForm.Show();
                this.Hide();
                
            }
            else if (loaiTk == "Admin" && userId != null)
            {
                DBConnection.TenNguoiDung = txtUsername.Text;
                DBConnection.MatKhau = txtPassword.Text;
                FormAdmin adForm = new FormAdmin();
                adForm.Show();
                this.Hide();
              
            }
        }
    }
}
