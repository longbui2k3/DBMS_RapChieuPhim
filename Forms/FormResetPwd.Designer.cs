namespace QuanLyRapChieuPhim.Forms
{
    partial class FormResetPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reset Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập mật khẩu cũ";
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauCu.Location = new System.Drawing.Point(34, 146);
            this.txt_MatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(374, 45);
            this.txt_MatKhauCu.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập mật khẩu mới";
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(34, 254);
            this.txt_MatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(374, 45);
            this.txt_MatKhauMoi.TabIndex = 11;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(128, 324);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(174, 54);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // FormResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 401);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MatKhauCu);
            this.Controls.Add(this.label1);
            this.Name = "FormResetPwd";
            this.Text = "Reset Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Button btn_Reset;
    }
}