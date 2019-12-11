using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Base_DAL
    {
        protected qlCuaHangDienMayDataContext qlch = new qlCuaHangDienMayDataContext();
        private const string PUBLIC_KEY = "CHQ";
        public Base_DAL() { }
    }
}
