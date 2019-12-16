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

namespace QuanLyCuaHangDienMay.Views
{
    public partial class frm_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        MatHang_BLL mh = new MatHang_BLL();
        KhachHang_BLL kh = new KhachHang_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        ChiTietKho_BLL ctkh = new ChiTietKho_BLL();
        HoaDon_BLL hd = new HoaDon_BLL();
        ChiTietHoaDon_BLL cthd = new ChiTietHoaDon_BLL();
        public decimal thanhTien = 0;
        public bool KQ = false;

        public String myMessage;
        public static string sl;

        public frm_HoaDon()
        {
            InitializeComponent();
        }

        

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            load();
            nghiepvu();
            cb_KH.DataSource = null;
            cb_KH.Items.Clear();
            cb_KH.DataSource = kh.GetKhachHangs();
            cb_KH.ValueMember = "MaKH";
            cb_KH.DisplayMember = "TenKH";
            cb_NV.DataSource = null;
            cb_NV.Items.Clear();
            cb_NV.DataSource = nv.GetNhanViens();
            cb_NV.ValueMember = "MaNV";
            cb_NV.DisplayMember = "TenNV";
        }

        private void load()
        {
            if(KQ==true)
                 updateSLMH();
           gc_mh.DataSource = mh.GetMatHang();
           KQ = false;
           txt_maDon.Text = txt_tienhang.Text = txt_giamGia.Text = txt_tongcong.Text = "";
           dgv_cthd.Enabled = false;
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
            try
            {
                decimal thanhtien = decimal.Parse(soLuong) * decimal.Parse(donGia);

                DataGridViewRow row = (DataGridViewRow)dgv_cthd.Rows[0].Clone();
                row.Cells[0].Value = MaHang;
                row.Cells[1].Value = tenHang;
                row.Cells[2].Value = soLuong;
                row.Cells[3].Value = donGia;
                row.Cells[4].Value = thanhtien;
                dgv_cthd.Rows.Add(row);
            }
            catch
            {
                return;
            }

        }

        internal void capNhatDuLieu()
        {
            sl = null;
            sl= myMessage;
        }
      
        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var tenMH = gridView2.GetFocusedRowCellValue("TenMatHang").ToString();
            var giaBan = gridView2.GetFocusedRowCellValue("GiaBan").ToString();
            var maMH = gridView2.GetFocusedRowCellValue("MaHang").ToString();
            var donGia = gridView2.GetFocusedRowCellValue("GiaBan").ToString();
            frm_HoaDon_NhapSoLuong frm = new frm_HoaDon_NhapSoLuong(tenMH, giaBan, this);
            frm.ShowDialog();
            if (sl == null)
                return;
            var rs = ctkh.KiemTraSoLuong(maMH, sl);
            if (rs == DAL.Result.KEY_NOT_FOUND)
            {
                MessageBox.Show("Chưa nhập hàng về kho");
                return;
            }
            if (rs == DAL.Result.OUT_OF_STOCK)
            {
                int slhang = ctkh.laySoLuong(maMH, sl);
                //var solg = ctkh.GetChiTietKhoByCondition(maMH);
                //DataGridView a = new DataGridView();
                //a.DataSource = solg;
                //int solg1 = Convert.ToInt32(a["_SoLuong", 2].Value);
                MessageBox.Show("Không đủ hàng trong kho " + slhang);
                return;
            }
            if (KtraGV(maMH) == false)
            {
                MessageBox.Show("Mặt hàng đã có trong giỏ");
                return;
            }
            themChiTiet(maMH, tenMH, sl, donGia);       
            thanhTien += decimal.Parse(donGia) * decimal.Parse(sl);
            txt_tienhang.Text = thanhTien.ToString();
            btn_moHDMoi.Enabled = true;
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
            bool kt =luu();
            if (kt)
            {
                KQ = kt;
                
            }
            load();
        }

        private bool kTraNullCB()
        {
            if (string.IsNullOrEmpty(txt_maDon.Text) || string.IsNullOrEmpty(dateEdit1.Text) )              
            {
                return true;
            }
            return false;
        }

        private bool luu()
        {
            if (kTraNullCB())
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return false;
            }
            string giamgia="0";
            if (string.IsNullOrEmpty(txt_giamGia.Text) == false)
                giamgia = txt_giamGia.Text;
            var result = hd.InsertHoaDon(txt_maDon.Text,cb_KH.SelectedValue.ToString(),cb_NV.SelectedValue.ToString(),dateEdit1.Text.ToString(),giamgia);
            switch (result)
            {
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Thêm thông tin hóa đơn thất bại"); break;
                case DAL.Result.PRIMARY_KEY: MessageBox.Show("Mã đơn đã tồn tại"); break;
            }
            if (result == DAL.Result.SUCCESS)
            {
                for (int i = 0; i < dgv_cthd.Rows.Count-1; i++)
                {
                    result = cthd.InsertChiTietHoaDon(txt_maDon.Text, dgv_cthd.Rows[i].Cells[0].Value.ToString(), dgv_cthd.Rows[i].Cells[2].Value.ToString(), dgv_cthd.Rows[i].Cells[3].Value.ToString());
                }
            }
            switch (result)
            {
                case DAL.Result.SUCCESS: MessageBox.Show("Thêm hóa đơn thành công"); break;
                case DAL.Result.EMPTY: MessageBox.Show("Chưa nhập đủ thông tin"); break;
                case DAL.Result.FAILED: MessageBox.Show("Thêm hóa đơn thất bại"); break;
            }
            if (result == DAL.Result.SUCCESS)
                return true;
            return false;
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
            txt_maDon.Text = txt_tienhang.Text = txt_giamGia.Text = txt_tongcong.Text = "";
            dgv_cthd.Enabled = false;
        }

        private void txt_giamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            decimal gia=0;
            try
            {
                if (string.IsNullOrEmpty(txt_giamGia.Text) == false)
                    gia = decimal.Parse(txt_giamGia.Text);
            }
            catch
            {
                gia = 0;
            }
            if (gia > decimal.Parse(txt_tienhang.Text))
            {
                MessageBox.Show("Giảm giá lớn hơn tiền hàng");
                txt_giamGia.Text = "";
            }
            else
            {
                decimal tien = decimal.Parse(txt_tienhang.Text) - gia;
                txt_tongcong.Text = tien.ToString();
            }
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

        private void capNhatSLKho(string a, int b)
        {
            ctkh.updateSoluongMH(a, b);
        }

        private void updateSLMH()
        {
            for (int i = 0; i < dgv_cthd.Rows.Count - 1; i++)
            {
                int slhangcon = ctkh.laySoLuongHang(dgv_cthd.Rows[i].Cells[0].Value.ToString()) + int.Parse(dgv_cthd.Rows[i].Cells[2].Value.ToString());
                ctkh.updateSoluongMH(dgv_cthd.Rows[i].Cells[0].Value.ToString(), slhangcon);
               // ctkh.updateSoluongThem(dgv_cthd.Rows[i].Cells[0].Value.ToString(), dgv_cthd.Rows[i].Cells[2].Value.ToString());
                if (ctkh.laySoLuongHang(dgv_cthd.Rows[i].Cells[0].Value.ToString()) == 0)
                mh.updateTinhTrangHH(dgv_cthd.Rows[i].Cells[0].Value.ToString());
            }
        }
    }
}