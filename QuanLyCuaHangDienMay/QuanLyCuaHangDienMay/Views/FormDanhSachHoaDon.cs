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
using BLL;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_danhSachHoaDon : DevExpress.XtraEditors.XtraForm
    {
        HoaDon_BLL hd = new HoaDon_BLL();
        ChiTietHoaDon_BLL cthd = new ChiTietHoaDon_BLL();
        ChiTietKho_BLL ctk = new ChiTietKho_BLL();

        public frm_danhSachHoaDon()
        {
            InitializeComponent();
        }

        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            refress();
            btn_del.Enabled = false;
        }

        private void refress()          
        {
            dgv_hoaDon.DataSource=hd.GetHD();  
  
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát danh sách hóa đơn", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

        private void gc_MatHang_Click(object sender, EventArgs e)
        {

        }

        private void dgv_hoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            try
            {
                dgv_cthd2.DataSource = cthd.getcthd(dgv_hoaDon.CurrentRow.Cells["MaHD"].Value.ToString());
                btn_del.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void btn_del_ItemClick(object sender, ItemClickEventArgs e)
        {
            for (int i = 0; i < dgv_cthd2.Rows.Count - 1; i++)
            {
                cthd.DeleteChiTietHoaDon(dgv_cthd2.Rows[i].Cells["MaHD"].Value.ToString(), dgv_cthd2.Rows[i].Cells["MaHang"].Value.ToString());
            }
            for (int i = 0; i < dgv_cthd2.Rows.Count - 1; i++)
            {
                ctk.updateSoluonCong(dgv_cthd2.Rows[i].Cells["MaHD"].Value.ToString(), int.Parse(dgv_cthd2.Rows[i].Cells["SoLuong"].Value.ToString()));
            }
            hd.DeleteHoaDon(dgv_hoaDon.CurrentRow.Cells["MaHD"].Value.ToString());
            refress();
        }  

    }
}