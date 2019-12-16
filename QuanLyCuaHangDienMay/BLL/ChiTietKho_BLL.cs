using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DTO;
namespace BLL
{
    public class ChiTietKho_BLL
    {
        ChiTietKho_DAL ct = new ChiTietKho_DAL();

        public Result KiemTraSoLuong(string MaHang, string soluong)
        {
            if (string.IsNullOrEmpty(MaHang))
                return Result.EMPTY;
            return ct.KiemTraSoLuong(MaHang, soluong);
        }

         public List<ChiTietKho> GetSoLuong(string maHang)
        {
            return ct.GetChiTietKhoByCondition(maHang);                                                    
        }

         public List<Kho_DTO> getctkho()
         {
             return ct.Getctkho();
         }

         public int laySoLuong(string maHang, string soLuong)
         {
             return ct.LaySoLuong(maHang, soLuong);
         }

         public int laySoLuongHang(string maHang)
         {
             return ct.LaySoLuongHang(maHang);
         }



         public Result updateSoluongTru(string mahang, string soluong)
         {
             return ct.UpdateSoLuongTru(mahang, soluong);
         }

         public Result updateSoluongThem(string mahang, string soluong)
         {
             return ct.UpdateSoLuongThem(mahang, soluong);
         }

         public Result updateSoluongThem2(string mahang, string soluong)
         {
             return ct.UpdateSoLuongThem2(mahang, soluong);
         }

         public Result updateSoluongMH(string mahang, int soluong)
         {
            return ct.UpdateSoLuongMH(mahang, soluong);
         }

         public Result updateSoluonCong(string mahang, int soluong)
         {
             return ct.UpdateSoLuongCong(mahang, soluong);
         }

         public List<ChiTietKho> GetMatHang()
         {
             return ct.GetChiTietKho();
         }

         public Result InsertCTKho(string MaHang)
         {
             return ct.InsertCTKho(MaHang);
         }
    }
}
