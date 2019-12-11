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
using QuanLyCuaHangDienMay;
using BLL;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_MatHang_SuaMatHang : DevExpress.XtraEditors.XtraForm
    {
        MatHang_BLL mathang = new MatHang_BLL();
        LoaiMatHang_BLL lmh = new LoaiMatHang_BLL();
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();

        string LH, MNCC;
        public frm_MatHang_SuaMatHang(string mh,string th, string lh,string DVT, string gb, string gn, string mncc, string tgbh)
        {
            InitializeComponent();
            txt_maHang.Text = mh; 
            txt_tenHang.Text = th;
            txt_tgBaoHanh.Text = tgbh;
            txt_giaBan.Text = gb;
            txt_giaNhap.Text = gn;
            LH = lh;
            MNCC = mncc;           
        }

        private void loadDVT()
        {
            cb_DVT.DataSource = null;
            string[] dvts = { "Cái", "Chiếc", "Bộ" };
            foreach (string dvt in dvts)
            {
                cb_DVT.Items.Add(dvt);
            }
        }

        void loadCB()
        {
            loadDVT();
            cb_DVT.SelectedIndex = 0;
        }

        private void frm_MatHang_ThemMatHang_Load(object sender, EventArgs e)
        {
            cb_LMH.DataSource = null;
            cb_LMH.Items.Clear();
            cb_LMH.DataSource = lmh.GetLoaiMatHang();
            cb_LMH.ValueMember = "MaLoaiMatHang";
            cb_LMH.DisplayMember = "TenLoaiMatHang";
            cb_NCC.DataSource = null;
            cb_NCC.Items.Clear();
            cb_NCC.DataSource = ncc.GetNhaCungCap();
            cb_NCC.ValueMember = "MaNhaCC";
            cb_NCC.DisplayMember = "TenNhaCC";          
            txt_maHang.Enabled = false;
            loadCB();
        }

        bool kTraNullCB()
        {
            if (string.IsNullOrEmpty(cb_DVT.Text) || string.IsNullOrEmpty(cb_LMH.Text) || string.IsNullOrEmpty(cb_NCC.Text) ||
                string.IsNullOrEmpty(txt_maHang.Text) || string.IsNullOrEmpty(txt_giaNhap.Text) || string.IsNullOrEmpty(txt_giaBan.Text) || string.IsNullOrEmpty(txt_tenHang.Text)
                || string.IsNullOrEmpty(txt_tgBaoHanh.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_thoat(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
      
        private void btn_luu1(object sender, ItemClickEventArgs e)
        {
            if (kTraNullCB())
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            string maHang = txt_maHang.Text;
            var result = mathang.UpdateMatHang(txt_maHang.Text, txt_tenHang.Text, cb_LMH.SelectedValue.ToString(), cb_DVT.Text.ToString(),
                    decimal.Parse(txt_giaBan.Text.ToString()), decimal.Parse(txt_giaNhap.Text.ToString()), cb_NCC.SelectedValue.ToString(),
                    byte.Parse(txt_tgBaoHanh.Text.ToString()));
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Sửa thông tin mặt hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Sửa thông tin mặt hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên hàng đã tồn tại"); break;
            }
            if (result == DAL.Result.SUCCESS)
                this.Close();

        }

        private void matHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.matHangBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.qLCuaHangDienMay);

        }

        private void txt_giaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tgBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            txt_giaNhap.Text = txt_giaBan.Text = txt_tenHang.Text = txt_tgBaoHanh.Text = "";
        }

        private void loaiMatHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.loaiMatHangBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.qlCuaHangDienMay);

        }
    }
}