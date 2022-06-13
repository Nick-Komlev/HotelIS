using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Wrapper
{
    public class UListBox : ListBox
    { 
        public UListBox() : base()
        {
            BackColor = Theme.SecondryBackColor;
            ForeColor = Theme.PrimaryForeColor;
            BorderStyle = BorderStyle.FixedSingle;
            Font = new Font("Arial", 12);
        }
    }
}
