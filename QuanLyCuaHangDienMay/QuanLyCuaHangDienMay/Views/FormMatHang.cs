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
    public partial class frm_MatHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_MatHang()
        {
            InitializeComponent();
        }

        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            
           

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MatHang_ThemMatHang frm=new frm_MatHang_ThemMatHang();           
            frm.ShowDialog();       
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.BeginUpdate();
            gridControl1.RefreshDataSource();
            //this.mH_LMH_NCCTableAdapter.MatHang_NCC_LoaiMH(this.qLCuaHangDienMay.MH_LMH_NCC);
            gridControl1.EndUpdate();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MatHang_SuaMatHang frm = new frm_MatHang_SuaMatHang();
            frm.ShowDialog();
        }
    }
}