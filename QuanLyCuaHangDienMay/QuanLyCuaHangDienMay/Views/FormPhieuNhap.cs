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
using DevExpress.XtraGrid.Views.Grid;
using BLL;
using DAL;

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_PhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        MatHang_BLL mh = new MatHang_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        ChiTietKho_BLL ctkh = new ChiTietKho_BLL();
        PhieuNhap_DAL pn = new PhieuNhap_DAL();
        ChiTietPhieuNhap_DAL ctpn = new ChiTietPhieuNhap_DAL();
        public decimal thanhTien = 0;

        public String myMessage;
        public static string sl;

        public frm_PhieuNhap()
        {
            InitializeComponent();
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

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            load();
            nghiepvu();
            cb_NV.DataSource = null;
            cb_NV.Items.Clear();
            cb_NV.DataSource = nv.GetNhanViens();
            cb_NV.ValueMember = "MaNV";
            cb_NV.DisplayMember = "TenNV";
        }

        private void load()
        {
           gc_mh.DataSource = mh.GetMatHang();
        }

        private void btn_moDatHang_Click(object sender, EventArgs e)
        {
            gc_mh.Enabled=layoutControlGroup3.Enabled = true;
        }

        private void nghiepvu()
        {
            dgv_cthd.Enabled=gc_mh.Enabled=btn_Xoa.Enabled = layoutControlGroup3.Enabled = btn_moHDMoi.Enabled = false;
            
        }

        private void gc_mh_Click(object sender, EventArgs e)
        {
            
            //refress();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát quản lí mặt hàng", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }

        private void themChiTiet(string MaHang,string tenHang,string soLuong,string donGia)
        {
            decimal thanhtien=decimal.Parse(soLuong)*decimal.Parse(donGia);

            DataGridViewRow row = (DataGridViewRow)dgv_cthd.Rows[0].Clone();
            row.Cells[0].Value = MaHang;
            row.Cells[1].Value = tenHang;
            row.Cells[2].Value = soLuong;
            row.Cells[3].Value = donGia;
            row.Cells[4].Value = thanhtien;
            dgv_cthd.Rows.Add(row); 

        }

        internal void capNhatDuLieu()
        {
            sl = null;
            sl= myMessage;
        }
      
        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var tenMH = gridView2.GetFocusedRowCellValue("TenMatHang").ToString();
            var giaBan = gridView2.GetFocusedRowCellValue("GiaNhap").ToString();
            var maMH = gridView2.GetFocusedRowCellValue("MaHang").ToString();
            var donGia = gridView2.GetFocusedRowCellValue("GiaBan").ToString();
            frm_PhieuNhap_NhapSoLuong frm = new frm_PhieuNhap_NhapSoLuong(tenMH, giaBan, this);
            frm.ShowDialog();
            if (sl == null)
                return;
            //var rs = ctkh.KiemTraSoLuong(maMH, sl);
            //if (rs == DAL.Result.KEY_NOT_FOUND)
            //{
            //    MessageBox.Show("Chưa nhập hàng về kho");
            //    return;
            //}
            //if (rs == DAL.Result.OUT_OF_STOCK)
            //{
            //    int slhang = ctkh.laySoLuong(maMH, sl);
            //    //var solg = ctkh.GetChiTietKhoByCondition(maMH);
            //    //DataGridView a = new DataGridView();
            //    //a.DataSource = solg;
            //    //int solg1 = Convert.ToInt32(a["_SoLuong", 2].Value);
            //    MessageBox.Show("Không đủ hàng trong kho " + slhang);
            //    return;
            //}
            if (KtraGV(maMH) == false)
            {
                MessageBox.Show("Mặt hàng đã có trong giỏ");
                return;
            }
            themChiTiet(maMH, tenMH, sl, donGia);       
            thanhTien += decimal.Parse(donGia) * decimal.Parse(sl);
            txt_tienhang.Text = thanhTien.ToString();
        }

        private void dgv_cthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Enabled = true;
            dgv_cthd.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_cthd_Validated(object sender, EventArgs e)
        {
            //btn_Xoa.Enabled = false;
        }

        private bool KtraGV(string mahang)
        {
            try
            {
                for (int i = 0; i < dgv_cthd.Rows.Count; i++)
                {
                    string ma = dgv_cthd.Rows[i].Cells[0].Value.ToString();
                    if (ma == mahang)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            string a = "";
            try
            {
                a = dgv_cthd.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
                a = "";
            }

            if (string.IsNullOrEmpty(a))
            {
                MessageBox.Show("Không có hàng trong giỏ");
                return;
            }
            luu();

        }

        private bool kTraNullCB()
        {
            if (string.IsNullOrEmpty(txt_maDon.Text) || string.IsNullOrEmpty(dateEdit1.Text) )              
            {
                return true;
            }
            return false;
        }

        private void luu()
        {
            if (kTraNullCB())
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            var result = pn.InsertPN(txt_maDon.Text,cb_NV.SelectedValue.ToString(),dateEdit1.Text.ToString(),txt_ggc.Text);
            switch (result)
            {
                //case DAL.Result.SUCCESS: MessageBox.Show("Thêm thông tin mặt hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Thêm thông tin mặt hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên hàng đã tồn tai"); break;
            }
            if (result == DAL.Result.SUCCESS)
            {
                for (int i = 0; i < dgv_cthd.Rows.Count-1; i++)
                {
                    result = ctpn.InsertCTHD(txt_maDon.Text, dgv_cthd.Rows[i].Cells[0].Value.ToString(),dgv_cthd.Rows[i].Cells[3].Value.ToString(), dgv_cthd.Rows[i].Cells[2].Value.ToString());
                    if (result == DAL.Result.SUCCESS)
                    {
                       ctkh.updateSoluongThem(dgv_cthd.Rows[i].Cells[0].Value.ToString(), dgv_cthd.Rows[i].Cells[2].Value.ToString());

                    }
                }
            }
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Thêm thông tin mặt hàng thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Thêm thông tin mặt hàng thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã hàng đã tồn tại"); break;
                case DAL.Result.UNIQUE_NAME: MessageBox.Show("Tên hàng đã tồn tai"); break;
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string a;
            try
            {
                a=dgv_cthd.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                a="";
            }
            if (string.IsNullOrEmpty(a)==false)
            {
                thanhTien -= decimal.Parse(dgv_cthd.CurrentRow.Cells[3].Value.ToString()) * decimal.Parse(dgv_cthd.CurrentRow.Cells[2].Value.ToString());
                txt_tienhang.Text = thanhTien.ToString();
                dgv_cthd.Rows.RemoveAt(this.dgv_cthd.CurrentRow.Index);
            }
            
        }

        private void btn_moHDMoi_Click(object sender, EventArgs e)
        {

        }

        

    }
}