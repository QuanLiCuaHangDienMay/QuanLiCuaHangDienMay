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
using BLL;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_danhSachHoaDon : DevExpress.XtraEditors.XtraForm
    {
        HoaDon_BLL hd = new HoaDon_BLL();

        public frm_danhSachHoaDon()
        {
            InitializeComponent();
        }

        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            refress();
        }

        private void refress()          
        {
            gc_MatHang.DataSource = hd.GetHoaDon();       
        }

        //private void btn_del_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa mặt hàng", MessageBoxButtons.YesNo) == DialogResult.No)
        //        return;

        //    var maHang = gridView1.GetFocusedRowCellValue("MaHang").ToString();
            
        //    var result = mathang.DeleteMatHang(maHang);
        //    switch (result)
        //    {
        //        case DAL.Result.SUCCESS: MessageBox.Show("Xóa mặt hàng thành công"); break;
        //        case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
        //        case DAL.Result.FAILED: MessageBox.Show("Xóa mặt hàng thất bại"); break;
        //        case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã hàng đã tồn tại"); break;
        //        case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên hàng đã tồn tai"); break;
        //    }
        //    refress();
        //}

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát quản lí mặt hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

        private void gc_MatHang_Click(object sender, EventArgs e)
        {

        }  

        //private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var maMH = gridView1.GetFocusedRowCellValue("MaHang").ToString();
        //    var tenMH = gridView1.GetFocusedRowCellValue("TenMatHang").ToString();
        //    var DVT = gridView1.GetFocusedRowCellValue("DVT").ToString();
        //    var maLoaiMH = gridView1.GetFocusedRowCellValue("MaLoaiMatHang").ToString();
        //    var giaban = gridView1.GetFocusedRowCellValue("GiaBan").ToString();
        //    var gianhap = gridView1.GetFocusedRowCellValue("GiaNhap").ToString();
        //    var maNCC = gridView1.GetFocusedRowCellValue("MaNhaCC").ToString();
        //    var tgBH = gridView1.GetFocusedRowCellValue("BaoHanh").ToString();
        //    frm_MatHang_SuaMatHang frm = new frm_MatHang_SuaMatHang(maMH, tenMH, maLoaiMH, DVT, giaban, gianhap, maNCC, tgBH);
        //    frm.ShowDialog();
        //    refress();
        //}

        //private void bn_insert_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frm_MatHang_ThemMatHang frm = new frm_MatHang_ThemMatHang();
        //    frm.ShowDialog();
        //    refress();
        //}  
    }
}