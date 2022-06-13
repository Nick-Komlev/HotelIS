using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Wrapper
{
    public class UButton : Button
    {
        public UButton() : base()
        {
            BackColor = Theme.DarkBackColor;
            ForeColor = Theme.PrimaryForeColor;
            Font = new Font("Arial", 10);
        }

    }
}
