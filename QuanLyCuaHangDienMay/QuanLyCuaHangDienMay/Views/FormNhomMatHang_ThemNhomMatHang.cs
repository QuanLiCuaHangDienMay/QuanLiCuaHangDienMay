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
using QuanLyCuaHangDienMay.Class;


namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_NhomMatHang_ThemNhomMatHang : DevExpress.XtraEditors.XtraForm
    {
        ClassProgram cl = new ClassProgram();

        public frm_NhomMatHang_ThemNhomMatHang()
        {
            InitializeComponent();     
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ktraDL() == false)
                return;
        }

        private bool ktraDL()
        {
            if (cl.KT(txt_maNhomMH.Text))
            {
                MessageBox.Show("Chưa nhập mã loại hàng");
                return false;
            }
            if (cl.KT(txt_tenNhomMH.Text))
            {
                MessageBox.Show("Chưa nhập tên loại hàng");
                return false;
            }
            return true;
        }
      
    }
}