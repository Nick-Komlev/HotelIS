using System.Windows.Forms;

namespace Wrapper
{
    public class UComboBox : ComboBox
    {
        public UComboBox() : base()
        {
            BackColor = Theme.SecondryBackColor;
            ForeColor = Theme.PrimaryForeColor;

            TextChanged += UComboBox_TextChanged;
        }

        private void UComboBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!Items.Contains(Text) && Items.Count > 0)
            {
                Text = Items[0].ToString();
            }
        }
    }
}
