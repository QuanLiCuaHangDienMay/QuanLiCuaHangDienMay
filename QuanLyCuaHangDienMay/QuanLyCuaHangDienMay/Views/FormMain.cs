using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyCuaHangDienMay.Views;

namespace QuanLyCuaHangDienMay
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Springtime";
        }

      
        private void FormMain_Load(object sender, EventArgs e)
        {
            skins();
        }

      

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_NhaCungCap frm = new frm_NhaCungCap();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDoiMatKhau frmDMK = new FrmDoiMatKhau();
            
            frmDMK.ShowDialog();
        }

     
        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn đã đăng nhập.");

        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
            this.Hide();
          
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_MatHang frm = new frm_MatHang();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_HoaDon frm = new frm_HoaDon();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_KhachHang frm= new frm_KhachHang();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmNhanVien frm = new FrmNhanVien();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_PhieuNhap frm = new frm_PhieuNhap();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_danhSachHoaDon frm = new frm_danhSachHoaDon();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            frm_Kho frm = new frm_Kho();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
            frm.Show();
        }
    }
}