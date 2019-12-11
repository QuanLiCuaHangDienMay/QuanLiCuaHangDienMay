using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public class MailTextBox : TextBox
    {
        private ErrorProvider errorProvider1=new ErrorProvider();

        public MailTextBox()
        {
            this.KeyPress += MailTextBox_KeyPress;
            this.Validated += MailTextBox_Validated;
            this.Validating += MailTextBox_Validating;
            
        }


        private void MailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            string a = this.Text.ToString();
            if (string.IsNullOrEmpty(this.Text))
            {
                e.Cancel = true;
                this.Focus();
                //errorProvider1.Clear();
                errorProvider1.SetError(this, "Chua nhap lieu");
            }
            else
            {
                bool match = Regex.IsMatch(a, ".com$");
                bool match1 = Regex.IsMatch(a, "@");
                if (match == false && match1 == false)
                {
                    //errorProvider1.Clear();
                    errorProvider1.SetError(this, "thieu .com va @");
                }
                if (match == false && match1 == true)
                {
                    //errorProvider1.Clear();
                    errorProvider1.SetError(this, "thieu .com");
                }
                if (match1 == false && match == true)
                {
                    //errorProvider1.Clear();
                    errorProvider1.SetError(this, "thieu @");
                }
                if (match == true && match1 == true)
                {
                    e.Cancel = false;
                    // errorProvider1.Clear();
                    errorProvider1.SetError(this, null);
                }
            }
        }

        private void MailTextBox_Validated(object sender, EventArgs e)
        {
            
            //string a=this.Text.ToString();
            //bool match = Regex.IsMatch(a, ".com$");
            //if (match == false)                          
            //    MessageBox.Show("thieu .com");
        }

        private void MailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }
    }
    
}
