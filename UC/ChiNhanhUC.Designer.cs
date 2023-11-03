namespace QuanLyRapChieuPhim.UC
{
    partial class ChiNhanhUC
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.data_ChiNhanh = new System.Windows.Forms.DataGridView();
            this.MaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenChiNhanh = new System.Windows.Forms.TextBox();
            this.txt_MaChiNhanh = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TinhTP = new System.Windows.Forms.Label();
            this.lbl_TenChiNhanh = new System.Windows.Forms.Label();
            this.lbl_MaChiNhanh = new System.Windows.Forms.Label();
            this.txt_TinhTP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_ChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(65, 262);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(157, 22);
            this.txt_Search.TabIndex = 38;
            // 
            // data_ChiNhanh
            // 
            this.data_ChiNhanh.BackgroundColor = System.Drawing.Color.White;
            this.data_ChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiNhanh,
            this.TenChiNhanh,
            this.TinhTP,
            this.DiaChi});
            this.data_ChiNhanh.Location = new System.Drawing.Point(456, 0);
            this.data_ChiNhanh.Name = "data_ChiNhanh";
            this.data_ChiNhanh.RowHeadersWidth = 51;
            this.data_ChiNhanh.RowTemplate.Height = 24;
            this.data_ChiNhanh.Size = new System.Drawing.Size(651, 591);
            this.data_ChiNhanh.TabIndex = 36;
            this.data_ChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ChiNhanh_CellContentClick);
            // 
            // MaChiNhanh
            // 
            this.MaChiNhanh.DataPropertyName = "MaChiNhanh";
            this.MaChiNhanh.HeaderText = "Mã chi nhánh";
            this.MaChiNhanh.MinimumWidth = 6;
            this.MaChiNhanh.Name = "MaChiNhanh";
            this.MaChiNhanh.Width = 125;
            // 
            // TenChiNhanh
            // 
            this.TenChiNhanh.DataPropertyName = "TenChiNhanh";
            this.TenChiNhanh.HeaderText = "Tên chi nhánh";
            this.TenChiNhanh.MinimumWidth = 6;
            this.TenChiNhanh.Name = "TenChiNhanh";
            this.TenChiNhanh.Width = 125;
            // 
            // TinhTP
            // 
            this.TinhTP.DataPropertyName = "TinhTP";
            this.TinhTP.HeaderText = "Tỉnh, Thành phố";
            this.TinhTP.MinimumWidth = 6;
            this.TinhTP.Name = "TinhTP";
            this.TinhTP.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(297, 530);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(185, 530);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(85, 530);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(248, 262);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(124, 23);
            this.btn_TimKiem.TabIndex = 32;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(148, 196);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(263, 22);
            this.txt_DiaChi.TabIndex = 30;
            // 
            // txt_TenChiNhanh
            // 
            this.txt_TenChiNhanh.Location = new System.Drawing.Point(148, 96);
            this.txt_TenChiNhanh.Name = "txt_TenChiNhanh";
            this.txt_TenChiNhanh.Size = new System.Drawing.Size(263, 22);
            this.txt_TenChiNhanh.TabIndex = 29;
            // 
            // txt_MaChiNhanh
            // 
            this.txt_MaChiNhanh.Location = new System.Drawing.Point(148, 45);
            this.txt_MaChiNhanh.Name = "txt_MaChiNhanh";
            this.txt_MaChiNhanh.Size = new System.Drawing.Size(263, 22);
            this.txt_MaChiNhanh.TabIndex = 26;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(35, 199);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(53, 16);
            this.lbl_DiaChi.TabIndex = 25;
            this.lbl_DiaChi.Text = "Địa chỉ :";
            // 
            // lbl_TinhTP
            // 
            this.lbl_TinhTP.AutoSize = true;
            this.lbl_TinhTP.Location = new System.Drawing.Point(35, 146);
            this.lbl_TinhTP.Name = "lbl_TinhTP";
            this.lbl_TinhTP.Size = new System.Drawing.Size(112, 16);
            this.lbl_TinhTP.TabIndex = 24;
            this.lbl_TinhTP.Text = "Tỉnh, Thành phố : ";
            // 
            // lbl_TenChiNhanh
            // 
            this.lbl_TenChiNhanh.AutoSize = true;
            this.lbl_TenChiNhanh.Location = new System.Drawing.Point(35, 99);
            this.lbl_TenChiNhanh.Name = "lbl_TenChiNhanh";
            this.lbl_TenChiNhanh.Size = new System.Drawing.Size(99, 16);
            this.lbl_TenChiNhanh.TabIndex = 23;
            this.lbl_TenChiNhanh.Text = "Tên chi nhánh : ";
            // 
            // lbl_MaChiNhanh
            // 
            this.lbl_MaChiNhanh.AutoSize = true;
            this.lbl_MaChiNhanh.Location = new System.Drawing.Point(35, 48);
            this.lbl_MaChiNhanh.Name = "lbl_MaChiNhanh";
            this.lbl_MaChiNhanh.Size = new System.Drawing.Size(91, 16);
            this.lbl_MaChiNhanh.TabIndex = 22;
            this.lbl_MaChiNhanh.Text = "Mã chi nhánh :";
            // 
            // txt_TinhTP
            // 
            this.txt_TinhTP.Location = new System.Drawing.Point(148, 143);
            this.txt_TinhTP.Name = "txt_TinhTP";
            this.txt_TinhTP.Size = new System.Drawing.Size(263, 22);
            this.txt_TinhTP.TabIndex = 39;
            // 
            // ChiNhanhUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_TinhTP);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.data_ChiNhanh);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_TenChiNhanh);
            this.Controls.Add(this.txt_MaChiNhanh);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_TinhTP);
            this.Controls.Add(this.lbl_TenChiNhanh);
            this.Controls.Add(this.lbl_MaChiNhanh);
            this.Name = "ChiNhanhUC";
            this.Size = new System.Drawing.Size(1120, 591);
            this.Load += new System.EventHandler(this.ChiNhanhUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView data_ChiNhanh;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenChiNhanh;
        private System.Windows.Forms.TextBox txt_MaChiNhanh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TinhTP;
        private System.Windows.Forms.Label lbl_TenChiNhanh;
        private System.Windows.Forms.Label lbl_MaChiNhanh;
        private System.Windows.Forms.TextBox txt_TinhTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
