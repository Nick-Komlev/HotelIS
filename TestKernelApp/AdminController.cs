using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Wrapper;

namespace TestKernelApp
{
    class AdminController : Controller
    {
        public AdminController()
        {
            Functionaluty.Add("Configure", Configure);
            Functionaluty.Add("LoadState", LoadState);
            Functionaluty.Add("CreateState", CreateState);
            Functionaluty.Add("CreateObject", CreateObject);
        }

        public override string ExecuteRequest(Request rqst)
        {
            return Functionaluty[rqst.Function](rqst.Parameters);
        }

        private string Configure(USerializableList paramls)
        {
            DBConnector dbc = new DBConnector();

            dbc.Configure();

            return CreateRequest("Admin", "Configure");
        }

        private string LoadState(USerializableList paramls)
        {
            DBConnector dbc = new DBConnector();
            USerializableList states = new USerializableList();

            foreach (object o in dbc.LoadState())
            {
                states.Add((o as State));
            }

            return CreateRequest("Admin", "LoadState", states);
        }

        private string CreateState(USerializableList paramls)
        {
            DBConnector dbc = new DBConnector();

            dbc.CreateState(paramls.Items[0].ToString());

            return CreateRequest("Admin", "CreateState", paramls);
        }

        private string CreateObject(USerializableList paramls)
        {
            DBConnector dbc = new DBConnector();

            dbc.CreateObject(paramls);

            return CreateRequest("Admin", "CreateObject", paramls);
        }
    }
}
