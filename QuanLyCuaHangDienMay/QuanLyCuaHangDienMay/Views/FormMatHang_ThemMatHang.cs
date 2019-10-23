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

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_MatHang_ThemMatHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_MatHang_ThemMatHang()
        {
            InitializeComponent();
        }

        //private void loadNCC()
        //{
        //    cb_NCC.DataSource = null;
        //    string str = "select * from NhaCungCap";
        //    DataTable data = KetNoi.Instance.excuteQuery(str);
        //    cb_NCC.DataSource = data;
        //    cb_NCC.DisplayMember = "TenNhaCC";
        //    cb_NCC.ValueMember = "MaNhaCC";
        //}

        //private void loadDVT()
        //{
        //    cb_DVT.DataSource = null;
        //    string[] dvts = { "Cái", "Chiếc", "Bộ" };
        //    foreach (string dvt in dvts)
        //    {
        //        cb_DVT.Items.Add(dvt);
        //    }
        //}

        //private void loadLMH()
        //{
        //    cb_LMH.DataSource = null;
        //    string str = "select * from LoaiMatHang";
        //    DataTable data = KetNoi.Instance.excuteQuery(str);
        //    cb_LMH.DataSource = data;
        //    cb_LMH.DisplayMember = "TenLoaiMatHang";
        //    cb_LMH.ValueMember = "MaLoaiMatHang";          
        //}

        //void loadCB()
        //{
        //    loadDVT();
        //    loadNCC();
        //    loadLMH();
        //    cb_DVT.SelectedIndex = 0;
        //}

        private void frm_MatHang_ThemMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCuaHangDienMay.MatHang' table. You can move, or remove it, as needed.
            //this.matHangTableAdapter.Fill(this.qLCuaHangDienMay.MatHang);
            //loadCB();
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
            if (kTraNullCB() == false)
            {
                string str = "INSERT INTO MatHang VALUES ('" +
                            txt_maHang.Text + "',N'" + txt_tenHang.Text + "',N'" + cb_LMH.SelectedValue.ToString() + "',N'" +
                            cb_DVT.Text + "','" + txt_giaBan.Text + "','" + txt_giaNhap.Text + "','" + cb_NCC.SelectedValue.ToString() + "','" +
                            txt_tgBaoHanh.Text + "',N'" + "Chưa nhập hàng" + "') ";//=====================================================
                KetNoi.Instance.excuteQuery(str);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        
    }
}