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

namespace AdminApp
{
    public partial class StateCreationMaster : UserControl
    {
        public UDataTable StateTable;
        private List<State> States;
        private bool load = false;

        public StateCreationMaster()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Dock = DockStyle.Fill;
            ForeColor = Theme.PrimaryForeColor;

            AutoScroll = true;

            StateNameLabel.ForeColor = Theme.SecondryForeColor;
            StateHeaderLabel.ForeColor = Theme.SecondryForeColor;
            ConfirmationPanel.BackColor = Theme.DarkBackColor;
            SaveLabel.Cursor = Cursors.Hand;

            StateTable = new UDataTable(typeof(State), true);
            StateTable.Dock = DockStyle.Fill;

            StateTablePanel.Controls.Add(StateTable);

        }


        private void SaveLabel_Click(object sender, EventArgs e)
        {
            if (StateNameTB.Text == "")
            {
                MessageBox.Show("Незаполненное поле имени");
            }
            else
            {
                if (States.FindAll(s => s.Name.Contains(StateNameTB.Text)).Count > 0)
                {
                    MessageBox.Show("Уже существует состояние с таким именем");
                }
                else
                    CreateState();
            }
        }

    private void CreateState()
        {
            USerializableList ls = new USerializableList();
            ls.Add(new UString(StateNameTB.Text));

            AdminWatcher.Home.requestMaker("CreateState", ls);
            StateNameTB.Text = "";
            RenewBtn.PerformClick();
        }

        private void LoadState()
        {
            AdminWatcher.Home.requestMaker("LoadState");
            USerializableList response = AdminWatcher.Home.Response;
            States = new List<State>();

            foreach(State state in response.Items)
                States.Add(state);
        }

        private void Fill(List<State> states)
        {
            StateTable.Clear();
            foreach (State state in States)
            {
                StateTable.Add(state);
            }
        }

        private void StateCreationMaster_Load(object sender, EventArgs e)
        {
            if (!load)
            {
                LoadState();
                Fill(States);
            }
            load = true;
        }

        private void RenewBtn_Click(object sender, EventArgs e)
        {
            LoadState();
            Fill(States);
        }
    }
}
