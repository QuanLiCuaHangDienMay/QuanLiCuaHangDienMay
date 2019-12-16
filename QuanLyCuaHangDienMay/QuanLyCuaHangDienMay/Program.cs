using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using QuanLyCuaHangDienMay.Views;

namespace QuanLyCuaHangDienMay
{
    public static class Program
    {
        public static FrmMain Frm_Main = null;
        public static frmDangNhap Frm_DangNhap = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Frm_DangNhap = new frmDangNhap();

           Application.Run(new frm_danhSachHoaDon());
            //Application.Run(Frm_Main);

        }
    }
}
