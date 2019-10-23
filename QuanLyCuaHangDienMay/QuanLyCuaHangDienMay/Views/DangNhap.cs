using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        CauHinh cauhinh = new CauHinh();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            {
                if (txtnameDN.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập tài khoản và mật khẩu vui lòng nhập!");
                }
                else
                {
                    if (txtnameDN.Text.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập tài khoản, vui lòng nhập!");
                    }
                    else
                    {
                        if (txtMatKhau.Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập mật khẩu, vui lòng nhập!");
                        }
                        else
                        {                            
                            if (cauhinh.Check_Config() == 0)
                            {
                                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
                            }
                            if (cauhinh.Check_Config() == 1)
                            {
                                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                                ProcessConfig();
                            }
                            if (cauhinh.Check_Config() == 2)
                            {
                                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                                ProcessConfig();
                            }

                            //luu tai khoan mat khau
                            if (chkGhiNhoTK.Checked)
                            {
                                Properties.Settings.Default.user = txtnameDN.Text;
                                Properties.Settings.Default.pass = txtMatKhau.Text;
                            }
                        }

                    }
                }
            }
        }

        public void ProcessLogin()
        {
            int result;
            result = cauhinh.Check_User(txtnameDN.Text, txtMatKhau.Text);
            // Wrong username or pass
            if (result == 0)
            {
                MessageBox.Show("Sai " + txtnameDN.Text + " Hoặc " + txtMatKhau.Text);
                return;
            }
            // Account had been disabled
            else if (result == -1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.Frm_Main == null || Program.Frm_Main.IsDisposed)
            {
                Program.Frm_Main = new FrmMain();
            }
            this.Visible = false;
            Program.Frm_Main.Show();
        }
        
        //sai chuoi cau hinh, xuy chuoi
        public void ProcessConfig()
        {
            this.Hide();
            this.Show();
            FrmKetNoiCSDL frm = new FrmKetNoiCSDL();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}