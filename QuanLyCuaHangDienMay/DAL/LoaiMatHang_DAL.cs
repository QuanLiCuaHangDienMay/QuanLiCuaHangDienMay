using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiMatHang_DAL : Base_DAL
    {
        public LoaiMatHang_DAL() { }

        //Lấy danh sách loại mặt hàng
        public List<LoaiMatHang> GetLoaiMatHang()
        {
            return (from lmh in qlch.LoaiMatHangs select lmh).ToList<LoaiMatHang>();
        }

        //Thêm loại mặt hàng
        public Result InsertLoaiMatHang(string pMaLoaiMH, string pTenLoaiMH)
        {
            if (checkPrimaryKeyLoaiMatHang(pMaLoaiMH) == false)
                return Result.PRIMARY_KEY;
            if (checkPrimaryKeyTenLoaiMatHang(pTenLoaiMH) == false)
                return Result.UNIQUE_NAME;
            try
            {
                LoaiMatHang lmh = new LoaiMatHang();
                lmh.MaLoaiMatHang = pMaLoaiMH;
                lmh.TenLoaiMatHang = pTenLoaiMH;
                qlch.LoaiMatHangs.InsertOnSubmit(lmh);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Xóa loại mặt hàng
        public Result DeleteLoaiMatHang(string pMaLoaiMH)
        {
            if (checkPrimaryKeyLoaiMatHang(pMaLoaiMH) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.LoaiMatHangs.DeleteOnSubmit(qlch.LoaiMatHangs.FirstOrDefault(lmh => string.Equals(lmh.MaLoaiMatHang, pMaLoaiMH)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật loại mặt hàng
        public Result UpdateLoaiMatHang(string pMaLoaiMH, string pTenLoaiMH)
        {
            if(checkPrimaryKeyLoaiMatHang(pMaLoaiMH)==true)
                return Result.KEY_NOT_FOUND;
            if (checkPrimaryKeyTenLoaiMatHang(pTenLoaiMH) == false)
                return Result.UNIQUE_NAME;
            try
            {
                var lmh = qlch.LoaiMatHangs.FirstOrDefault(loaiMatHang => string.Equals(loaiMatHang.MaLoaiMatHang, pMaLoaiMH));
                lmh.TenLoaiMatHang = pTenLoaiMH;
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Kiểm tra mã loại mặt hàng
        public bool checkPrimaryKeyLoaiMatHang(string pMaLoaiMH)
        {
            return (qlch.LoaiMatHangs.FirstOrDefault(loaiMH => string.Equals(loaiMH.MaLoaiMatHang, pMaLoaiMH)) == null);
        }

        //Kiểm tra tên loại mặt hàng
        public bool checkPrimaryKeyTenLoaiMatHang(string pTenLoaiMH)
        {
            return (qlch.LoaiMatHangs.FirstOrDefault(loaiMH => string.Equals(loaiMH.TenLoaiMatHang, pTenLoaiMH)) == null);
        }
    }
}
