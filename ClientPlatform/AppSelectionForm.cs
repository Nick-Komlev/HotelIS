using System;
using Wrapper;
using System.Drawing;
using System.Windows.Forms;

namespace ClientPlatform
{
    public partial class AppSelectionForm : Form
    {
        public AppSelectionForm()
        {
            InitializeComponent();
        }

        private void AppSelectionForm_Load(object sender, EventArgs e)
        {
            BackColor = Theme.SecondryBackColor;
            Size = new Size(800, 700);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Panel pnAdmin = new Panel();
            Panel pnBooking = new Panel();
            Panel pnReception = new Panel();
            Panel pnCashier = new Panel();

            pnAdmin.Tag = "Admin";
            pnBooking.Tag = "Booking";
            pnReception.Tag = "Reception";
            pnCashier.Tag = "Cashier";

            Control[] pnList = new Control[] { pnAdmin, pnBooking, pnReception, pnCashier };

            Controls.AddRange(pnList);

            int place = 0;
            foreach(Panel pn in pnList)
            {
                PlaceButtons(pn, place);
                place++;
            }

            ExitBtn.Location = new Point(350, 600);
        }

        private void PlaceButtons(Panel pn, int place)
        {
            pn.Size = new Size(200, 200);
            pn.BorderStyle = BorderStyle.FixedSingle;
            pn.MouseEnter += Pn_MouseEnter;
            pn.MouseLeave += Pn_MouseLeave;

            pn.Click += Pn_Click;

            int x = 175 + (place % 2) * 250;
            int y = 75 + (place / 2) * 250;
            pn.Location = new Point(x, y);
        }

        private void Pn_Click(object sender, EventArgs e)
        {
            Panel pn = (sender as Panel);
            PlatformForm form = new PlatformForm(pn.Tag.ToString(), this);
            form.Show();
            Hide();
        }

        private void Pn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Theme.SecondryBackColor;
        }

        private void Pn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Theme.PrimaryBackColor;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
