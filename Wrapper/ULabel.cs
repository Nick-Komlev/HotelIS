using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Wrapper
{
    public class ULabel : Panel
    {
        private Label lb;
        private string text;
        public new string Text
        {
            get=>text;
            set
            {
                lb.Text = value;
                text = value;
            }
        }

        public ULabel() : base()
        {
            lb = new Label();
            lb.AutoSize = true;
            lb.Location = new Point(lb.Location.X, lb.Location.Y + 5);
            Controls.Add(lb);

        }



    }
}
