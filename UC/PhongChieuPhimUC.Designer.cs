namespace QuanLyRapChieuPhim.UC
{
    partial class PhongChieuPhimUC
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
            this.btnShowCinema = new System.Windows.Forms.Button();
            this.btnUpdateCinema = new System.Windows.Forms.Button();
            this.btnDeleteCinema = new System.Windows.Forms.Button();
            this.btnInsertCinema = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCinema = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchPhongCP = new System.Windows.Forms.Button();
            this.txtSearchPhongCP = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSoChoNgoi = new System.Windows.Forms.TextBox();
            this.lblCinemaSeats = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblCinemaName = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblCinemaID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCinema
            // 
            this.btnShowCinema.Location = new System.Drawing.Point(340, 18);
            this.btnShowCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCinema.Name = "btnShowCinema";
            this.btnShowCinema.Size = new System.Drawing.Size(100, 57);
            this.btnShowCinema.TabIndex = 3;
            this.btnShowCinema.Text = "Xem";
            this.btnShowCinema.UseVisualStyleBackColor = true;
            this.btnShowCinema.Click += new System.EventHandler(this.btnShowCinema_Click);
            // 
            // btnUpdateCinema
            // 
            this.btnUpdateCinema.Location = new System.Drawing.Point(232, 18);
            this.btnUpdateCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCinema.Name = "btnUpdateCinema";
            this.btnUpdateCinema.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateCinema.TabIndex = 2;
            this.btnUpdateCinema.Text = "Sửa";
            this.btnUpdateCinema.UseVisualStyleBackColor = true;
            this.btnUpdateCinema.Click += new System.EventHandler(this.btnUpdateCinema_Click);
            // 
            // btnDeleteCinema
            // 
            this.btnDeleteCinema.Location = new System.Drawing.Point(124, 18);
            this.btnDeleteCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCinema.Name = "btnDeleteCinema";
            this.btnDeleteCinema.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteCinema.TabIndex = 1;
            this.btnDeleteCinema.Text = "Xóa";
            this.btnDeleteCinema.UseVisualStyleBackColor = true;
            this.btnDeleteCinema.Click += new System.EventHandler(this.btnDeleteCinema_Click);
            // 
            // btnInsertCinema
            // 
            this.btnInsertCinema.Location = new System.Drawing.Point(16, 18);
            this.btnInsertCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertCinema.Name = "btnInsertCinema";
            this.btnInsertCinema.Size = new System.Drawing.Size(100, 57);
            this.btnInsertCinema.TabIndex = 0;
            this.btnInsertCinema.Text = "Thêm";
            this.btnInsertCinema.UseVisualStyleBackColor = true;
            this.btnInsertCinema.Click += new System.EventHandler(this.btnInsertCinema_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCinema);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1724, 717);
            this.panel1.TabIndex = 12;
            // 
            // dtgvCinema
            // 
            this.dtgvCinema.AllowUserToAddRows = false;
            this.dtgvCinema.AllowUserToDeleteRows = false;
            this.dtgvCinema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCinema.Location = new System.Drawing.Point(0, 0);
            this.dtgvCinema.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCinema.Name = "dtgvCinema";
            this.dtgvCinema.ReadOnly = true;
            this.dtgvCinema.RowHeadersWidth = 51;
            this.dtgvCinema.Size = new System.Drawing.Size(1248, 717);
            this.dtgvCinema.TabIndex = 1;
            this.dtgvCinema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCinema_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchPhongCP);
            this.panel2.Controls.Add(this.txtSearchPhongCP);
            this.panel2.Controls.Add(this.btnShowCinema);
            this.panel2.Controls.Add(this.btnUpdateCinema);
            this.panel2.Controls.Add(this.btnDeleteCinema);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.btnInsertCinema);
            this.panel2.Controls.Add(this.panel31);
            this.panel2.Controls.Add(this.panel32);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1248, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 717);
            this.panel2.TabIndex = 0;
            // 
            // btnSearchPhongCP
            // 
            this.btnSearchPhongCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPhongCP.Location = new System.Drawing.Point(348, 107);
            this.btnSearchPhongCP.Name = "btnSearchPhongCP";
            this.btnSearchPhongCP.Size = new System.Drawing.Size(92, 33);
            this.btnSearchPhongCP.TabIndex = 29;
            this.btnSearchPhongCP.Text = "Search";
            this.btnSearchPhongCP.UseVisualStyleBackColor = true;
            this.btnSearchPhongCP.Click += new System.EventHandler(this.btnSearchPhongCP_Click);
            // 
            // txtSearchPhongCP
            // 
            this.txtSearchPhongCP.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPhongCP.Location = new System.Drawing.Point(16, 107);
            this.txtSearchPhongCP.Name = "txtSearchPhongCP";
            this.txtSearchPhongCP.Size = new System.Drawing.Size(316, 33);
            this.txtSearchPhongCP.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtSoChoNgoi);
            this.panel8.Controls.Add(this.lblCinemaSeats);
            this.panel8.Location = new System.Drawing.Point(16, 293);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(442, 54);
            this.panel8.TabIndex = 8;
            // 
            // txtSoChoNgoi
            // 
            this.txtSoChoNgoi.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoChoNgoi.Location = new System.Drawing.Point(137, 11);
            this.txtSoChoNgoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoChoNgoi.Name = "txtSoChoNgoi";
            this.txtSoChoNgoi.Size = new System.Drawing.Size(282, 33);
            this.txtSoChoNgoi.TabIndex = 4;
            // 
            // lblCinemaSeats
            // 
            this.lblCinemaSeats.AutoSize = true;
            this.lblCinemaSeats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaSeats.Location = new System.Drawing.Point(4, 11);
            this.lblCinemaSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaSeats.Name = "lblCinemaSeats";
            this.lblCinemaSeats.Size = new System.Drawing.Size(130, 24);
            this.lblCinemaSeats.TabIndex = 0;
            this.lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.txtTenPhong);
            this.panel31.Controls.Add(this.lblCinemaName);
            this.panel31.Location = new System.Drawing.Point(16, 231);
            this.panel31.Margin = new System.Windows.Forms.Padding(4);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(442, 54);
            this.panel31.TabIndex = 9;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(137, 11);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(282, 33);
            this.txtTenPhong.TabIndex = 2;
            // 
            // lblCinemaName
            // 
            this.lblCinemaName.AutoSize = true;
            this.lblCinemaName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaName.Location = new System.Drawing.Point(4, 11);
            this.lblCinemaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaName.Name = "lblCinemaName";
            this.lblCinemaName.Size = new System.Drawing.Size(119, 24);
            this.lblCinemaName.TabIndex = 0;
            this.lblCinemaName.Text = "Tên phòng:";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.txtMaPhong);
            this.panel32.Controls.Add(this.lblCinemaID);
            this.panel32.Location = new System.Drawing.Point(16, 170);
            this.panel32.Margin = new System.Windows.Forms.Padding(4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(442, 54);
            this.panel32.TabIndex = 3;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(137, 10);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(282, 33);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblCinemaID
            // 
            this.lblCinemaID.AutoSize = true;
            this.lblCinemaID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaID.Location = new System.Drawing.Point(4, 14);
            this.lblCinemaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaID.Name = "lblCinemaID";
            this.lblCinemaID.Size = new System.Drawing.Size(111, 24);
            this.lblCinemaID.TabIndex = 0;
            this.lblCinemaID.Text = "Mã phòng:";
            // 
            // PhongChieuPhimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PhongChieuPhimUC";
            this.Size = new System.Drawing.Size(1724, 717);
            this.Load += new System.EventHandler(this.PhongChieuPhimUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowCinema;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnDeleteCinema;
        private System.Windows.Forms.Button btnInsertCinema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCinema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCinemaSeats;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label lblCinemaName;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblCinemaID;
        private System.Windows.Forms.TextBox txtSoChoNgoi;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Button btnSearchPhongCP;
        private System.Windows.Forms.TextBox txtSearchPhongCP;
    }
}
