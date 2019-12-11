using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCap_DAL : Base_DAL
    {
        public NhaCungCap_DAL() { }

        //Lấy danh sách nhà cung cấp
        public List<NhaCungCap> GetNhaCungCap()
        {
            return (from ncc in qlch.NhaCungCaps select ncc).ToList<NhaCungCap>();
        }

        //Thêm loại nhà cung cấp
        public Result InsertNCC(string pMaNCC, string pTenNhaCC, string pDiaChiNCC, string pDienThoaiNCC, string pEmailNCC, string pwebsiteNCC)
        {
            if (checkPrimaryKeyMaNhaCungCap(pMaNCC) == false)
                return Result.PRIMARY_KEY;
            if (checkPrimaryKeyTenNhaCungCap(pTenNhaCC) == false)
                return Result.UNIQUE_NAME;
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCC = pMaNCC;
                ncc.TenNhaCC = pTenNhaCC;
                ncc.DiaChiNCC = pDiaChiNCC;
                ncc.DienThoaiNCC = pDienThoaiNCC;
                ncc.EmailNCC = pEmailNCC;
                ncc.websiteNCC = pwebsiteNCC;
                qlch.NhaCungCaps.InsertOnSubmit(ncc);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa nhà cung cấp
        public Result DeleteNCC(string pMaNCC)
        {
            if (checkPrimaryKeyMaNhaCungCap(pMaNCC) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.NhaCungCaps.DeleteOnSubmit(qlch.NhaCungCaps.FirstOrDefault(ncc => string.Equals(ncc.MaNhaCC, pMaNCC)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật loại mặt hàng
        public Result UpdateNCC(string pMaNCC, string pTenNhaCC, string pDiaChiNCC, string pDienThoaiNCC, string pEmailNCC, string pwebsiteNCC)
        {
            if (checkPrimaryKeyMaNhaCungCap(pMaNCC) == true)
                return Result.KEY_NOT_FOUND;
            if (checkPrimaryKeyTenNhaCungCap(pTenNhaCC) == false)
                return Result.UNIQUE_NAME;
            try
            {
                var nhacungcap = qlch.NhaCungCaps.FirstOrDefault(ncc => string.Equals(ncc.MaNhaCC, pMaNCC));
                nhacungcap.TenNhaCC = pTenNhaCC;
                nhacungcap.DiaChiNCC = pDiaChiNCC;
                nhacungcap.DienThoaiNCC = pDienThoaiNCC;
                nhacungcap.EmailNCC = pEmailNCC;
                nhacungcap.websiteNCC = pwebsiteNCC;
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã nhà cung cấp
        public bool checkPrimaryKeyMaNhaCungCap(string pMaNCC)
        {
            return (qlch.NhaCungCaps.FirstOrDefault(NCC => string.Equals(NCC.MaNhaCC, pMaNCC)) == null);
        }

        //Kiểm tra tên nhà cung cấp
        public bool checkPrimaryKeyTenNhaCungCap(string pTenNCC)
        {
            return (qlch.NhaCungCaps.FirstOrDefault(NCC => string.Equals(NCC.TenNhaCC, pTenNCC)) == null);
        }
    }
}
