using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfTestLib;

namespace SrvHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri addr = new Uri("http://localhost:8000/Start");
            ServiceHost host = new ServiceHost(typeof(CalcSrv), addr);
            try
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalcSrv");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled=true
                };
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("Service is ready!");
                Console.WriteLine($"Enter to terminate service\n");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine(ce.Message);
                host.Abort();
            }
        }
    }
}
