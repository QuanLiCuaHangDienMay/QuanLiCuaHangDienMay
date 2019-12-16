using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhap_DAL:Base_DAL
    {
        public ChiTietPhieuNhap_DAL() { }

        //Lấy danh sách chi tiết hóa đơn
        public List<ChiTietPhieuNhap> GetChiTietHoaDon()
        {
            return (from cthd in qlch.ChiTietPhieuNhaps select cthd).ToList<ChiTietPhieuNhap>();
        }

        //Thêm loại chi tiết hóa đơn
        public Result InsertCTHD(string maPN,string maHang,string giaNhap,string soluong)
        {
            if (checkPrimaryKeyMaChiTietHoaDon(maPN,maHang) == false)
                return Result.PRIMARY_KEY;
            try
            {
                ChiTietPhieuNhap hd = new ChiTietPhieuNhap();
                hd.MaPN = maPN;
                hd.MaHang = maHang;
                hd.MaKho = "KHO001";
                hd.SoLuongNhap = int.Parse(soluong);
                hd.GiaNhap = decimal.Parse(giaNhap);
                hd.ThanhTien = hd.SoLuongNhap*hd.GiaNhap;
                qlch.ChiTietPhieuNhaps.InsertOnSubmit(hd);
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
        public bool checkPrimaryKeyMaChiTietHoaDon(string pMaPN,string pMaHang)
        {
            return qlch.ChiTietPhieuNhaps.FirstOrDefault(cthd => cthd.MaPN == pMaPN && cthd.MaHang == pMaHang && cthd.MaKho == "KHO001") == null;
        }
    
    }
    
}
