using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Store.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost("");

            serviceHost.Open();

            Console.WriteLine("\tService is Running....");
            Console.WriteLine("Press Any Key to Exit....");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
