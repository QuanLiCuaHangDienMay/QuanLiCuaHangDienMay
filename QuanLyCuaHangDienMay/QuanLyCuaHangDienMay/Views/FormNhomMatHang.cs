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
    public partial class frm_NhomMatHang : DevExpress.XtraEditors.XtraForm
    {
        LoaiMatHang_BLL lmh = new LoaiMatHang_BLL();
        //MatHang_BLL mh = new MatHang_BLL();

        public frm_NhomMatHang()
        {
            InitializeComponent();
        }

        private void frm_NhomMatHang_Load(object sender, EventArgs e)
        {
            gc_loaiMH.DataSource = lmh.GetLoaiMatHang();
            //gc_loaiMH.DataSource = mh.GetMatHang();
        }

        private void btn_insert_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhomMatHang_ThemNhomMatHang frm = new frm_NhomMatHang_ThemNhomMatHang();
            frm.ShowDialog();
            refress();
        }


        private void refress()
        {
            gc_loaiMH.DataSource = lmh.GetLoaiMatHang();
            //gc_loaiMH.DataSource = mh.GetMatHang();
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            string maNhomMH = gridView1.GetFocusedRowCellValue("MaLoaiMatHang").ToString();
            string tenNhomMH = gridView1.GetFocusedRowCellValue("TenLoaiMatHang").ToString();
            frm_NhomMatHang_SuaNhomMatHang frm = new frm_NhomMatHang_SuaNhomMatHang(maNhomMH,tenNhomMH);
            frm.ShowDialog();
            refress();
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_del_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ban muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var maLoaiMatHang = gridView1.GetFocusedRowCellValue("MaLoaiMatHang").ToString();
            var result = lmh.DeleteLoaiMatHang(maLoaiMatHang);

            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Xóa loại mặt hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Xóa loại mặt hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã loại hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên loại hàng đã tồn tai"); break;
            }
            refress();
        }

        
    }
}