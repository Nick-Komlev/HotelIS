using System.Windows.Forms;

namespace Wrapper
{
    public class ToolsMenu : Panel
    {
        private Form Platform;
        public ToolsMenu(Form platform)
        {
            Platform = platform;
            Dock = DockStyle.Fill;
            ForeColor = Theme.PrimaryForeColor;
            Padding = new Padding(0, 12, 0, 0);
            AutoScroll = true;
        }

        public void ElementCLick(MenuElementClickable sender)
        {
            Platform.Controls.Add(sender.UControl);
        }
    }
}
