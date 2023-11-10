namespace QuanLyRapChieuPhim.UC
{
    partial class LichChieuUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchShowtime = new System.Windows.Forms.Button();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGheConLai = new System.Windows.Forms.TextBox();
            this.txtMaLichChieu = new System.Windows.Forms.TextBox();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipCinema = new System.Windows.Forms.ToolTip(this.components);
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.panel54.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 88);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(168, 6);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 88);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(330, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 88);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(492, 6);
            this.btnXem.Margin = new System.Windows.Forms.Padding(6);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(150, 88);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(940, 46);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 41);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearchShowtime
            // 
            this.btnSearchShowtime.Location = new System.Drawing.Point(1450, 46);
            this.btnSearchShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchShowtime.Name = "btnSearchShowtime";
            this.btnSearchShowtime.Size = new System.Drawing.Size(98, 42);
            this.btnSearchShowtime.TabIndex = 7;
            this.btnSearchShowtime.Text = "Search";
            this.btnSearchShowtime.UseVisualStyleBackColor = true;
            this.btnSearchShowtime.Click += new System.EventHandler(this.btnSearchShowtime_Click);
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.btnSearchShowtime);
            this.panel54.Controls.Add(this.txtSearch);
            this.panel54.Controls.Add(this.btnXem);
            this.panel54.Controls.Add(this.btnSua);
            this.panel54.Controls.Add(this.btnXoa);
            this.panel54.Controls.Add(this.btnThem);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Margin = new System.Windows.Forms.Padding(6);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(1606, 100);
            this.panel54.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaChiNhanh);
            this.panel2.Controls.Add(this.txtMaPhim);
            this.panel2.Controls.Add(this.txtMaPhong);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSoGheConLai);
            this.panel2.Controls.Add(this.txtMaLichChieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(974, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 888);
            this.panel2.TabIndex = 0;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(242, 115);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(322, 31);
            this.txtMaPhong.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmGioKetThuc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtmGioBatDau);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmNgayChieu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(574, 246);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmGioKetThuc
            // 
            this.dtmGioKetThuc.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmGioKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmGioKetThuc.Location = new System.Drawing.Point(232, 159);
            this.dtmGioKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtmGioKetThuc.Name = "dtmGioKetThuc";
            this.dtmGioKetThuc.ShowUpDown = true;
            this.dtmGioKetThuc.Size = new System.Drawing.Size(322, 44);
            this.dtmGioKetThuc.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giờ bắt đầu:";
            // 
            // dtmGioBatDau
            // 
            this.dtmGioBatDau.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmGioBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmGioBatDau.Location = new System.Drawing.Point(232, 88);
            this.dtmGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtmGioBatDau.Name = "dtmGioBatDau";
            this.dtmGioBatDau.ShowUpDown = true;
            this.dtmGioBatDau.Size = new System.Drawing.Size(322, 44);
            this.dtmGioBatDau.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ bắt đầu:";
            // 
            // dtmNgayChieu
            // 
            this.dtmNgayChieu.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayChieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayChieu.Location = new System.Drawing.Point(232, 33);
            this.dtmNgayChieu.Margin = new System.Windows.Forms.Padding(4);
            this.dtmNgayChieu.Name = "dtmNgayChieu";
            this.dtmNgayChieu.Size = new System.Drawing.Size(322, 44);
            this.dtmNgayChieu.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 645);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số ghế";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 36);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã chi nhánh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 36);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // txtSoGheConLai
            // 
            this.txtSoGheConLai.Location = new System.Drawing.Point(262, 649);
            this.txtSoGheConLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoGheConLai.Name = "txtSoGheConLai";
            this.txtSoGheConLai.Size = new System.Drawing.Size(322, 31);
            this.txtSoGheConLai.TabIndex = 18;
            // 
            // txtMaLichChieu
            // 
            this.txtMaLichChieu.Enabled = false;
            this.txtMaLichChieu.Location = new System.Drawing.Point(242, 21);
            this.txtMaLichChieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLichChieu.Name = "txtMaLichChieu";
            this.txtMaLichChieu.Size = new System.Drawing.Size(322, 31);
            this.txtMaLichChieu.TabIndex = 19;
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.AllowUserToAddRows = false;
            this.dgvLichChieu.AllowUserToDeleteRows = false;
            this.dgvLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichChieu.Location = new System.Drawing.Point(0, 0);
            this.dgvLichChieu.Margin = new System.Windows.Forms.Padding(6);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.ReadOnly = true;
            this.dgvLichChieu.RowHeadersWidth = 82;
            this.dgvLichChieu.Size = new System.Drawing.Size(974, 888);
            this.dgvLichChieu.TabIndex = 1;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLichChieu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 888);
            this.panel1.TabIndex = 15;
            // 
            // toolTipCinema
            // 
            this.toolTipCinema.AutoPopDelay = 5000;
            this.toolTipCinema.InitialDelay = 100;
            this.toolTipCinema.ReshowDelay = 100;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(242, 169);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(322, 31);
            this.txtMaPhim.TabIndex = 30;
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.Location = new System.Drawing.Point(242, 224);
            this.txtMaChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(322, 31);
            this.txtMaChiNhanh.TabIndex = 31;
            // 
            // LichChieuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel54);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LichChieuUC";
            this.Size = new System.Drawing.Size(1606, 988);
            this.Load += new System.EventHandler(this.LichChieuUC_Load_1);
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtmGioKetThuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmGioBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmNgayChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGheConLai;
        private System.Windows.Forms.TextBox txtMaLichChieu;
        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipCinema;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
    }
}
