using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrapper;

namespace TestKernelApp
{
    class ReceptionController : Controller
    {
        public ReceptionController()
        {

        }

        public override string ExecuteRequest(Request rqst)
        {
            return Functionaluty[rqst.Function](rqst.Parameters);
        }

    }
}
