using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrapper;

namespace TestKernelApp
{
    class CashierController : Controller
    {
        public CashierController()
        {

        }

        public override string ExecuteRequest(Request rqst)
        {
            return Functionaluty[rqst.Function](rqst.Parameters);
        }


    }
}
