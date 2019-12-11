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
    public partial class FrmKhachHang_ThemMoi : DevExpress.XtraEditors.XtraForm
    {
        ClassProgram cl = new ClassProgram();
        KhachHang_DAL kh = new KhachHang_DAL();

        public FrmKhachHang_ThemMoi()
        {
            InitializeComponent();
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!KTDL())
                return;
            var result = kh.InsertKH(txt_maKhach.Text, txt_tênKH.Text, txt_gioitinh.Text, txt_DiaChi.Text, txt_dienThoai.Text, text_Email.Text, dateTimePicker_ngaysinhKH.Text, txt_Diemtichluybandau.Text, cbo_MaNV.Text, cbo_MaNhomKH.Text, cbo_Matinhthanh.Text, text_Ghichu.Text);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Thêm thông tin khách hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Thêm thông tin khách hàng thất bại"); break;
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
            if (cl.KT(txt_DiaChi.Text) || cl.KT(txt_dienThoai.Text) || cl.KT(txt_gioitinh.Text) ||
                cl.KT(txt_maKhach.Text) || cl.KT(txt_tênKH.Text) || cl.KT(txt_Diemtichluybandau.Text) ||
                 cl.KT(dateTimePicker_ngaysinhKH.Text) || cl.KT(text_Email.Text) || cl.KT(text_Ghichu.Text) ||
                  cl.KT(cbo_MaNhomKH.Text) || cl.KT(cbo_MaNV.Text) || cl.KT(cbo_MaNhomKH.Text) )
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return false;
            }
            return true;
        }

        private void FrmKhachHang_ThemMoi_Load(object sender, EventArgs e)
        {

        }
    }
}