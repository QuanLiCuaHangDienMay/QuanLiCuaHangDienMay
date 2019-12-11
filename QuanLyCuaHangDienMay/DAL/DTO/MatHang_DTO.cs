using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class MatHang_DTO
    {
        public string MaHang { get; set; }
        public string TenMatHang { get; set; }
        public string MaLoaiMatHang { get; set; }
        public string TenLoaiMatHang { get; set; }
        public string DVT { get; set; }
        public decimal? GiaBan { get; set; }
        public decimal? GiaNhap { get; set; } 
        public string MaNhaCC { get; set; }
        public string TenNhaCC { get; set; }
        public byte? BaoHanh { get; set; }
        public string TinhTrangHang { get; set; }
    }
}
