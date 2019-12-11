using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienMay.Class
{
    public class ClassProgram
    {
        ClassProgram cl = new ClassProgram();
        public ClassProgram() { }

        public bool KT(string kt)
        {
            if (string.IsNullOrEmpty(kt))
                return true;
            return false;
        }
    }
}
