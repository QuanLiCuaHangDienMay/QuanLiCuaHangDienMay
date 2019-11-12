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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlCuaHangDienMay.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qlCuaHangDienMay.KhachHang);

        }
    }
}
