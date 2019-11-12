using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienMay
{
    public partial class FrmThemNguoiDungVaoNhom : Form
    {
        public FrmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void quanLiTaiKhoan_NhomTaiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quanLiTaiKhoan_NhomTaiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlCuaHangDienMay);

        }

        private void FrmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlCuaHangDienMay.QuanLiTaiKhoan_NhomTaiKhoan' table. You can move, or remove it, as needed.
            this.quanLiTaiKhoan_NhomTaiKhoanTableAdapter.Fill(this.qlCuaHangDienMay.QuanLiTaiKhoan_NhomTaiKhoan);

        }
    }
}
