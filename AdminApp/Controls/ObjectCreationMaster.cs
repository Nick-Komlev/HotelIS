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
    public partial class ObjectCreationMaster : UserControl
    {
        public UDataTable AttrTable;
        public UDataTable StateTable;
        private List<UObject> Objects;

        public ObjectCreationMaster()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Dock = DockStyle.Fill;
            ForeColor = Theme.PrimaryForeColor;

            AutoScroll = true;

            ObjNameLabel.ForeColor = Theme.SecondryForeColor;
            PrefixLabel.ForeColor = Theme.SecondryForeColor;
            DescrLabel.ForeColor = Theme.SecondryForeColor;
            AttrHeaderLabel.ForeColor = Theme.SecondryForeColor;
            StateHeaderLabel.ForeColor = Theme.SecondryForeColor;
            ConfirmationPanel.BackColor = Theme.DarkBackColor;
            SaveLabel.Cursor = Cursors.Hand;

            Dictionary<string, Control> columns = new Dictionary<string, Control>();
            UComboBox cmb = new UComboBox();
            cmb.Items.AddRange(new List<string> { "int", "string", "bool", "date", "FK" }.ToArray());
            columns.Add("Тип данных", cmb);
            columns.Add("Имя", new UTextBox());
            AttrTable = new UDataTable(columns)
            {
                Dock = DockStyle.Fill
            };

            columns = new Dictionary<string, Control>();
            UChooserLink link = new UChooserLink();

            UChooserLink.FormCaller getState = GetState;
            link.SetParameters(getState, new StateChoiceDialogue());
            columns.Add("Статус", link);
            StateTable = new UDataTable(columns);
            StateTable.Dock = DockStyle.Fill;

            AttrTablePanel.Controls.Add(AttrTable);
            StateTablePanel.Controls.Add(StateTable);
        }


        public object GetState(Form form)
        {
            StateChoiceDialogue dialogue = (StateChoiceDialogue)form;
            if (form.ShowDialog() == DialogResult.Cancel)
                return null;
            else
                return dialogue.StateChoosed;
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {
            //LoadObject();
            if (ObjNameTB.Text.Length > 0 && PrefixTB.Text.Length > 0)
            {
                USerializableList list = new USerializableList();
                list.Add(new UString(ObjNameTB.Text));
                list.Add(new UString(PrefixTB.Text));
                list.Add(new UString(DescrTB.Text));
                foreach (DataTableRow row in AttrTable.Rows)
                {
                    if (row.Controls["Имя"] != null)
                        list.Add(new UAttribute(((DataTableCell)row.Controls["Имя"]).Value, ((DataTableCell)row.Controls["Тип данных"]).Value));
                }
                list.Add(new UString("статусы"));
                foreach (DataTableRow row in StateTable.Rows)
                {
                    if (row.Controls["Статус"] != null)
                        list.Add((((DataTableCell)row.Controls["Статус"]).Controls[0] as UChooserLink).ChoosedObject as State);
                }

                AdminWatcher.Home.requestMaker("CreateObject", list);
            }
            
        }

        private void LoadObject()
        {
            AdminWatcher.Home.requestMaker("LoadObject");
            USerializableList response = AdminWatcher.Home.Response;

            foreach(UObject obj in response.Items)
                Objects.Add(obj);
        }
    }
}
