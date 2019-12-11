using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls
{
    public class DataGridViewChanLeKhacMau:DataGridView
    {
        public DataGridViewChanLeKhacMau()
        {
            this.doimau();
        }
        public void doimau()
        {
            this.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }
    }
}
