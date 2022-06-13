using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Wrapper;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class SubprocessEditor : Form
    {
        public UDataTable ReqTable;
        public UDataTable GateTable;

        public SubprocessEditor()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Font = new Font("Arial", 10);
            ForeColor = Theme.PrimaryForeColor;

            label1.ForeColor = Theme.SecondryForeColor;
            label2.ForeColor = Theme.SecondryForeColor;
            label3.ForeColor = Theme.SecondryForeColor;
            label4.ForeColor = Theme.SecondryForeColor;
            label5.ForeColor = Theme.SecondryForeColor;
        }

        private void SubprocessEditor_Load(object sender, EventArgs e)
        {
            Dictionary<string, Control> columns = new Dictionary<string, Control>();
            UComboBox cmb = new UComboBox();
            columns.Add("     Описание     ", new UTextBox());
            UChooserLink link = new UChooserLink();
            UChooserLink.FormCaller getState = GetState;
            columns.Add("  Состояние  ", link);
            link.SetParameters(getState, new StateChoiceDialogue());
            cmb.Items.AddRange(new List<string> { "должен быть", "должен стать" }.ToArray());
            columns.Add("Требование", cmb);

            
            columns.Add("  Объект  ", link);
            ReqTable = new UDataTable(columns)
            {
                Dock = DockStyle.Fill
            };

            panel1.Controls.Add(ReqTable);



            columns = new Dictionary<string, Control>
            {
                { "  Объект  ", link }
            };
            GateTable = new UDataTable(columns)
            {
                Dock = DockStyle.Fill
            };

            panel2.Controls.Add(GateTable);

            uChooserLink1.SetParameters(getState, new StateChoiceDialogue());
        }

        public object GetState(Form form)
        {
            StateChoiceDialogue dialogue = (StateChoiceDialogue)form;
            if (form.ShowDialog() == DialogResult.Cancel)
                return null;
            else
                return dialogue.StateChoosed;
        }
    }
}
