using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhap_DAL :Base_DAL
    {
        public PhieuNhap_DAL() { }

        //Lấy danh sách hóa đơn
        public List<PhieuNhap> GetPN()
        {
            return (from hd in qlch.PhieuNhaps select hd).ToList<PhieuNhap>();
        }

        //Thêm loại hóa đơn
        public Result InsertPN(string MaPN,string maNV,string ngayLap,string ghiChu)
        {
            if (checkPrimaryKeyMaHoaDon(MaPN) == false)
                return Result.PRIMARY_KEY;
            try
            {
                PhieuNhap hd = new PhieuNhap();
                hd.MaPN = MaPN;
                hd.MaNV = maNV;
                hd.GhiChu = ghiChu;
                hd.NgayLapPN = DateTime.Parse(ngayLap);
                hd.TongTienNhap = 0;
                qlch.PhieuNhaps.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        ////Xóa hóa đơn
        //public Result DeleteHD(string pMaHD)
        //{
        //    if (checkPrimaryKeyMaHoaDon(pMaHD) == true)
        //        return Result.KEY_NOT_FOUND;
        //    try
        //    {
        //        qlch.HoaDons.DeleteOnSubmit(qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, pMaHD)));
        //        qlch.SubmitChanges();
        //        return Result.SUCCESS;
        //    }
        //    catch
        //    {
        //        return Result.FAILED;
        //    }
        //}

        ////Cập nhật hóa đơn
        //public Result UpdateHD(string MaHD, string MaKH, string MaNV, string NgayLapHD, string GiamGiaTrucTiep)
        //{
        //    if (checkPrimaryKeyMaHoaDon(MaHD) == true)
        //        return Result.KEY_NOT_FOUND;
        //    try
        //    {
        //        var hoadon = qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, MaHD));
        //        hoadon.MaKH = MaKH;
        //        hoadon.MaNV = MaNV;
        //        hoadon.NgayLapHD = DateTime.Parse(NgayLapHD);
        //        hoadon.GiamGiaTrucTiep = decimal.Parse(GiamGiaTrucTiep);
        //        qlch.SubmitChanges();
        //        return Result.SUCCESS;
        //    }
        //    catch
        //    {
        //        return Result.FAILED;
        //    }
        //}

        //Kiểm tra mã hóa đơn
        public bool checkPrimaryKeyMaHoaDon(string pMaPN)
        {
            return (qlch.PhieuNhaps.FirstOrDefault(hd => string.Equals(hd.MaPN, pMaPN)) == null);
        }

        //Cập nhật tổng tiền hóa đơn
        public Result UpdateTongTienHDThem(string MaHD, string TongTienThem)
        {
            if (checkPrimaryKeyMaHoaDon(MaHD) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var hoadon = qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, MaHD));
                hoadon.TongTien += decimal.Parse(TongTienThem);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật tổng tiền hóa đơn
        public Result UpdateTongTienHDTru(string MaHD, string TongTienTru)
        {
            if (checkPrimaryKeyMaHoaDon(MaHD) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var hoadon = qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, MaHD));
                hoadon.TongTien -= decimal.Parse(TongTienTru);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }
    }

    
}
