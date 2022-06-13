using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using Wrapper;
using System.Runtime.Serialization;

namespace ClientPlatform
{
    public partial class PlatformForm : Form
    {
        private ClientSocket clientSocket;
        private string App;
        private UInterface AppInterface;
        private Form Home;

        private bool Exit = true;

        public PlatformForm(string app, Form home)
        {
            InitializeComponent();
            Text = app;
            App = app;
            Home = home;
            PlatformWatcher.Home = this;
        }

        
        private void PlatformForm_Load(object sender, EventArgs e)
        {
            WorkPlacePanel.BackColor = Theme.PrimaryBackColor;
            LeftPanel.BackColor = Theme.SecondryBackColor;
            menuStrip1.BackColor = Theme.DarkBackColor;

            menuStrip1.ForeColor = Theme.PrimaryForeColor;
            WorkPlacePanel.ForeColor = Theme.PrimaryForeColor;
            LeftPanel.ForeColor = Theme.PrimaryForeColor;
            ToolPanel.ForeColor = Theme.PrimaryForeColor;
            MenuHeaderPanel.ForeColor = Theme.PrimaryForeColor;

            LinePanel.BackColor = Theme.PrimaryForeColor;
            MenuHeaderLabel.ForeColor = Theme.PrimaryForeColor;

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Theme.PrimaryForeColor;
            }

            if (App == "Admin")
                AppInterface = new AdminApp.UInterfaceAdmin();
            else if (App == "Booking")
                AppInterface = new BookingApp.UInterfaceBooking();
            else if (App == "Cashier")
                AppInterface = new CashierApp.UInterfaceCashier();
            else if (App == "Reception")
                AppInterface = new ReceptionApp.UInterfaceReception();

            ToolPanel.Controls.Add(AppInterface.BindToPlatform(this));
            UInterface.RequestMaker requestMaker = CreateRequest;
            AppInterface.GetRequestFunc(requestMaker);
        }

        private void PlatformForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void PlatformForm_ControlAdded(object sender, ControlEventArgs e)
        {
            Controls.Remove(e.Control);
            WorkPlacePanel.Controls.Clear();
            WorkPlacePanel.Controls.Add(e.Control);
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit = false;
            this.Close();
            Home.Show();
        }

        private void PlatformForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Exit)
                Application.Exit();
        }

        private void КонфигурироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRequest("Configure");
        }

        public void CreateRequest(string func, USerializableList paramls = null)
        {
            string path = @".\requestFile.xml";
            string rqstText;

            Request rqst = new Request(App, func, path, paramls);
            rqstText = rqst.GetRequest(path);

            clientSocket = new ClientSocket();
            clientSocket.StartConnection(rqstText);
        }

        public void GetResponse(string response)
        {
            string path = @".\RequestFile.xml";

            try
            {
                File.Delete(path);
            }
            catch { }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(response);
            }

            Request rqst;
            XmlSerializer formatter = new XmlSerializer(typeof(Request));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                rqst = (Request)formatter.Deserialize(fs);

            File.Delete(path);

            AppInterface.GetResponse(rqst);
        }
    }

    public static class PlatformWatcher
    {
        public static PlatformForm Home;
    }
}
