using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Wrapper
{
    public class UChooserLink : Label
    {
        public object ChoosedObject;
        public FormCaller Caller;
        public Form Chooser;

        public UChooserLink() : base()
        {
            Text = "Выбрать";
            ForeColor = Color.FromKnownColor(KnownColor.Highlight);
            Font = new Font("Arial", 12);
            Font = new Font(Font, FontStyle.Underline);
            Location = new Point(Location.X, Location.Y + 3);
            Cursor = Cursors.Hand;
            Click += UChooserLink_Click;
        }

        public void SetParameters(FormCaller formCaller, Form form)
        {
            Caller = formCaller;
            Chooser = form;
        }

        private void UChooserLink_Click(object sender, EventArgs e)
        {
            ChoosedObject = Caller(Chooser);
            if (ChoosedObject != null)
            {
                Text = ChoosedObject.ToString();
                ForeColor = Theme.PrimaryForeColor;
            }
        }

        public delegate object FormCaller(Form form);

    }
}
