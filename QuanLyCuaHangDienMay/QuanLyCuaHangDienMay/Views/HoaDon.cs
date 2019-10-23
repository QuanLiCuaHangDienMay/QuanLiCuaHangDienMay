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
    public partial class frm_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void DonDatHang2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlCuaHangDienMay.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qlCuaHangDienMay.HoaDon);
            // TODO: This line of code loads data into the 'qLCuaHangDienMay.ChiTietHoaDon' table. You can move, or remove it, as needed.
            //this.chiTietHoaDonTableAdapter.Fill(this.qLCuaHangDienMay.ChiTietHoaDon);
            //// TODO: This line of code loads data into the 'qLCuaHangDienMay.MatHang' table. You can move, or remove it, as needed.
            //this.matHangTableAdapter.Fill(this.qLCuaHangDienMay.MatHang);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}