using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Xml.Serialization;
using System.IO;
using Wrapper;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace BookingApp
{
    public partial class RequestRegistrationMaster : UserControl
    {
        private enum ModeEnum {MANUAL, GENERATION};
        private ModeEnum Mode;

        private UInterfaceBooking Home;

        private UDataTable GuestAttrTable;
        private UDataTable RoomTable;
        private UDataTable GuestTable;

        public RequestRegistrationMaster(UInterfaceBooking home)
        {
            InitializeComponent();
            Home = home;
            BackColor = Theme.PrimaryBackColor;
            Dock = DockStyle.Fill;
            ForeColor = Theme.PrimaryForeColor;

            AutoScroll = true;

            GuestLabel.ForeColor = Theme.SecondryForeColor;
            AttrLabel.ForeColor = Theme.SecondryForeColor;
            EntryDateLabel.ForeColor = Theme.SecondryForeColor;
            EscapeDateLabel.ForeColor = Theme.SecondryForeColor;
            GuestHeaderLabel.ForeColor = Theme.SecondryForeColor;
            PersonHeaderLabel.ForeColor = Theme.SecondryForeColor;
            RoomHeaderLabel.ForeColor = Theme.SecondryForeColor;
            ConfirmationPanel.BackColor = Theme.DarkBackColor;
            SaveLabel.Cursor = Cursors.Hand;

            GuestChooser.SetParameters(GetGuest, new GuestChoiceDialogue());
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {      
            
        }

        private void RequestRegistrationMaster_Load(object sender, EventArgs e)
        {
            RequestDialogue dialogue = new RequestDialogue();
            if (dialogue.ShowDialog() == DialogResult.Cancel)
                Home.CancelModeSelection();
            else
            {
                Mode = dialogue.ModeChoosed.ToString() == "Регистрация заявки вручную" ? ModeEnum.MANUAL : ModeEnum.GENERATION;
                FillControls();
            }
                
        }

        private void FillControls()
        {
            if (Mode == ModeEnum.MANUAL)
                return;
            else
            {

            }
        }

        public object GetGuest(Form form)
        {
            GuestChoiceDialogue dialogue = (GuestChoiceDialogue)form;
            if (form.ShowDialog() == DialogResult.Cancel)
                return null;
            else
                return dialogue.GuestChoosed;
        }
    }
}
