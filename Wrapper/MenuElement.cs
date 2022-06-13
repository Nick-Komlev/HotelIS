using System.Windows.Forms;
using System.Drawing;

namespace Wrapper
{
    public class MenuElement : Panel
    {
        protected Label lb;

        public MenuElement(string label)
        {
            Dock = DockStyle.Top;


            lb = new Label
            {
                Text = label,
                AutoSize = true
            };

            Controls.Add(lb);
        }

        public override string ToString()
        {
            return "MenuElement " + lb.Text;
        }
    }

    public class MenuElementClickable : MenuElement
    {
        public UserControl UControl;

        public MenuElementClickable(string label, UserControl uControl) : base(label)
        {
            UControl = uControl;

            lb.Location = new Point(20, 5);
            Height = 30;

            MouseEnter += Pn_MouseEnter;
            MouseLeave += Pn_MouseLeave;
            lb.MouseEnter += Lb_MouseEnter;
            lb.MouseLeave += Lb_MouseLeave;
            Click += Pn_Click;
            lb.Click += Lb_Click;
        }
        public void OnElemClick()
        {
            Pn_Click(this, new System.EventArgs());
        }

        private void Lb_Click(object sender, System.EventArgs e)
        {
            Pn_Click((sender as Label).Parent, e);
        }

        private void Pn_Click(object sender, System.EventArgs e)
        {
            (Parent as ToolsMenu).ElementCLick(sender as MenuElementClickable);
        }

        private void Pn_MouseEnter(object sender, System.EventArgs e)
        {
            (sender as Panel).BackColor = Theme.PrimaryBackColor;
        }

        private void Lb_MouseEnter(object sender, System.EventArgs e)
        {
            (sender as Label).Parent.BackColor = Theme.PrimaryBackColor;
        }

        private void Pn_MouseLeave(object sender, System.EventArgs e)
        {
            (sender as Panel).BackColor = Theme.SecondryBackColor;
        }

        private void Lb_MouseLeave(object sender, System.EventArgs e)
        {
            (sender as Label).Parent.BackColor = Theme.SecondryBackColor;
        }

        public override string ToString()
        {
            return "MenuElementClickable " + lb.Text;
        }

    }

    public class MenuElementHeader : MenuElement
    {
        public MenuElementHeader(string label) : base(label)
        {
            lb.Location = new Point(9, 20);
            Height = 50;

            lb.ForeColor = Theme.SecondryForeColor;
            lb.Font = new Font(lb.Font, FontStyle.Bold);
        }

        public override string ToString()
        {
            return "MenuElementHeader " + lb.Text;
        }

    }
}
