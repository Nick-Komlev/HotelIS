using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wrapper
{
    public partial class BSubprocess : UserControl
    {
        private string text;
        public new string Text
        {
            get => text;

            set
            {
                NameTB.Text = value;
                text = value;
            }

        }

        public BSubprocess()
        {
            InitializeComponent();
            BackColor = Theme.DarkBackColor;
            ForeColor = Theme.PrimaryForeColor;
            NameTB.BackColor = BackColor;
            NameTB.ForeColor = ForeColor;
        }
    }
}
