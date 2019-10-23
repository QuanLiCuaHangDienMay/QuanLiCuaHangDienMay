namespace QuanLyCuaHangDienMay
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKHienTai = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.btnNhapLaiMK = new System.Windows.Forms.Button();
            this.btnNhapMKMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtMKHienTai
            // 
            this.txtMKHienTai.Location = new System.Drawing.Point(258, 106);
            this.txtMKHienTai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKHienTai.Name = "txtMKHienTai";
            this.txtMKHienTai.Size = new System.Drawing.Size(313, 26);
            this.txtMKHienTai.TabIndex = 3;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(258, 194);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(313, 26);
            this.txtMKMoi.TabIndex = 4;
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(258, 269);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(313, 26);
            this.txtNhapLaiMK.TabIndex = 5;
            this.txtNhapLaiMK.Click += new System.EventHandler(this.txtNhapLaiMK_Click);
            // 
            // btnNhapLaiMK
            // 
            this.btnNhapLaiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLaiMK.Image")));
            this.btnNhapLaiMK.Location = new System.Drawing.Point(644, 255);
            this.btnNhapLaiMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapLaiMK.Name = "btnNhapLaiMK";
            this.btnNhapLaiMK.Size = new System.Drawing.Size(56, 57);
            this.btnNhapLaiMK.TabIndex = 7;
            this.btnNhapLaiMK.UseVisualStyleBackColor = true;
            this.btnNhapLaiMK.Click += new System.EventHandler(this.btnNhapLaiMK_Click);
            // 
            // btnNhapMKMoi
            // 
            this.btnNhapMKMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapMKMoi.Image")));
            this.btnNhapMKMoi.Location = new System.Drawing.Point(644, 180);
            this.btnNhapMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapMKMoi.Name = "btnNhapMKMoi";
            this.btnNhapMKMoi.Size = new System.Drawing.Size(56, 57);
            this.btnNhapMKMoi.TabIndex = 6;
            this.btnNhapMKMoi.UseVisualStyleBackColor = true;
            this.btnNhapMKMoi.Click += new System.EventHandler(this.btnNhapMKMoi_Click);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 386);
            this.Controls.Add(this.btnNhapLaiMK);
            this.Controls.Add(this.btnNhapMKMoi);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKHienTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKHienTai;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Button btnNhapMKMoi;
        private System.Windows.Forms.Button btnNhapLaiMK;
    }
}