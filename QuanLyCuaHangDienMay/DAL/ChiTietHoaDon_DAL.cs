using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDon_DAL : Base_DAL
    {
        public ChiTietHoaDon_DAL() { }

        //Lấy danh sách chi tiết hóa đơn
        public List<ChiTietHoaDon> GetChiTietHoaDon()
        {
            return (from cthd in qlch.ChiTietHoaDons select cthd).ToList<ChiTietHoaDon>();
        }

        //Thêm loại chi tiết hóa đơn
        public Result InsertCTHD(string MaHD,string MaHang,string SoLuong,string DonGia)
        {
            if (checkPrimaryKeyMaChiTietHoaDon(MaHD,MaHang) == false)
                return Result.PRIMARY_KEY;
            try
            {
                ChiTietHoaDon hd = new ChiTietHoaDon();
                hd.MaHD = MaHD;
                hd.MaHang = MaHang;
                hd.SoLuong = int.Parse(SoLuong);
                hd.DonGia = decimal.Parse(DonGia);
                hd.ThanhTien = hd.SoLuong*hd.DonGia;
                qlch.ChiTietHoaDons.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa chi tiết hóa đơn
        public Result DeleteCTHD(string pMaHD,string pMaHang)
        {
            if (checkPrimaryKeyMaChiTietHoaDon(pMaHD,pMaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.ChiTietHoaDons.DeleteOnSubmit(qlch.ChiTietHoaDons.FirstOrDefault(cthd => cthd.MaHD==pMaHD&&cthd.MaHang==pMaHang));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật chi tiết hóa đơn
        public Result UpdateCTHD(string MaHD,string MaHang,string SoLuong,string DonGia,string ThanhTien)
        {
            if (checkPrimaryKeyMaChiTietHoaDon(MaHD,MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var chitiethoadon = qlch.ChiTietHoaDons.FirstOrDefault(cthd => cthd.MaHD==MaHD&&cthd.MaHang==MaHang);
                chitiethoadon.SoLuong = int.Parse(SoLuong);
                chitiethoadon.DonGia = decimal.Parse(DonGia);
                chitiethoadon.ThanhTien = chitiethoadon.SoLuong*chitiethoadon.DonGia;
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã chi tiết hóa đơn
        public bool checkPrimaryKeyMaChiTietHoaDon(string pMaHD,string pMaHang)
        {
            return qlch.ChiTietHoaDons.FirstOrDefault(cthd => cthd.MaHD==pMaHD&&cthd.MaHang==pMaHang)==null;
        }

        public List<ChiTietHoaDon> getcthd(string pMaHD)
        {
            return qlch.ChiTietHoaDons.Where(mh => string.Equals(mh.MaHD, pMaHD)).ToList<ChiTietHoaDon>();
        }

        public List<ChiTietHoaDon> GetMatHangByCondition(string pmaMH)
        {
            return qlch.ChiTietHoaDons.Where(mh => string.Equals(mh.MaHang, pmaMH)).ToList<ChiTietHoaDon>();
        }
    

    }
}
