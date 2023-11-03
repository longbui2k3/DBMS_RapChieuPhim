namespace QuanLyRapChieuPhim.UC
{
    partial class DoAnUC
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtSoLuongCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtMaDoAn = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenDoAn = new System.Windows.Forms.TextBox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.btnSearchDoAn = new System.Windows.Forms.Button();
            this.txtSearchDoAn = new System.Windows.Forms.TextBox();
            this.btnXoaDoAn = new System.Windows.Forms.Button();
            this.btnXemDoAn = new System.Windows.Forms.Button();
            this.btnSuaDoAn = new System.Windows.Forms.Button();
            this.btnThemDoAn = new System.Windows.Forms.Button();
            this.dgvDoAn = new System.Windows.Forms.DataGridView();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.txtSoLuongCon);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.lblCusID);
            this.grpCustomer.Controls.Add(this.txtMaDoAn);
            this.grpCustomer.Controls.Add(this.txtDonGia);
            this.grpCustomer.Controls.Add(this.txtTenDoAn);
            this.grpCustomer.Controls.Add(this.lblCusAddress);
            this.grpCustomer.Controls.Add(this.lblCusName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(4, 0);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomer.Size = new System.Drawing.Size(1962, 323);
            this.grpCustomer.TabIndex = 18;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin đồ ăn";
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCon.Location = new System.Drawing.Point(1203, 117);
            this.txtSoLuongCon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(284, 44);
            this.txtSoLuongCon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(958, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Lượng Còn:";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(118, 64);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(158, 36);
            this.lblCusID.TabIndex = 4;
            this.lblCusID.Text = "Mã Đồ Ăn";
            // 
            // txtMaDoAn
            // 
            this.txtMaDoAn.Enabled = false;
            this.txtMaDoAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoAn.Location = new System.Drawing.Point(282, 60);
            this.txtMaDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDoAn.Name = "txtMaDoAn";
            this.txtMaDoAn.Size = new System.Drawing.Size(284, 44);
            this.txtMaDoAn.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(1203, 56);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(284, 44);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenDoAn
            // 
            this.txtTenDoAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoAn.Location = new System.Drawing.Point(282, 114);
            this.txtTenDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDoAn.Name = "txtTenDoAn";
            this.txtTenDoAn.Size = new System.Drawing.Size(284, 44);
            this.txtTenDoAn.TabIndex = 2;
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAddress.Location = new System.Drawing.Point(958, 56);
            this.lblCusAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(131, 36);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "Đơn Giá";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(118, 119);
            this.lblCusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(175, 36);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Tên Đồ Ăn:";
            // 
            // btnSearchDoAn
            // 
            this.btnSearchDoAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDoAn.Location = new System.Drawing.Point(1571, 401);
            this.btnSearchDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchDoAn.Name = "btnSearchDoAn";
            this.btnSearchDoAn.Size = new System.Drawing.Size(108, 41);
            this.btnSearchDoAn.TabIndex = 33;
            this.btnSearchDoAn.Text = "Search";
            this.btnSearchDoAn.UseVisualStyleBackColor = true;
            this.btnSearchDoAn.Click += new System.EventHandler(this.btnSearchDoAn_Click);
            // 
            // txtSearchDoAn
            // 
            this.txtSearchDoAn.Location = new System.Drawing.Point(1363, 406);
            this.txtSearchDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchDoAn.Name = "txtSearchDoAn";
            this.txtSearchDoAn.Size = new System.Drawing.Size(196, 31);
            this.txtSearchDoAn.TabIndex = 32;
            // 
            // btnXoaDoAn
            // 
            this.btnXoaDoAn.Location = new System.Drawing.Point(1073, 397);
            this.btnXoaDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaDoAn.Name = "btnXoaDoAn";
            this.btnXoaDoAn.Size = new System.Drawing.Size(136, 50);
            this.btnXoaDoAn.TabIndex = 29;
            this.btnXoaDoAn.Text = "Xóa";
            this.btnXoaDoAn.UseVisualStyleBackColor = true;
            this.btnXoaDoAn.Click += new System.EventHandler(this.btnXoaDoAn_Click);
            // 
            // btnXemDoAn
            // 
            this.btnXemDoAn.Location = new System.Drawing.Point(159, 397);
            this.btnXemDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemDoAn.Name = "btnXemDoAn";
            this.btnXemDoAn.Size = new System.Drawing.Size(136, 50);
            this.btnXemDoAn.TabIndex = 28;
            this.btnXemDoAn.Text = "Xem";
            this.btnXemDoAn.UseVisualStyleBackColor = true;
            this.btnXemDoAn.Click += new System.EventHandler(this.btnXemDoAn_Click);
            // 
            // btnSuaDoAn
            // 
            this.btnSuaDoAn.Location = new System.Drawing.Point(891, 397);
            this.btnSuaDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaDoAn.Name = "btnSuaDoAn";
            this.btnSuaDoAn.Size = new System.Drawing.Size(136, 50);
            this.btnSuaDoAn.TabIndex = 30;
            this.btnSuaDoAn.Text = "Sửa";
            this.btnSuaDoAn.UseVisualStyleBackColor = true;
            this.btnSuaDoAn.Click += new System.EventHandler(this.btnSuaDoAn_Click);
            // 
            // btnThemDoAn
            // 
            this.btnThemDoAn.Location = new System.Drawing.Point(703, 397);
            this.btnThemDoAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemDoAn.Name = "btnThemDoAn";
            this.btnThemDoAn.Size = new System.Drawing.Size(136, 50);
            this.btnThemDoAn.TabIndex = 31;
            this.btnThemDoAn.Text = "Thêm";
            this.btnThemDoAn.UseVisualStyleBackColor = true;
            this.btnThemDoAn.Click += new System.EventHandler(this.btnThemDoAn_Click);
            // 
            // dgvDoAn
            // 
            this.dgvDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAn.Location = new System.Drawing.Point(4, 514);
            this.dgvDoAn.Name = "dgvDoAn";
            this.dgvDoAn.RowHeadersWidth = 82;
            this.dgvDoAn.RowTemplate.Height = 33;
            this.dgvDoAn.Size = new System.Drawing.Size(1962, 516);
            this.dgvDoAn.TabIndex = 34;
            this.dgvDoAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoAn_CellClick);
            // 
            // DoAnUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDoAn);
            this.Controls.Add(this.btnSearchDoAn);
            this.Controls.Add(this.txtSearchDoAn);
            this.Controls.Add(this.btnXoaDoAn);
            this.Controls.Add(this.btnXemDoAn);
            this.Controls.Add(this.btnSuaDoAn);
            this.Controls.Add(this.btnThemDoAn);
            this.Controls.Add(this.grpCustomer);
            this.Name = "DoAnUC";
            this.Size = new System.Drawing.Size(2321, 1048);
            this.Load += new System.EventHandler(this.DoAnUC_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtSoLuongCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtMaDoAn;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenDoAn;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Button btnSearchDoAn;
        private System.Windows.Forms.TextBox txtSearchDoAn;
        private System.Windows.Forms.Button btnXoaDoAn;
        private System.Windows.Forms.Button btnXemDoAn;
        private System.Windows.Forms.Button btnSuaDoAn;
        private System.Windows.Forms.Button btnThemDoAn;
        private System.Windows.Forms.DataGridView dgvDoAn;
    }
}
