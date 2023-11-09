namespace QuanLyRapChieuPhim.UC
{
    partial class GiaVeUC
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
            this.dgvGiaVe = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lblCusID = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_MaGiaVe = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lblCusBirth = new System.Windows.Forms.Label();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GiaVe = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.txt_LoaiVe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaVe
            // 
            this.dgvGiaVe.AllowUserToAddRows = false;
            this.dgvGiaVe.AllowUserToDeleteRows = false;
            this.dgvGiaVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaVe.Location = new System.Drawing.Point(3, 265);
            this.dgvGiaVe.Name = "dgvGiaVe";
            this.dgvGiaVe.ReadOnly = true;
            this.dgvGiaVe.RowHeadersWidth = 82;
            this.dgvGiaVe.RowTemplate.Height = 24;
            this.dgvGiaVe.Size = new System.Drawing.Size(1187, 372);
            this.dgvGiaVe.TabIndex = 36;
            this.dgvGiaVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaVe_CellContentClick);
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCus.Location = new System.Drawing.Point(1070, 125);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(93, 26);
            this.btnSearchCus.TabIndex = 80;
            this.btnSearchCus.Text = "Search";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(621, 159);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 32);
            this.btn_Xoa.TabIndex = 76;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(48, 27);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(92, 23);
            this.lblCusID.TabIndex = 73;
            this.lblCusID.Text = "Mã giá vé";
            this.lblCusID.Click += new System.EventHandler(this.lblCusID_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(491, 161);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 32);
            this.btn_Sua.TabIndex = 77;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_MaGiaVe
            // 
            this.txt_MaGiaVe.Enabled = false;
            this.txt_MaGiaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGiaVe.Location = new System.Drawing.Point(168, 25);
            this.txt_MaGiaVe.Name = "txt_MaGiaVe";
            this.txt_MaGiaVe.Size = new System.Drawing.Size(191, 30);
            this.txt_MaGiaVe.TabIndex = 72;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(359, 160);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 32);
            this.btn_Them.TabIndex = 78;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lblCusBirth
            // 
            this.lblCusBirth.AutoSize = true;
            this.lblCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusBirth.Location = new System.Drawing.Point(48, 84);
            this.lblCusBirth.Name = "lblCusBirth";
            this.lblCusBirth.Size = new System.Drawing.Size(72, 23);
            this.lblCusBirth.TabIndex = 74;
            this.lblCusBirth.Text = "Loại vé";
            this.lblCusBirth.Click += new System.EventHandler(this.lblCusBirth_Click_1);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Location = new System.Drawing.Point(39, 159);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(91, 32);
            this.btnShowCustomer.TabIndex = 75;
            this.btnShowCustomer.Text = "Xem";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Giá vé";
            // 
            // txt_GiaVe
            // 
            this.txt_GiaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaVe.Location = new System.Drawing.Point(611, 27);
            this.txt_GiaVe.Name = "txt_GiaVe";
            this.txt_GiaVe.Size = new System.Drawing.Size(191, 30);
            this.txt_GiaVe.TabIndex = 88;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(857, 123);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(191, 30);
            this.txt_Search.TabIndex = 91;
            // 
            // txt_LoaiVe
            // 
            this.txt_LoaiVe.Enabled = false;
            this.txt_LoaiVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiVe.Location = new System.Drawing.Point(168, 82);
            this.txt_LoaiVe.Name = "txt_LoaiVe";
            this.txt_LoaiVe.Size = new System.Drawing.Size(191, 30);
            this.txt_LoaiVe.TabIndex = 92;
            // 
            // GiaVeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_LoaiVe);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_GiaVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchCus);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_MaGiaVe);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lblCusBirth);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.dgvGiaVe);
            this.Name = "GiaVeUC";
            this.Size = new System.Drawing.Size(1193, 637);
            this.Load += new System.EventHandler(this.GiaVeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGiaVe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txt_MaGiaVe;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lblCusBirth;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_GiaVe;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_LoaiVe;
    }
}
