using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrapper;

namespace TestKernelApp
{
    class BookingController : Controller
    {
        public BookingController()
        {
            Functionaluty.Add("LoadGuest", LoadGuest);
        }

        public override string ExecuteRequest(Request rqst)
        {
            return Functionaluty[rqst.Function](rqst.Parameters);
        }

        private string LoadGuest(USerializableList paramls)
        {
            DBConnector dbc = new DBConnector();
            USerializableList guests = new USerializableList();

            foreach (object o in dbc.LoadGuest())
            {
                guests.Add((o as UDObject));
            }

            return CreateRequest("Booking", "LoadGuest", guests);
        }

    }
}
