using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhaCungCap_BLL
    {
        NhaCungCap_DAL ncc = new NhaCungCap_DAL();

        public List<NhaCungCap> GetNhaCungCap()
        {
            return ncc.GetNhaCungCap();
        }

        public Result InsertNhaCungCap(string pMaNCC, string pTenNhaCC, string pDiaChiNCC, string pDienThoaiNCC, string pEmailNCC, string pwebsiteNCC)
        {
            if (string.IsNullOrEmpty(pMaNCC) || string.IsNullOrEmpty(pTenNhaCC))
                return Result.EMPTY;
            return ncc.InsertNCC(pMaNCC, pTenNhaCC, pDiaChiNCC, pDienThoaiNCC, pEmailNCC, pwebsiteNCC);
        }

        public Result DeleteNhaCungCap(string pMaNCC)
        {
            return ncc.DeleteNCC(pMaNCC);
        }

        public Result UpdateNhaCungCap(string pMaNCC, string pTenNhaCC, string pDiaChiNCC, string pDienThoaiNCC, string pEmailNCC, string pwebsiteNCC)
        {
            if (string.IsNullOrEmpty(pMaNCC) || string.IsNullOrEmpty(pTenNhaCC))
                return Result.EMPTY;
            return ncc.UpdateNCC(pMaNCC, pTenNhaCC, pDiaChiNCC, pDienThoaiNCC, pEmailNCC, pwebsiteNCC);
        }
    

    }
}
