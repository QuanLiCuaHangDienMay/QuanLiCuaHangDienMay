using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Kho_DAL : Base_DAL
    {
        //Lấy danh sách kho
        public List<Kho> GetKho()
        {
            return (from kho in qlch.Khos select kho).ToList<Kho>();
        }

       
    }
}
