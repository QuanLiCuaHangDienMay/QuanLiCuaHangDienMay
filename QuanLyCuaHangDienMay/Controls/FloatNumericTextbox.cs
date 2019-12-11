﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public class FloatNumericTextbox : TextBox
    {
        
        public FloatNumericTextbox()
        {
            this.KeyPress += NumericTextbox_KeyPress;
        }

        void NumericTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }

}
