using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class Kho_DTO
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string MaHang { get; set; }
        public string TenMatHang { get; set; }
        public int? SoLuong { get; set; }
    }
}
