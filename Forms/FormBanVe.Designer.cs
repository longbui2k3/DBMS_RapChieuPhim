namespace QuanLyRapChieuPhim.Forms
{
    partial class FormBanVe
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
            this.dgv_ghe = new System.Windows.Forms.DataGridView();
            this.lblCusID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            this.btn_Chonghe = new System.Windows.Forms.Button();
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.cboSelectGiaVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_machinhanh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDoAn = new System.Windows.Forms.ComboBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.Btn_Huy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_listve = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ghe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ghe
            // 
            this.dgv_ghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ghe.Location = new System.Drawing.Point(12, 72);
            this.dgv_ghe.Name = "dgv_ghe";
            this.dgv_ghe.RowHeadersWidth = 51;
            this.dgv_ghe.RowTemplate.Height = 24;
            this.dgv_ghe.Size = new System.Drawing.Size(460, 502);
            this.dgv_ghe.TabIndex = 0;
            this.dgv_ghe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ghe_CellContentClick);
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(189, 46);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(89, 23);
            this.lblCusID.TabIndex = 76;
            this.lblCusID.Text = "Chọn ghế";
            this.lblCusID.Click += new System.EventHandler(this.lblCusID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Location = new System.Drawing.Point(111, 9);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(0, 23);
            this.lbl_nhanvien.TabIndex = 78;
            this.lbl_nhanvien.Click += new System.EventHandler(this.lbl_nhanvien_Click);
            // 
            // btn_Chonghe
            // 
            this.btn_Chonghe.Location = new System.Drawing.Point(804, 123);
            this.btn_Chonghe.Name = "btn_Chonghe";
            this.btn_Chonghe.Size = new System.Drawing.Size(94, 44);
            this.btn_Chonghe.TabIndex = 79;
            this.btn_Chonghe.Text = "Chọn ghế";
            this.btn_Chonghe.UseVisualStyleBackColor = true;
            this.btn_Chonghe.Click += new System.EventHandler(this.btn_Chonghe_Click);
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.Location = new System.Drawing.Point(656, 188);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(119, 24);
            this.lblSelectMovie.TabIndex = 82;
            this.lblSelectMovie.Text = "Chọn đồ ăn";
            this.lblSelectMovie.Click += new System.EventHandler(this.lblSelectMovie_Click);
            // 
            // cboSelectGiaVe
            // 
            this.cboSelectGiaVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectGiaVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectGiaVe.FormattingEnabled = true;
            this.cboSelectGiaVe.Location = new System.Drawing.Point(804, 76);
            this.cboSelectGiaVe.Name = "cboSelectGiaVe";
            this.cboSelectGiaVe.Size = new System.Drawing.Size(299, 31);
            this.cboSelectGiaVe.TabIndex = 81;
            this.cboSelectGiaVe.SelectedIndexChanged += new System.EventHandler(this.cboSelectGiaVe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "Chi Nhánh:";
            // 
            // lbl_machinhanh
            // 
            this.lbl_machinhanh.AutoSize = true;
            this.lbl_machinhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_machinhanh.Location = new System.Drawing.Point(289, 9);
            this.lbl_machinhanh.Name = "lbl_machinhanh";
            this.lbl_machinhanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_machinhanh.Size = new System.Drawing.Size(0, 23);
            this.lbl_machinhanh.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Chọn loại vé";
            // 
            // cboDoAn
            // 
            this.cboDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoAn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoAn.FormattingEnabled = true;
            this.cboDoAn.Location = new System.Drawing.Point(804, 185);
            this.cboDoAn.Name = "cboDoAn";
            this.cboDoAn.Size = new System.Drawing.Size(299, 31);
            this.cboDoAn.TabIndex = 85;
            this.cboDoAn.SelectedIndexChanged += new System.EventHandler(this.cboDoAn_SelectedIndexChanged);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(804, 244);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(114, 22);
            this.txt_SoLuong.TabIndex = 87;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "Số lượng";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(804, 285);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(94, 44);
            this.btn_XacNhan.TabIndex = 89;
            this.btn_XacNhan.Text = "xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(965, 569);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(94, 44);
            this.btn_ThanhToan.TabIndex = 90;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // Btn_Huy
            // 
            this.Btn_Huy.Location = new System.Drawing.Point(1087, 569);
            this.Btn_Huy.Name = "Btn_Huy";
            this.Btn_Huy.Size = new System.Drawing.Size(94, 44);
            this.Btn_Huy.TabIndex = 91;
            this.Btn_Huy.Text = "Hủy";
            this.Btn_Huy.UseVisualStyleBackColor = true;
            this.Btn_Huy.Click += new System.EventHandler(this.Btn_Huy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tổng tiền:";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(762, 569);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(0, 24);
            this.lbl_TongTien.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 23);
            this.label6.TabIndex = 94;
            this.label6.Text = "Các vé đang chọn:";
            // 
            // lbl_listve
            // 
            this.lbl_listve.AutoSize = true;
            this.lbl_listve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listve.Location = new System.Drawing.Point(171, 603);
            this.lbl_listve.Name = "lbl_listve";
            this.lbl_listve.Size = new System.Drawing.Size(0, 23);
            this.lbl_listve.TabIndex = 95;
            // 
            // FormBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 648);
            this.Controls.Add(this.lbl_listve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Huy);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDoAn);
            this.Controls.Add(this.lbl_machinhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.cboSelectGiaVe);
            this.Controls.Add(this.btn_Chonghe);
            this.Controls.Add(this.lbl_nhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.dgv_ghe);
            this.Name = "FormBanVe";
            this.Text = "FormBanVe";
            this.Load += new System.EventHandler(this.FormBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ghe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ghe;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nhanvien;
        private System.Windows.Forms.Button btn_Chonghe;
        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.ComboBox cboSelectGiaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_machinhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDoAn;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button Btn_Huy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_listve;
    }
}