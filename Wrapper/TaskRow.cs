using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper
{
    public class TaskRow
    {
        public string Задача;
        public string Назначил;
        public string Дата;

        public TaskRow(string task, string who, string data)
        {
            Задача = task;
            Назначил = who;
            Дата = data;
        }
    }
}
