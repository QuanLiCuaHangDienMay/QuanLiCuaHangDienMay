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
    public partial class frm_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHang_BLL kh = new KhachHang_BLL();

        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            refress();
        }

        private void btn_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKhachHang_ThemMoi frm = new FrmKhachHang_ThemMoi();
            frm.ShowDialog();
            refress();
        }

        private void btn_sua_ItemClick(object sender, ItemClickEventArgs e)
        {

            var maKH = gridView1.GetFocusedRowCellValue("MaKH").ToString();
            var tenKH = gridView1.GetFocusedRowCellValue("TenKH").ToString();
            var gioitinhKH = gridView1.GetFocusedRowCellValue("GioiTinhKH").ToString();
            var diachiKH = gridView1.GetFocusedRowCellValue("DiaChiKH").ToString();
            var dienthoaiKH = gridView1.GetFocusedRowCellValue("DienThoaiKH").ToString();
            var emailKH = gridView1.GetFocusedRowCellValue("EmailKH").ToString();
            var ngaysinhKH = gridView1.GetFocusedRowCellValue("NgaySinhKH").ToString();
            var diemtichluybandau = gridView1.GetFocusedRowCellValue("DiemTichLuyBanDau").ToString();
            var maNV = gridView1.GetFocusedRowCellValue("MaNV").ToString();
            var manhomKH = gridView1.GetFocusedRowCellValue("MaNhomKH").ToString();
            var matinhthanh = gridView1.GetFocusedRowCellValue("MaTinhThanh").ToString();
            var ghichu = gridView1.GetFocusedRowCellValue("GhiChu").ToString();


            FrmKhachHang_Sua frm = new FrmKhachHang_Sua(maKH, tenKH, gioitinhKH, diachiKH, dienthoaiKH, emailKH, ngaysinhKH, diemtichluybandau, maNV, manhomKH, matinhthanh, ghichu);
            frm.ShowDialog();
            refress();
        }

        private void refress()
        {
            gridControl1.DataSource = kh.GetKhachHangs();
        }

        private void btn_xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa khách hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var maKH = gridView1.GetFocusedRowCellValue("MaKH").ToString();

            var result = kh.DeleteKhachHang(maKH);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Xóa khách hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Xóa khách hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã khách hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên khách hàng đã tồn tai"); break;
            }
            refress();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát quản lí khách hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

       
    }
}
