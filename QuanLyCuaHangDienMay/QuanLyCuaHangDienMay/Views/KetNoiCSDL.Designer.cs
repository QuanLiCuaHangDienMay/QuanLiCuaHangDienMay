namespace QuanLyCuaHangDienMay
{
    partial class FrmKetNoiCSDL
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Servername = new System.Windows.Forms.ComboBox();
            this.cbb_Database = new System.Windows.Forms.ComboBox();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(191, 114);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(281, 20);
            this.txt_Password.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(191, 192);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(135, 37);
            this.btn_Accept.TabIndex = 46;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(191, 77);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(281, 20);
            this.txt_Username.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Server name";
            // 
            // cbb_Servername
            // 
            this.cbb_Servername.FormattingEnabled = true;
            this.cbb_Servername.Location = new System.Drawing.Point(191, 42);
            this.cbb_Servername.Name = "cbb_Servername";
            this.cbb_Servername.Size = new System.Drawing.Size(281, 21);
            this.cbb_Servername.TabIndex = 52;
            this.cbb_Servername.SelectedValueChanged += new System.EventHandler(this.cbb_Servername_SelectedValueChanged);
            this.cbb_Servername.TextChanged += new System.EventHandler(this.cbb_Servername_TextChanged);
            // 
            // cbb_Database
            // 
            this.cbb_Database.FormattingEnabled = true;
            this.cbb_Database.Location = new System.Drawing.Point(191, 148);
            this.cbb_Database.Name = "cbb_Database";
            this.cbb_Database.Size = new System.Drawing.Size(281, 21);
            this.cbb_Database.TabIndex = 53;
            // 
            // btn_Decline
            // 
            this.btn_Decline.Location = new System.Drawing.Point(348, 192);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(124, 37);
            this.btn_Decline.TabIndex = 54;
            this.btn_Decline.Text = "Decline";
            this.btn_Decline.UseVisualStyleBackColor = true;
            this.btn_Decline.Click += new System.EventHandler(this.btn_Decline_Click);
            // 
            // FrmKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.btn_Decline);
            this.Controls.Add(this.cbb_Database);
            this.Controls.Add(this.cbb_Servername);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKetNoiCSDL";
            this.Text = "KetNoiCSDL";
            this.Load += new System.EventHandler(this.FrmKetNoiCSDL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Servername;
        private System.Windows.Forms.ComboBox cbb_Database;
        private System.Windows.Forms.Button btn_Decline;
    }
}