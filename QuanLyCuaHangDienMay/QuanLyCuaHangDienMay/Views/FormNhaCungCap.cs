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
using BLL;

namespace QuanLyCuaHangDienMay.Views
{
    
    public partial class frm_NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            refress();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát quản lí mặt hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

        private void btn_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhaCungCap_ThemNhaCungCap frm = new frm_NhaCungCap_ThemNhaCungCap();
            frm.ShowDialog();
            refress();
        }

        private void btn_sua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maNCC = gridView1.GetFocusedRowCellValue("MaNhaCC").ToString();
            var tenNCC = gridView1.GetFocusedRowCellValue("TenNhaCC").ToString();
            var diaChiNCC = gridView1.GetFocusedRowCellValue("DiaChiNCC").ToString();
            var dienThoaiNCC = gridView1.GetFocusedRowCellValue("DienThoaiNCC").ToString();
            var emailNCC = gridView1.GetFocusedRowCellValue("EmailNCC").ToString();
            var websiteNCC = gridView1.GetFocusedRowCellValue("websiteNCC").ToString();
            frm_NhaCungCap_SuaNhaCungCap frm = new frm_NhaCungCap_SuaNhaCungCap(maNCC, tenNCC, diaChiNCC, dienThoaiNCC, emailNCC, websiteNCC);
            frm.ShowDialog();
            refress();
        }

        private void refress()
        {
            gc_NCC.DataSource = ncc.GetNhaCungCap();
        }

        private void btn_xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa mặt hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var maNCC = gridView1.GetFocusedRowCellValue("MaNhaCC").ToString();

            var result = ncc.DeleteNhaCungCap(maNCC);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Xóa mặt hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Xóa mặt hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên hàng đã tồn tai"); break;
            }
            refress();
        }
       

    }
}