using System.Windows.Forms;

namespace Wrapper
{
    public class UTextBox : TextBox
    {
        public UTextBox() : base()
        {
            BackColor = Theme.SecondryBackColor;
            ForeColor = Theme.PrimaryForeColor;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
