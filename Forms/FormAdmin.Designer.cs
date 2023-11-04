namespace QuanLyRapChieuPhim.Forms
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChiNhanh = new System.Windows.Forms.Button();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_ThongTinRap = new System.Windows.Forms.Button();
            this.btn_DoanhThu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Size = new System.Drawing.Size(1386, 681);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.btn_ChiNhanh);
            this.panel1.Controls.Add(this.btn_TaiKhoan);
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.btn_ThongTinRap);
            this.panel1.Controls.Add(this.btn_DoanhThu);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 532);
            this.panel1.TabIndex = 0;
            // 
            // btn_ChiNhanh
            // 
            this.btn_ChiNhanh.FlatAppearance.BorderSize = 0;
            this.btn_ChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiNhanh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btn_ChiNhanh.Location = new System.Drawing.Point(0, 249);
            this.btn_ChiNhanh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChiNhanh.Name = "btn_ChiNhanh";
            this.btn_ChiNhanh.Size = new System.Drawing.Size(268, 62);
            this.btn_ChiNhanh.TabIndex = 5;
            this.btn_ChiNhanh.Text = "Chi Nhánh";
            this.btn_ChiNhanh.UseVisualStyleBackColor = true;
            this.btn_ChiNhanh.Click += new System.EventHandler(this.btn_ChiNhanh_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 187);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Size = new System.Drawing.Size(268, 62);
            this.btn_TaiKhoan.TabIndex = 4;
            this.btn_TaiKhoan.Text = "Tài Khoản";
            this.btn_TaiKhoan.UseVisualStyleBackColor = true;
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoan_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 311);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(268, 62);
            this.btn_DangXuat.TabIndex = 3;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.Location = new System.Drawing.Point(1, 125);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(268, 62);
            this.btn_NhanVien.TabIndex = 2;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_ThongTinRap
            // 
            this.btn_ThongTinRap.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinRap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTinRap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinRap.ForeColor = System.Drawing.Color.White;
            this.btn_ThongTinRap.Location = new System.Drawing.Point(0, 62);
            this.btn_ThongTinRap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThongTinRap.Name = "btn_ThongTinRap";
            this.btn_ThongTinRap.Size = new System.Drawing.Size(268, 62);
            this.btn_ThongTinRap.TabIndex = 1;
            this.btn_ThongTinRap.Text = "Thông Tin Rạp";
            this.btn_ThongTinRap.UseVisualStyleBackColor = true;
            this.btn_ThongTinRap.Click += new System.EventHandler(this.btn_ThongTinRap_Click);
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_DoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoanhThu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoanhThu.ForeColor = System.Drawing.Color.White;
            this.btn_DoanhThu.Location = new System.Drawing.Point(0, 0);
            this.btn_DoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DoanhThu.Name = "btn_DoanhThu";
            this.btn_DoanhThu.Size = new System.Drawing.Size(268, 62);
            this.btn_DoanhThu.TabIndex = 0;
            this.btn_DoanhThu.Text = "Doanh Thu";
            this.btn_DoanhThu.UseVisualStyleBackColor = true;
            this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_ThongTinRap;
        private System.Windows.Forms.Button btn_DoanhThu;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Button btn_ChiNhanh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}