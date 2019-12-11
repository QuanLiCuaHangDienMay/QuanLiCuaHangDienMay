using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class KhachHang_DAL : Base_DAL
    {
        public KhachHang_DAL() { }

        //Lấy danh sách khách hàng
        public List<KhachHang> GetKhachHangs()
        {
            return (from kh in qlch.KhachHangs select kh).ToList<KhachHang>();
        }

        //Thêm loại khách hàng
        public Result InsertKH(string pMaKH, string pTenKH, string pGioiTinhKH, string pDiaChiKH, string pDienThoaiKH, string pEmailKH, string pNgaySinhKH, string pDiemTichLuyBanDau, string pMaNV, string pMaNhomKH, string pMaTinhThanh, string pGhiChu)
        {
            if (checkPrimaryKeyMaKhachHang(pMaKH) == false)
                return Result.PRIMARY_KEY;

            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = pMaKH;
                kh.TenKH = pTenKH;
                kh.GioiTinhKH = pGioiTinhKH;
                kh.DiaChiKH = pDiaChiKH;
                kh.DienThoaiKH = pDienThoaiKH;
                kh.EmailKH = pEmailKH;
                kh.NgaySinhKH = DateTime.Parse(pNgaySinhKH);
                kh.DiemTichLuyBanDau = double.Parse(pDiemTichLuyBanDau);
                kh.MaNV = pMaNV;
                kh.MaNhomKH = pMaNhomKH;
                kh.MaTinhThanh = pMaTinhThanh;
                kh.GhiChu = pGhiChu;
                qlch.KhachHangs.InsertOnSubmit(kh);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa nhà cung cấp
        public Result DeleteKH(string pMaKH)
        {
            if (checkPrimaryKeyMaKhachHang(pMaKH) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.KhachHangs.DeleteOnSubmit(qlch.KhachHangs.FirstOrDefault(kh => string.Equals(kh.MaKH, pMaKH)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật loại mặt hàng
        public Result UpdateKh(string pMaKH, string pTenKH, string pGioiTinhKH, string pDiaChiKH, string pDienThoaiKH, string pEmailKH, string pNgaySinhKH, string pDiemTichLuyBanDau, string pMaNV, string pMaNhomKH, string pMaTinhThanh, string pGhiChu)
        {
            if (checkPrimaryKeyMaKhachHang(pMaKH) == true)
                return Result.KEY_NOT_FOUND;
           
            try
            {
                var khachhang = qlch.KhachHangs.FirstOrDefault(kh => string.Equals(kh.MaKH, pMaKH));
                    //khachhang.MaKH = pMaKH;
                    khachhang.TenKH = pTenKH;
                    khachhang.GioiTinhKH = pGioiTinhKH;
                    khachhang.DiaChiKH = pDiaChiKH;
                    khachhang.DienThoaiKH = pDienThoaiKH;
                    khachhang.EmailKH = pEmailKH;
                    khachhang.NgaySinhKH = DateTime.Parse(pNgaySinhKH);
                    khachhang.DiemTichLuyBanDau = double.Parse(pDiemTichLuyBanDau);
                    khachhang.MaKH = pMaNV;
                    khachhang.MaNhomKH = pMaNhomKH;
                    khachhang.MaNhomKH = pMaTinhThanh;
                    khachhang.GhiChu = pGhiChu;
                    qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã nhà cung cấp
        public bool checkPrimaryKeyMaKhachHang(string pMaKH)
        {
            return (qlch.KhachHangs.FirstOrDefault(KH => string.Equals(KH.MaKH, pMaKH)) == null);
        }

    }
}
