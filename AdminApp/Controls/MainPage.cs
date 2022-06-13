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

namespace AdminApp
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
            // Dictionary<string, Control> columns = new Dictionary<string, Control>();
            List<TaskRow> tasks = new List<TaskRow>
            {
                new TaskRow("Настроить БП Регистрация", "Система", "25.05.2022 16:52"),
                new TaskRow("Настроить БП Выписка", "Система", "25.05.2022 16:52"),
                new TaskRow("Настроить БП Заселение", "Система", "25.05.2022 16:52"),
                new TaskRow("Настроить БП Оформление услуги", "Система", "25.05.2022 16:52"),
                new TaskRow("Создать объект Услуги", "Система", "22.05.2022 8:21"),
                new TaskRow("Настроить модель для объекта Услуги", "Система", "22.05.2022 8:21")
            };

            TaskTable = new UDataTable(typeof(TaskRow), true, 5)
            {
                Dock = DockStyle.Fill
            };

            foreach (TaskRow task in tasks)
            {
                TaskTable.Add(task);
            }

            TaskTablePanel.Controls.Add(TaskTable);
        }


    }
}
