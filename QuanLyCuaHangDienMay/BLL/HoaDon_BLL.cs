using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDon_BLL
    {
        HoaDon_DAL hd = new HoaDon_DAL();

        public List<HoaDon> GetHoaDon()
        {
            return hd.GetHoaDon();
        }

        public Result InsertHoaDon(string MaHD, string MaKH, string MaNV, string NgayLapHD, string GiamGiaTrucTiep)
        {
            if (string.IsNullOrEmpty(MaHD))
                return Result.EMPTY;
            return hd.InsertHD(MaHD, MaKH, MaNV, NgayLapHD, GiamGiaTrucTiep);
        }

        public Result DeleteHoaDon(string MaHD)
        {
            return hd.DeleteHD(MaHD);
        }

        public Result UpdateHoaDon(string MaHD, string MaKH, string MaNV, string NgayLapHD, string GiamGiaTrucTiep)
        {
            if (string.IsNullOrEmpty(MaHD))
                return Result.EMPTY;
            return hd.UpdateHD(MaHD, MaKH, MaNV, NgayLapHD, GiamGiaTrucTiep);
        }

        public Result UpdateHoaDonThem(string MaHD, string TongTienThem)
        {
            if (string.IsNullOrEmpty(MaHD))
                return Result.EMPTY;
            return hd.UpdateTongTienHDThem(MaHD, TongTienThem);
        }

        public Result UpdateHoaDonTru(string MaHD, string TongTienTru)
        {
            if (string.IsNullOrEmpty(MaHD))
                return Result.EMPTY;
            return hd.UpdateTongTienHDTru(MaHD, TongTienTru);
        }
    }
}
