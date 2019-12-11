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
using DAL;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class FrmKhachHang_Sua : DevExpress.XtraEditors.XtraForm
    {
        ClassProgram cl = new ClassProgram();
        KhachHang_DAL kh = new KhachHang_DAL();

        public FrmKhachHang_Sua(string MaKH, string TenKH, string GioiTinhKH, string DiaChiKH, string DienThoaiKH, string EmailKH, string NgaySinhKH, string DiemTichLuyBanDau, string MaNV, string MaNhomKH, string MaTinhThanh, string GhiChu)
        {
            InitializeComponent();
            txt_diachi.Text = DiaChiKH;
            txt_dienthoai.Text = DienThoaiKH;
            txt_Email.Text = EmailKH;
            text_Ghichu.Text = GhiChu;
            txt_gioitinh.Text = GioiTinhKH;
            txt_maKH.Text = MaKH;
            cbo_MaNhomKH.Text = MaNhomKH;
            cbo_MaNV.Text = MaNV;
            cbo_Matinhthanh.Text = MaTinhThanh;
            txt_tenKH.Text = TenKH;
            txt_DTLBD.Text = DiemTichLuyBanDau;
            dateTimePicker_ngaysinhKH.Text = NgaySinhKH;
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!KTDL())
                return;
            var result = kh.UpdateKh(txt_diachi.Text, txt_dienthoai.Text, txt_Email.Text, text_Ghichu.Text, txt_gioitinh.Text, txt_maKH.Text, cbo_MaNhomKH.Text, cbo_Matinhthanh.Text,cbo_MaNV.Text, txt_tenKH.Text, txt_DTLBD.Text, dateTimePicker_ngaysinhKH.Text);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Sửa thông tin khách hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Sửa thông tin khách hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã khách hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên khách hàng đã tồn tai"); break;
            }
            if (result == DAL.Result.SUCCESS)
                this.Close();

        }

        private void btn_thoat_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //txt_maNCC.Text=txt_tenNCC.Text=txt_SDT.Text=
        }

        private bool KTDL()
        {
            if (cl.KT(txt_diachi.Text) || cl.KT(txt_dienthoai.Text) || cl.KT(txt_Email.Text) ||
                cl.KT(text_Ghichu.Text) || cl.KT(txt_gioitinh.Text) || cl.KT(txt_maKH.Text) ||
                 cl.KT(cbo_MaNhomKH.Text) || cl.KT(cbo_MaNV.Text) || cl.KT(cbo_Matinhthanh.Text) ||
                  cl.KT(txt_tenKH.Text) || cl.KT(txt_DTLBD.Text) || cl.KT(dateTimePicker_ngaysinhKH.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return false;
            }
            return true;
        }
    }
}