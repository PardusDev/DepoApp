using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.CustomControls
{
    public class CurrencyTextBox : TextBox
    {
        public event EventHandler TextChanged;
        public event KeyPressEventHandler KeyPress;


        public CurrencyTextBox()
        {
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Text = Convert.ToDouble(0).ToString("N2");

            // Events
            base.TextChanged += new EventHandler(CurrencyTextBox_TextChanged);
            base.KeyPress += new KeyPressEventHandler(CurrencyTextBox_KeyPress);
        }

        protected virtual void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // Just allow numbers and some keys like backspace, delete, etc.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.SelectionStart;
            int textLength = this.Text.Length;

            if (this.Text == "")
            {
                this.Text = "0";
            }
            else
            {
                this.Text = Convert.ToDouble(this.Text).ToString("N2");
            }

            /*
             * This is a trick to prevent cursor from jumping to the end of the text but its not useful
            if (this.Text.Length > 3)
            {
                this.SelectionStart = this.Text.Length - 3;
            }
            */

            // Return the cursor old position
            if (this.Text.Length >= textLength + 1)
            {
                selectionStart = selectionStart + 1;
            } else if (this.Text.Length <= textLength - 1)
            {
                selectionStart = selectionStart - 1;
            }
            this.SelectionStart = selectionStart;
            this.SelectionLength = 0;
        }
    }
}
