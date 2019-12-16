using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL
{
    public class MatHang_DAL : Base_DAL
    {
        MatHang mh;
        public MatHang_DAL() { }

        //Lấy thông mặt hàng
        public List<MatHang_DTO> GetMatHang()
        {
            var temp = (from mh in qlch.MatHangs
                        join lmh in qlch.LoaiMatHangs on mh.MaLoaiMatHang equals lmh.MaLoaiMatHang
                        join ncc in qlch.NhaCungCaps on mh.MaNhaCC equals ncc.MaNhaCC
                        select new
                        {
                            MaHang = mh.MaHang,
                            TenMatHang = mh.TenMatHang,
                            MaLoaiMatHang = mh.MaLoaiMatHang,
                            TenLoaiMatHang = lmh.TenLoaiMatHang,
                            DVT = mh.DVT,
                            GiaBan = mh.GiaBan,
                            GiaNhap = mh.GiaNhap,
                            MaNhaCC = mh.MaNhaCC,
                            TenNhaCC = ncc.TenNhaCC,
                            BaoHanh = mh.BaoHanh,
                            TinhTrangHang = mh.TinhTrangHang,
                        }).AsEnumerable()
                      .Select(x => new MatHang_DTO
                      {
                          MaHang = x.MaHang,
                          TenMatHang = x.TenMatHang,
                          MaLoaiMatHang = x.MaLoaiMatHang,
                          TenLoaiMatHang = x.TenLoaiMatHang,
                          DVT = x.DVT,
                          GiaBan = x.GiaBan,
                          GiaNhap = x.GiaNhap,
                          MaNhaCC = x.MaNhaCC,
                          TenNhaCC = x.TenNhaCC,
                          BaoHanh = x.BaoHanh,
                          TinhTrangHang = x.TinhTrangHang,
                      }).ToList<MatHang_DTO>();
            return temp;
        }

        public List<MatHang> GetMatHang2()
        {
            return (from mh in qlch.MatHangs select mh).ToList<MatHang>();
        }

        //Thêm 1 mặt hàng
        public Result InsertMatHang(string pMaHang, string pTenMatHang, string pMaLoaiMatHang, string pDVT, decimal? pGiaBan,
                                    decimal? pGiaNhap, string pMaNhaCC, byte? pBaoHanh, string pTinhTrangHang)
        {
            if (checkPrimaryKeyMatHang(pMaHang) == false)
                return Result.PRIMARY_KEY;
            if (checkUniqueNameMatHang(pTenMatHang) == false)
                return Result.UNIQUE_NAME;
            try
            {
                mh = new MatHang();
                mh.MaHang = pMaHang;
                mh.TenMatHang = pTenMatHang;
                mh.MaLoaiMatHang = pMaLoaiMatHang;
                mh.DVT = pDVT;
                mh.GiaBan = pGiaBan;
                mh.GiaNhap = pGiaNhap;
                mh.MaNhaCC = pMaNhaCC;
                mh.BaoHanh = pBaoHanh;
                mh.TinhTrangHang = "Chưa nhập hàng";
                qlch.MatHangs.InsertOnSubmit(mh);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //List đơn vị tính
        public List<string> GetDVT()
        {
            var list = new List<string>();  
            string[] dvts = { "Cái", "Chiếc", "Bộ" };
            foreach (string dvt in dvts)
            {
                list.Add(dvt);
            }
            return list;
        }

        //Input: mã hàng(string)
        //Xử lí: Kiểm tra mã hàng trong cơ sở dữ liệu SQL server
        //Output: True nếu đã tồn tại
        private bool checkPrimaryKeyMatHang(string pmaMH)
        {
            return (qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.MaHang, pmaMH)) == null);
        }

        //Kiểm tra tên hàng
        private bool checkUniqueNameMatHang(string ptenMH)
        {
            return (qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.TenMatHang, ptenMH)) == null);
        }

        //Xóa mặt hàng
        public Result DeleteMatHang(string pmaMH)
        {
            if (checkPrimaryKeyMatHang(pmaMH) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                qlch.MatHangs.DeleteOnSubmit(qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.MaHang, pmaMH)));
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        //Cập nhật mặt hàng
        public Result UpdateMatHang(string pMaHang, string pTenMatHang, string pMaLoaiMatHang, string pDVT, decimal? pGiaBan,
                                    decimal? pGiaNhap, string pMaNhaCC, byte? pBaoHanh)
        {
            if (checkPrimaryKeyMatHang(pMaHang) == true)
                return Result.KEY_NOT_FOUND;
            if (checkUniqueNameMatHang(pTenMatHang) == false)
                return Result.UNIQUE_NAME;
            try
            {
                var mh = qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.MaHang, pMaHang));
                mh.TenMatHang = pTenMatHang;
                mh.MaLoaiMatHang = pMaLoaiMatHang;
                mh.DVT = pDVT;
                mh.GiaBan = pGiaBan;
                mh.GiaNhap = pGiaNhap;
                mh.MaNhaCC = pMaNhaCC;
                mh.BaoHanh = pBaoHanh;
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }
        //Lọc danh sách mặt hàng theo tên
        public List<MatHang> GetMatHangByCondition(string pTenMH)
        {
            return qlch.MatHangs.Where(mh => string.Equals(mh.TenMatHang, pTenMH)).ToList<MatHang>();
        }

        public Result UpdateMatHangDaBan(string pMaHang)
        {
            if (checkPrimaryKeyMatHang(pMaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var mh = qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.MaHang, pMaHang));
                mh.TinhTrangHang = "Đã bán";
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }


        public Result UpdateMatHangHetHang(string pMaHang)
        {
            if (checkPrimaryKeyMatHang(pMaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var mh = qlch.MatHangs.FirstOrDefault(matHang => string.Equals(matHang.MaHang, pMaHang));
                mh.TinhTrangHang = "Hết hàng";
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

    }
}
