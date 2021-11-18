using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            // Console.WriteLine(myClient.add2(1, 3));

            Console.WriteLine(myClient.myBMI(150, 60));
            Console.ReadLine();
        }
    }
}
