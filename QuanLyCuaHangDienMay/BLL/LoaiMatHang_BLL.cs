using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoaiMatHang_BLL 
    {
        LoaiMatHang_DAL lmh = new LoaiMatHang_DAL();

        public List<LoaiMatHang> GetLoaiMatHang()
        {
            return lmh.GetLoaiMatHang();
        }

        public Result InsertLoaiMatHang(string pMaLoaiHang,string pTenLoaiHang)
        {
            if (string.IsNullOrEmpty(pMaLoaiHang) || string.IsNullOrEmpty(pTenLoaiHang))
                return Result.EMPTY;
            return lmh.InsertLoaiMatHang(pMaLoaiHang,pTenLoaiHang);
        }

        public Result DeleteLoaiMatHang(string pmaLoaiHang)
        {
            return lmh.DeleteLoaiMatHang(pmaLoaiHang);
        }

        public Result UpdateLoaiMatHang(string pMaLoaiHang, string pTenLoaiHang)
        {
            if (string.IsNullOrEmpty(pMaLoaiHang) || string.IsNullOrEmpty(pMaLoaiHang))
                return Result.EMPTY;
            return lmh.UpdateLoaiMatHang(pMaLoaiHang,pTenLoaiHang);
        }

    }
}
