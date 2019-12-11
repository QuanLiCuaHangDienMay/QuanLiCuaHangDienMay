using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_DAL : Base_DAL
    {        
        public HoaDon_DAL() { }

        //Lấy danh sách hóa đơn
        public List<HoaDon> GetHoaDon()
        {
            return (from hd in qlch.HoaDons select hd).ToList<HoaDon>();
        }

        //Thêm loại hóa đơn
        public Result InsertHD(string MaHD, string MaKH, string MaNV, string NgayLapHD, string GiamGiaTrucTiep)
        {
            if (checkPrimaryKeyMaHoaDon(MaHD) == false)
                return Result.PRIMARY_KEY;
            try
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = MaHD;
                hd.MaKH = MaKH;
                hd.MaNV = MaNV;
                hd.NgayLapHD = DateTime.Parse(NgayLapHD);
                hd.GiamGiaTrucTiep = decimal.Parse(GiamGiaTrucTiep);
                hd.TongTien = 0;
                qlch.HoaDons.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa hóa đơn
        public Result DeleteHD(string pMaHD)
        {
            if (checkPrimaryKeyMaHoaDon(pMaHD) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.HoaDons.DeleteOnSubmit(qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, pMaHD)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật hóa đơn
        public Result UpdateHD(string MaHD, string MaKH, string MaNV, string NgayLapHD, string GiamGiaTrucTiep)
        {
            if (checkPrimaryKeyMaHoaDon(MaHD) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var hoadon = qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, MaHD));
                hoadon.MaKH = MaKH;
                hoadon.MaNV = MaNV;
                hoadon.NgayLapHD = DateTime.Parse(NgayLapHD);
                hoadon.GiamGiaTrucTiep = decimal.Parse(GiamGiaTrucTiep);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã hóa đơn
        public bool checkPrimaryKeyMaHoaDon(string pMaHD)
        {
            return (qlch.HoaDons.FirstOrDefault(hd => string.Equals(hd.MaHD, pMaHD)) == null);
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
