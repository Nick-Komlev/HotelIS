using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlatform
{
    class MenuNavigator
    {
        private List<MethodInvoker> Methods = new List<MethodInvoker>();

        public MenuNavigator()
        {
            Methods.Add(ShowThis);
        }

        private void ShowThis()
        {

        }

        public void Execute(int tag)
        {
            Methods[tag]();
        }

    }
}
