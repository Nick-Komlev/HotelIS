using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using Wrapper;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class StateChoiceDialogue : Form
    {
        public object StateChoosed;
        private List<State> States = new List<State>();
        private bool load = false;

        public StateChoiceDialogue()
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
                LoadState();
                Fill(States);
            }

            load = true;
        }

        private void LoadState()
        {
            AdminWatcher.Home.requestMaker("LoadState");
            USerializableList response = AdminWatcher.Home.Response;

            foreach (State state in response.Items)
                States.Add(state);
        }

        private void Fill(List<State> states)
        {
            StateListBox.Items.Clear();
            StateListBox.Items.AddRange(states.ToArray());
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            StateChoosed = StateListBox.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RenewBtn_Click(object sender, EventArgs e)
        {
            LoadState();
            SearchTB.Text = "";
            Fill(States);
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (SearchTB.Text != "")
            {
                Fill(States.FindAll(s => s.Name.Contains(SearchTB.Text)));
            }
            else
            {
                Fill(States);
            }
        }
    }
}
