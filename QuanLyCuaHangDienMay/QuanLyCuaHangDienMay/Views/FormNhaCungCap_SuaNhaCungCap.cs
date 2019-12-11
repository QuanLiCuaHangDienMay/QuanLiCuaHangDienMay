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
    public partial class frm_NhaCungCap_SuaNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        ClassProgram cl = new ClassProgram();
        NhaCungCap_DAL ncc = new NhaCungCap_DAL();

        public frm_NhaCungCap_SuaNhaCungCap(string MaNhaCC, string TenNhaCC, string DiaChiNCC, string DienThoaiNCC, string EmailNCC, string websiteNCC)
        {
            InitializeComponent();
            txt_maNCC.Text = MaNhaCC;
            txt_tenNCC.Text = TenNhaCC;
            txt_diaChi.Text = DiaChiNCC;
            txt_SDT.Text = DienThoaiNCC;
            txt_email.Text = EmailNCC;
            txt_web.Text = websiteNCC;           
        }

        private void btn_luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!KTDL())
                return;
            var result = ncc.UpdateNCC(txt_maNCC.Text,txt_tenNCC.Text,txt_diaChi.Text,txt_SDT.Text,txt_email.Text,txt_web.Text);
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Sửa thông tin nhà cung cấp thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Sửa thông tin nhà cung cấp thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã nhà cung cấp đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên nhà cung cấp đã tồn tai"); break;
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
            if (cl.KT(txt_diaChi.Text) || cl.KT(txt_email.Text) || cl.KT(txt_maNCC.Text) ||
                cl.KT(txt_SDT.Text) || cl.KT(txt_tenNCC.Text)||cl.KT(txt_web.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return false;
            }
            return true;
        }

    }
}