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

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_NhomMatHang_SuaNhomMatHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_NhomMatHang_SuaNhomMatHang(string pMaNhomMH,string pTenNhomMH)
        {
            InitializeComponent();
            txt_maNhomMH.Text = pMaNhomMH;
            txt_tenNhomMH.Text = pTenNhomMH;        
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ktraDL()
        {

        }
      
    }
}