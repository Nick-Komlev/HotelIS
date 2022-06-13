using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace TestKernelApp
{
    public class Program
    {
        private static AsynchronousSocket Server;

        static void Main()
        {
            Server = new AsynchronousSocket();
            Server.StartListening();
        }

    }
}
