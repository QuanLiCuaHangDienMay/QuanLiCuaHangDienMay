using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DTO;

namespace BLL
{
    public class MatHang_BLL
    {
        MatHang_DAL mathang = new MatHang_DAL();

        public List<MatHang_DTO> GetMatHang()
        {
            return mathang.GetMatHang();
        }

        public List<string> GetDVT()
        {
            return mathang.GetDVT();
        }

        public Result InsertMatHang(string pMaHang, string pTenMatHang, string pMaLoaiMatHang, string pDVT, decimal? pGiaBan,
                                       decimal? pGiaNhap, string pMaNhaCC, byte? pBaoHanh, string pTinhTrangHang)
        {
            if (string.IsNullOrEmpty(pMaHang) || string.IsNullOrEmpty(pTenMatHang))
                return Result.EMPTY;
            return mathang.InsertMatHang(pMaHang, pTenMatHang, pMaLoaiMatHang, pDVT, pGiaBan, pGiaNhap, pMaNhaCC, pBaoHanh, pTinhTrangHang);
        }

        public Result DeleteMatHang(string pmaHang)
        {
            return mathang.DeleteMatHang(pmaHang);
        }

        public Result UpdateMatHang(string pMaHang, string pTenMatHang, string pMaLoaiMatHang, string pDVT, decimal? pGiaBan,
                                       decimal? pGiaNhap, string pMaNhaCC, byte? pBaoHanh)
        {
            if (string.IsNullOrEmpty(pMaHang) || string.IsNullOrEmpty(pTenMatHang))
                return Result.EMPTY;
            return mathang.UpdateMatHang(pMaHang, pTenMatHang, pMaLoaiMatHang, pDVT, pGiaBan, pGiaNhap, pMaNhaCC, pBaoHanh);
        }

        public List<MatHang> GetMatHangByCondition(string pTenMH)
        {
            return mathang.GetMatHangByCondition(pTenMH);
        }

        public List<MatHang> GetMatHang2()
        {
            return mathang.GetMatHang2();                                                    
        }
    }
}
