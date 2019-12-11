using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class NhanVien_BLL
    {
        NhanVien_DAL nv = new NhanVien_DAL();

        public List<NhanVien> GetNhanViens()
        {
            return nv.GetNhanViens();
        }

        public Result InsertNhanVien(string pMaNV, string pTenNV, string pMaCV, string pDiaChiNV, string pDienThoaiNV, string pGioiTinh, string pNgayVaoLam)
        {
            if (string.IsNullOrEmpty(pMaNV) || string.IsNullOrEmpty(pTenNV))
                return Result.EMPTY;
            return nv.InsertNV(pMaNV, pTenNV, pMaCV, pDiaChiNV, pDienThoaiNV, pGioiTinh, pNgayVaoLam);
        }

        public Result DeleteNhanVien(string pMaNV)
        {
            return nv.DeleteNV(pMaNV);
        }

        public Result UpdateNhanVien(string pMaNV, string pTenNV, string pMaCV, string pDiaChiNV, string pDienThoaiNV, string pGioiTinh, string pNgayVaoLam)
        {
            if (string.IsNullOrEmpty(pMaNV) || string.IsNullOrEmpty(pTenNV))
                return Result.EMPTY;
            return nv.UpdateNV(pMaNV, pTenNV, pMaCV, pDiaChiNV, pDienThoaiNV, pGioiTinh, pNgayVaoLam);
        }

    }
}
