using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_PhieuNhap_NhapSoLuong : DevExpress.XtraEditors.XtraForm
    {
        frm_PhieuNhap formout;
        private bool tam=false;
        public frm_PhieuNhap_NhapSoLuong(string tenhang,string giaban,frm_PhieuNhap formin)
        {
            InitializeComponent();
            lbl_giaHang.Text += giaban;
            lbl_tenHang.Text += tenhang;
            formout = formin;         
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {     
            formout.myMessage = txt_soLuong.Text; 
            formout.capNhatDuLieu();
            tam = true;
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            formout.myMessage = null;
            formout.capNhatDuLieu();   
            this.Close();
        }

        private void frm_HoaDon_NhapSoLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tam == false)
            {
                formout.myMessage = null;
                formout.capNhatDuLieu();
            }
        }
    }
}