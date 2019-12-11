using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL : Base_DAL
    {
        public NhanVien_DAL() { }

        //Lấy danh sách nhà cung cấp
        public List<NhanVien> GetNhanViens()
        {
            return (from nv in qlch.NhanViens select nv).ToList<NhanVien>();
        }

        //Thêm loại nhà cung cấp
        public Result InsertNV(string pMaNV, string pTenNV, string pMaCV, string pDiaChiNV, string pDienThoaiNV, string pGioiTinh, string pNgayVaoLam)
        {
            if (checkPrimaryKeyMaNV(pMaNV) == false)
                return Result.PRIMARY_KEY;
            if (checkPrimaryKeyTenNV(pTenNV) == false)
                return Result.UNIQUE_NAME;
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = pMaNV;
                nv.TenNV = pTenNV;
                nv.MaCV = pMaCV;
                nv.DiaChiNV = pDiaChiNV;
                nv.DienThoaiNV = pDienThoaiNV;
                nv.GioiTinhNV = pGioiTinh;
                nv.NgayVaoLam = DateTime.Parse (pNgayVaoLam);
                qlch.NhanViens.InsertOnSubmit(nv);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa nhà cung cấp
        public Result DeleteNV(string pMaNV)
        {
            if (checkPrimaryKeyMaNV(pMaNV) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.NhanViens.DeleteOnSubmit(qlch.NhanViens.FirstOrDefault(nv => string.Equals(nv.MaNV, pMaNV)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật loại mặt hàng
        public Result UpdateNV(string pMaNV, string pTenNV, string pMaCV, string pDiaChiNV, string pDienThoaiNV, string pGioiTinh, string pNgayVaoLam)
        {
            if (checkPrimaryKeyMaNV(pMaNV) == true)
                return Result.KEY_NOT_FOUND;
            if (checkPrimaryKeyTenNV(pTenNV) == false)
                return Result.UNIQUE_NAME;
            try
            {
                var nhanvien = qlch.NhanViens.FirstOrDefault(nv => string.Equals(nv.MaNV, pMaNV));
                nhanvien.TenNV = pTenNV;
                nhanvien.MaCV = pMaCV;
                nhanvien.DiaChiNV = pDiaChiNV;
                nhanvien.DienThoaiNV = pDienThoaiNV;
                nhanvien.GioiTinhNV = pGioiTinh;
                nhanvien.NgayVaoLam = DateTime.Parse (pNgayVaoLam);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã nhà cung cấp
        public bool checkPrimaryKeyMaNV(string pMaNV)
        {
            return (qlch.NhanViens.FirstOrDefault(NV => string.Equals(NV.MaNV, pMaNV)) == null);
        }

        //Kiểm tra tên nhà cung cấp
        public bool checkPrimaryKeyTenNV(string pTenNV)
        {
            return (qlch.NhanViens.FirstOrDefault(NV => string.Equals(NV.TenNV, pTenNV)) == null);
        }
    }
}
