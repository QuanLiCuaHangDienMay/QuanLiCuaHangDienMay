using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKho_DAL :Base_DAL
    {
        public ChiTietKho_DAL() { }
        public static string MaKho = "KHO001";
        //Lấy danh sách 
        public List<ChiTietKho> GetChiTietKho()
        {
            return (from kh in qlch.ChiTietKhos select kh).ToList<ChiTietKho>();
        }

        ////Thêm 
        //public Result InsertNCC(string pMaNCC, string pTenNhaCC, string pDiaChiNCC, string pDienThoaiNCC, string pEmailNCC, string pwebsiteNCC)
        //{
        //    if (checkPrimaryKeyMaNhaCungCap(pMaNCC) == false)
        //        return Result.PRIMARY_KEY;
        //    if (checkPrimaryKeyTenNhaCungCap(pTenNhaCC) == false)
        //        return Result.UNIQUE_NAME;
        //    try
        //    {
        //        NhaCungCap ncc = new NhaCungCap();
        //        ncc.MaNhaCC = pMaNCC;
        //        ncc.TenNhaCC = pTenNhaCC;
        //        ncc.DiaChiNCC = pDiaChiNCC;
        //        ncc.DienThoaiNCC = pDienThoaiNCC;
        //        ncc.EmailNCC = pEmailNCC;
        //        ncc.websiteNCC = pwebsiteNCC;
        //        qlch.NhaCungCaps.InsertOnSubmit(ncc);
        //        qlch.SubmitChanges();
        //        return Result.SUCCESS;
        //    }
        //    catch
        //    {
        //        return Result.FAILED;
        //    }
        //}

        ////Xóa 
        //public Result DeleteNCC(string pMaNCC)
        //{
        //    if (checkPrimaryKeyMaNhaCungCap(pMaNCC) == true)
        //        return Result.KEY_NOT_FOUND;
        //    try
        //    {
        //        qlch.NhaCungCaps.DeleteOnSubmit(qlch.NhaCungCaps.FirstOrDefault(ncc => string.Equals(ncc.MaNhaCC, pMaNCC)));
        //        qlch.SubmitChanges();
        //        return Result.SUCCESS;
        //    }
        //    catch
        //    {
        //        return Result.FAILED;
        //    }
        //}

        //Cập nhật 
        public Result UpdateSoLuongThem(string MaHang, string SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho,MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
                ctkh.SoLuong += int.Parse(SoLuong);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiem tra so luonh
        public Result KiemTraSoLuong(string MaHang, string SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho, MaHang) == true)
                return Result.KEY_NOT_FOUND;
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
                if (ctkh.SoLuong < int.Parse(SoLuong))
                    return Result.OUT_OF_STOCK;
                return Result.FAILED;
        }

        public int LaySoLuong(string MaHang, string SoLuong)
        {
            var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
            if (ctkh.SoLuong < int.Parse(SoLuong))
                return int.Parse(ctkh.SoLuong.ToString());
            return 0;
        }

        //Cập nhật 
        public Result UpdateSoLuongTru(string MaHang, string SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho, MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == "KHO001" && kh.MaHang == MaHang);
                ctkh.SoLuong -= int.Parse(SoLuong);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã 
        public bool checkPrimaryKeyMaChiTietKho(string MaKho, string MaHang)
        {
            return (qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == "KHO001" && kh.MaHang == MaHang) == null);
        }


        public List<ChiTietKho> GetChiTietKhoByCondition(string MaHang)
        {
            return qlch.ChiTietKhos.Where(kh => kh.MaKho == "KHO001" && kh.MaHang == MaHang).ToList<ChiTietKho>();    
        }
        
    }
}
