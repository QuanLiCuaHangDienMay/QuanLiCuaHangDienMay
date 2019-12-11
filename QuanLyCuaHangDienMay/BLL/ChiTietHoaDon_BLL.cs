using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ChiTietHoaDon_BLL
    {
        ChiTietHoaDon_DAL cthd = new ChiTietHoaDon_DAL();

        public List<ChiTietHoaDon> GetHoaDon()
        {
            return cthd.GetChiTietHoaDon();
        }

        public Result InsertChiTietHoaDon(string MaHD, string MaHang, string SoLuong, string DonGia)
        {
            if (string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(MaHang))
                return Result.EMPTY;
            return cthd.InsertCTHD(MaHD, MaHang, SoLuong, DonGia);
        }

        public Result DeleteChiTietHoaDon(string MaHD, string MaHang)
        {
            return cthd.DeleteCTHD(MaHD,MaHang);
        }

        public Result UpdateChiTietHoaDon(string MaHD, string MaHang, string SoLuong, string DonGia, string ThanhTien)
        {
            if (string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(MaHang))
                return Result.EMPTY;
            return cthd.UpdateCTHD(MaHD, MaHang, SoLuong, DonGia, ThanhTien);
        }
    
    }
}
