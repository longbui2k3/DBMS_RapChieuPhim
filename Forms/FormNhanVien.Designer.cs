namespace QuanLyRapChieuPhim
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_BanVe = new System.Windows.Forms.Button();
            this.btn_ThongTinCaNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1386, 681);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.btn_BanVe);
            this.panel1.Controls.Add(this.btn_ThongTinCaNhan);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 532);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 124);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(268, 62);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_BanVe
            // 
            this.btn_BanVe.FlatAppearance.BorderSize = 0;
            this.btn_BanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanVe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanVe.ForeColor = System.Drawing.Color.White;
            this.btn_BanVe.Location = new System.Drawing.Point(0, 62);
            this.btn_BanVe.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BanVe.Name = "btn_BanVe";
            this.btn_BanVe.Size = new System.Drawing.Size(268, 62);
            this.btn_BanVe.TabIndex = 1;
            this.btn_BanVe.Text = "Bán Vé";
            this.btn_BanVe.UseVisualStyleBackColor = true;
            this.btn_BanVe.Click += new System.EventHandler(this.btn_BanVe_Click);
            // 
            // btn_ThongTinCaNhan
            // 
            this.btn_ThongTinCaNhan.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTinCaNhan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinCaNhan.ForeColor = System.Drawing.Color.White;
            this.btn_ThongTinCaNhan.Location = new System.Drawing.Point(0, 0);
            this.btn_ThongTinCaNhan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThongTinCaNhan.Name = "btn_ThongTinCaNhan";
            this.btn_ThongTinCaNhan.Size = new System.Drawing.Size(268, 62);
            this.btn_ThongTinCaNhan.TabIndex = 0;
            this.btn_ThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btn_ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btn_ThongTinCaNhan.Click += new System.EventHandler(this.btn_ThongTinCaNhan_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ThongTinCaNhan;
        private System.Windows.Forms.Button btn_BanVe;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}

