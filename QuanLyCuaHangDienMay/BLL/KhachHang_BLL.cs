using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class KhachHang_BLL
    {
        KhachHang_DAL kh = new KhachHang_DAL();

        public List<KhachHang> GetKhachHangs()
        {
            return kh.GetKhachHangs();
        }

        public Result InsertKH(string pMaKH, string pTenKH, string pGioiTinhKH, string pDiaChiKH, string pDienThoaiKH, string pEmailKH, string pNgaySinhKH, string pDiemTichLuyBanDau, string pMaNV, string pMaNhomKH, string pMaTinhThanh, string pGhiChu)
        {
            if (string.IsNullOrEmpty(pMaKH) || string.IsNullOrEmpty(pTenKH))
                return Result.EMPTY;
            return kh.InsertKH(pMaKH,pTenKH, pGioiTinhKH,  pDiaChiKH,  pDienThoaiKH,  pEmailKH,  pNgaySinhKH,  pDiemTichLuyBanDau,  pMaNV,  pMaNhomKH,  pMaTinhThanh,  pGhiChu);
        }

        public Result DeleteKhachHang(string pMaKH)
        {
            return kh.DeleteKH(pMaKH);
        }

        public Result UpdateKhachhang(string pMaKH, string pTenKH, string pGioiTinhKH, string pDiaChiKH, string pDienThoaiKH, string pEmailKH, string pNgaySinhKH, string pDiemTichLuyBanDau, string pMaNV, string pMaNhomKH, string pMaTinhThanh, string pGhiChu)
        {
            if (string.IsNullOrEmpty(pMaKH) )
                return Result.EMPTY;
            return kh.UpdateKh(pMaKH, pTenKH, pGioiTinhKH, pDiaChiKH, pDienThoaiKH, pEmailKH, pNgaySinhKH, pDiemTichLuyBanDau, pMaNV, pMaNhomKH, pMaTinhThanh, pGhiChu);
        }
    }
}
