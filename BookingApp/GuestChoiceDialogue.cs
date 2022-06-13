using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using Wrapper;
using System.Windows.Forms;

namespace BookingApp
{
    public partial class GuestChoiceDialogue : Form
    {
        public object GuestChoosed;
        private List<UDObject> Guests = new List<UDObject>();
        private bool load = false;

        public GuestChoiceDialogue()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Font = new Font("Arial", 10);
            ForeColor = Theme.PrimaryForeColor;
        }

        private void StateChoiceDialogue_Load(object sender, EventArgs e)
        {
            if (!load)
            {
                LoadGuest();
                Fill(Guests);
            }
            load = true;
        }

        private void LoadGuest()
        {
            BookingWatcher.Home.requestMaker("LoadGuest");
            USerializableList response = BookingWatcher.Home.Response;
            
            foreach (UDObject guest in response.Items)
            {
                Guests.Add(guest);
            }
        }

        private void Fill(List<UDObject> guests)
        {
            StateListBox.Items.Clear();
            StateListBox.Items.AddRange(guests.ToArray());
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            GuestChoosed = StateListBox.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RenewBtn_Click(object sender, EventArgs e)
        {
            LoadGuest();
            SearchTB.Text = "";
            Fill(Guests);
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (SearchTB.Text != "")
            {
                Fill(Guests.FindAll(s => s.ToString().Contains(SearchTB.Text)));
            }
            else
            {
                Fill(Guests);
            }
        }
    }
}
