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
    public partial class FrmPhanQuyen : Form
    {
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }

        private void quanLiNhomTaiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quanLiNhomTaiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlCuaHangDienMay);

        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlCuaHangDienMay.QuanLiManHinh' table. You can move, or remove it, as needed.
            this.quanLiManHinhTableAdapter.Fill(this.qlCuaHangDienMay.QuanLiManHinh);
            // TODO: This line of code loads data into the 'qlCuaHangDienMay.QuanLiNhomTaiKhoan' table. You can move, or remove it, as needed.
            this.quanLiNhomTaiKhoanTableAdapter.Fill(this.qlCuaHangDienMay.QuanLiNhomTaiKhoan);

        }
    }
}
