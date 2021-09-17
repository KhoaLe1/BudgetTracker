using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FinanceTracker
{
    class vBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
