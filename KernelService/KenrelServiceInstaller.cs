using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

namespace KernelService
{
    [RunInstaller(true)]
    public partial class KenrelServiceInstaller : Installer
    {

        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;

        public KenrelServiceInstaller()
        {
            InitializeComponent();

            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalService;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "KernelService";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
