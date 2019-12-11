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
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVien_BLL nv = new NhanVien_BLL();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            refress();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát quản lí Nhân Viên", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

        private void btn_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNhanVien_ThemMoi frm = new FrmNhanVien_ThemMoi();
            frm.ShowDialog();
            refress();
        }

        private void btn_sua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maNV = gridView1.GetFocusedRowCellValue("MaNV").ToString();
            var tenNV = gridView1.GetFocusedRowCellValue("TenNV").ToString();
            var maCV = gridView1.GetFocusedRowCellValue("MaCV").ToString();
            var diachiNV = gridView1.GetFocusedRowCellValue("DiaChiNV").ToString();
            var dienthoai = gridView1.GetFocusedRowCellValue("DienThoaiNV").ToString();
            var gioitinh = gridView1.GetFocusedRowCellValue("GioiTinhNV").ToString();
            var ngayvaolam = gridView1.GetFocusedRowCellValue("NgayVaoLam").ToString();

            FrmNhanVien_Sua frm = new FrmNhanVien_Sua(maNV, tenNV, maCV, diachiNV, dienthoai, gioitinh, DateTime.Parse( ngayvaolam));
            frm.ShowDialog();
            refress();
        }

        private void refress()
        {
            gridControl1.DataSource = nv.GetNhanViens();
        }

        private void btn_xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa nhân viên", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var maNV = gridView1.GetFocusedRowCellValue("MaNV").ToString();

            var result = nv.DeleteNhanVien(maNV);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Xóa nhân viên thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Xóa nhân viên thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã nhân viên đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên nhân viên đã tồn tai"); break;
            }
            refress();
        }
    }
}
