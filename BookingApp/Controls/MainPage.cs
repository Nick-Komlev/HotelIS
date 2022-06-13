using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wrapper;

namespace BookingApp
{
    public partial class MainPage : UserControl
    {
        public UDataTable TaskTable;

        public MainPage()
        {
            InitializeComponent();
            BackColor = Theme.PrimaryBackColor;
            Dock = DockStyle.Fill;
            ForeColor = Theme.PrimaryForeColor;

            AutoScroll = true;

            UserHeaderLabel.ForeColor = Theme.SecondryForeColor;
            FIOHeaderLabel.ForeColor = Theme.SecondryForeColor;
            LastAuthHeaderLabel.ForeColor = Theme.SecondryForeColor;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Dictionary<string, Control> columns = new Dictionary<string, Control>();
            List<TaskRow> tasks = new List<TaskRow>();

            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "22.05.2022 16:32"));
            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "22.05.2022 16:34"));
            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "22.05.2022 16:55"));
            tasks.Add(new TaskRow("Зарегистрировать заявку", "Система", "22.05.2022 18:52"));
            tasks.Add(new TaskRow("Зарегистрировать заявку", "Система", "23.05.2022 8:21"));
            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "23.05.2022 10:11"));
            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "23.05.2022 10:52"));
            tasks.Add(new TaskRow("Закрыть бронь", "Система", "24.05.2022 16:52"));
            tasks.Add(new TaskRow("Закрыть бронь", "Система", "24.05.2022 16:52"));
            tasks.Add(new TaskRow("Зарегистрировать заявку", "Система", "24.05.2022 16:58"));
            tasks.Add(new TaskRow("Зарегистрировать заявку", "Система", "25.05.2022 17:01"));
            tasks.Add(new TaskRow("Назначить номер гостю", "Система", "25.05.2022 17:01"));

            TaskTable = new UDataTable(typeof(TaskRow), true, 5);
            TaskTable.Dock = DockStyle.Fill;

            foreach (TaskRow task in tasks)
            {
                TaskTable.Add(task);
            }

            TaskTablePanel.Controls.Add(TaskTable);
        }


    }
}
