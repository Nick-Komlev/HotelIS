using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Wrapper;
using System.Windows.Forms;

namespace BookingApp
{
    public partial class RequestDialogue : Form
    {
        public object ModeChoosed;

        public RequestDialogue()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Font = new Font("Arial", 10);
            ForeColor = Theme.PrimaryForeColor;

            object[] ls = new object[] { "Регистрация заявки вручную", "Регистрация заявки из пулла заявок" };
            LB.Items.AddRange(ls);

            OkBtn.Enabled = false;
        }

        private void LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkBtn.Enabled = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ModeChoosed = LB.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
