using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

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

        public List<Kho_DTO> Getctkho()
        {
            var temp = (from ctk in qlch.ChiTietKhos
                        join k in qlch.Khos on ctk.MaKho equals k.MaKho
                        join mh in qlch.MatHangs on ctk.MaHang equals mh.MaHang
                        select new
                        {
                            MaKho = ctk.MaKho,
                            TenKho = k.TenKho,
                            MaHang = ctk.MaHang,
                            TenMatHang = mh.TenMatHang,
                            SoLuong = ctk.SoLuong,
                        }).AsEnumerable()
                      .Select(x => new Kho_DTO
                      {

                          MaKho = x.MaKho,
                          TenKho = x.TenKho,
                          MaHang = x.MaHang,
                          TenMatHang = x.TenMatHang,
                          SoLuong = x.SoLuong,
                      }).ToList<Kho_DTO>();
            return temp;
        }



        ////Thêm 



        public Result InsertCTKho(string MaHang)
        {
            try
            {
                ChiTietKho ct = new ChiTietKho();
                ct.MaHang = MaHang;
                ct.MaKho = "KHO001";
                ct.SoLuong = 0;
                qlch.ChiTietKhos.InsertOnSubmit(ct);
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

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
                int? slkho=ctkh.SoLuong/2+int.Parse(SoLuong);
                ctkh.SoLuong= slkho;
                qlch.SubmitChanges();
                return Result.SUCCESS;
            }
            catch
            {
                return Result.FAILED;
            }
        }

        public Result UpdateSoLuongThem2(string MaHang, string SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho,MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
                int? slkho=ctkh.SoLuong-int.Parse(SoLuong);
                ctkh.SoLuong= slkho;
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
            try
            {
                if (checkPrimaryKeyMaChiTietKho(MaKho, MaHang) == true)
                    return Result.KEY_NOT_FOUND;
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
                if (ctkh.SoLuong < int.Parse(SoLuong))
                    return Result.OUT_OF_STOCK;
                return Result.FAILED;
            }
            catch
            {
                return Result.EMPTY;
            }
        }

        public int LaySoLuong(string MaHang, string SoLuong)
        {
            var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
            if (ctkh.SoLuong < int.Parse(SoLuong))
                return int.Parse(ctkh.SoLuong.ToString());
            return 0;
        }



        public int LaySoLuongHang(string MaHang)
        {
            var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
            return int.Parse(ctkh.SoLuong.ToString());
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

        public Result UpdateSoLuongCong(string MaHang, int SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho, MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == "KHO001" && kh.MaHang == MaHang);
                ctkh.SoLuong += SoLuong;
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

        public Result UpdateSoLuongMH(string MaHang, int SoLuong)
        {
            if (checkPrimaryKeyMaChiTietKho(MaKho, MaHang) == true)
                return Result.KEY_NOT_FOUND;
            try
            {
                var ctkh = qlch.ChiTietKhos.FirstOrDefault(kh => kh.MaKho == MaKho && kh.MaHang == MaHang);
                ctkh.SoLuong = SoLuong;
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
