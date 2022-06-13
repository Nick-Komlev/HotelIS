using System.ServiceProcess;

namespace KernelService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new KernelServer()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
