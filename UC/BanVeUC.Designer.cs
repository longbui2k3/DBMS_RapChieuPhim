namespace QuanLyRapChieuPhim.UC
{
    partial class BanVeUC
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
            this.dgv_LichChieu = new System.Windows.Forms.DataGridView();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.cboSelectMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_khachhang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.btn_chonphim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ChiNhanh = new System.Windows.Forms.Label();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LichChieu
            // 
            this.dgv_LichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichChieu.Location = new System.Drawing.Point(6, 303);
            this.dgv_LichChieu.Name = "dgv_LichChieu";
            this.dgv_LichChieu.RowHeadersWidth = 51;
            this.dgv_LichChieu.RowTemplate.Height = 24;
            this.dgv_LichChieu.Size = new System.Drawing.Size(1068, 309);
            this.dgv_LichChieu.TabIndex = 0;
            this.dgv_LichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichChieu_CellClick);
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(478, 23);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(142, 23);
            this.lblCusID.TabIndex = 75;
            this.lblCusID.Text = "Tên khách hàng";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(626, 21);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(191, 30);
            this.txt_ten.TabIndex = 74;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(477, 112);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(597, 131);
            this.dgv_KhachHang.TabIndex = 76;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(823, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 39);
            this.btn_search.TabIndex = 77;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(746, 258);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(85, 39);
            this.btn_XacNhan.TabIndex = 78;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.Location = new System.Drawing.Point(19, 238);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(119, 24);
            this.lblSelectMovie.TabIndex = 80;
            this.lblSelectMovie.Text = "Chọn phim:";
            this.lblSelectMovie.Click += new System.EventHandler(this.lblSelectMovie_Click);
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectMovie.FormattingEnabled = true;
            this.cboSelectMovie.Items.AddRange(new object[] {
            "----All----"});
            this.cboSelectMovie.Location = new System.Drawing.Point(167, 231);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(299, 31);
            this.cboSelectMovie.TabIndex = 79;
            this.cboSelectMovie.SelectedIndexChanged += new System.EventHandler(this.cboSelectMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "Khách hàng:";
            // 
            // lbl_khachhang
            // 
            this.lbl_khachhang.AutoSize = true;
            this.lbl_khachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khachhang.Location = new System.Drawing.Point(163, 146);
            this.lbl_khachhang.Name = "lbl_khachhang";
            this.lbl_khachhang.Size = new System.Drawing.Size(15, 23);
            this.lbl_khachhang.TabIndex = 82;
            this.lbl_khachhang.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tuổi:";
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.Location = new System.Drawing.Point(163, 190);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(15, 23);
            this.lbl_tuoi.TabIndex = 84;
            this.lbl_tuoi.Text = " ";
            // 
            // btn_chonphim
            // 
            this.btn_chonphim.Location = new System.Drawing.Point(477, 632);
            this.btn_chonphim.Name = "btn_chonphim";
            this.btn_chonphim.Size = new System.Drawing.Size(85, 39);
            this.btn_chonphim.TabIndex = 85;
            this.btn_chonphim.Text = "Chọn phim";
            this.btn_chonphim.UseVisualStyleBackColor = true;
            this.btn_chonphim.Click += new System.EventHandler(this.btn_chonphim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "Chi nhánh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_ChiNhanh
            // 
            this.lbl_ChiNhanh.AutoSize = true;
            this.lbl_ChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChiNhanh.Location = new System.Drawing.Point(130, 21);
            this.lbl_ChiNhanh.Name = "lbl_ChiNhanh";
            this.lbl_ChiNhanh.Size = new System.Drawing.Size(0, 23);
            this.lbl_ChiNhanh.TabIndex = 88;
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Location = new System.Drawing.Point(130, 56);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(0, 23);
            this.lbl_nhanvien.TabIndex = 89;
            // 
            // BanVeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_nhanvien);
            this.Controls.Add(this.lbl_ChiNhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_chonphim);
            this.Controls.Add(this.lbl_tuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_khachhang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.cboSelectMovie);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.dgv_LichChieu);
            this.Name = "BanVeUC";
            this.Size = new System.Drawing.Size(1165, 722);
            this.Load += new System.EventHandler(this.BanVeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LichChieu;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_khachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.Button btn_chonphim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ChiNhanh;
        private System.Windows.Forms.Label lbl_nhanvien;
    }
}
