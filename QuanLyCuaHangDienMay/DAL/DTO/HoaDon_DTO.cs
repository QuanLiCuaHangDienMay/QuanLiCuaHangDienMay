using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class HoaDon_DTO
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime? NgayLapHD { get; set; }
        public decimal? GiamGiaTrucTiep { get; set; }
        public decimal? TongTien { get; set; }

    }
}
