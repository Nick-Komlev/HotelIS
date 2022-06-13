using System.ServiceProcess;

namespace KernelService
{
    public partial class KernelServer : ServiceBase
    {
        public KernelServer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            AsynchronousSocket.StartListening();
        }

        protected override void OnStop()
        {
        }
    }
}
