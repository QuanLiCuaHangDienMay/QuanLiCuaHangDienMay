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
    public partial class FrmNhanVien_Sua : DevExpress.XtraEditors.XtraForm
    {
        ClassProgram cl = new ClassProgram();
        NhanVien_DAL nv = new NhanVien_DAL();

        public FrmNhanVien_Sua(string MaNV, string TenNV, string MaCV, string DiaChiNV, string DienThoaiNV, string GioiTinhNV, DateTime NgayVaoLam)
        {
            InitializeComponent();
            txt_MaNV.Text = MaNV;
            txt_tenNV.Text = TenNV;
            cbo_MaCV.Text = MaCV;
            txt_DiaChi.Text = DiaChiNV;
            txt_DienThoai.Text = DienThoaiNV;
            cbo_GioiTinh.Text = GioiTinhNV;
            datetimepick_NgayVaoLam.Text = DateTime.Parse(NgayVaoLam.ToString()).ToString();
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!KTDL())
                return;
            var result = nv.UpdateNV(txt_MaNV.Text, txt_tenNV.Text, cbo_MaCV.Text, txt_DiaChi.Text, txt_DienThoai.Text, cbo_GioiTinh.Text, datetimepick_NgayVaoLam.Text);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Sửa thông tin nhân viên thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Sửa thông tin nhân viên thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã nhân viên đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên nhân viên đã tồn tai"); break;
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
            if (cl.KT(txt_MaNV.Text) || cl.KT(txt_tenNV.Text) || cl.KT(cbo_MaCV.Text) ||
                cl.KT(txt_DiaChi.Text) || cl.KT(txt_DienThoai.Text) || cl.KT(cbo_GioiTinh.Text) || cl.KT(datetimepick_NgayVaoLam.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return false;
            }
            return true;
        }

    }
}
