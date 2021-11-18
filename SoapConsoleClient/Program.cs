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

            ServiceReference1.bmi newBMI = myClient.myHealth(150, 60);
            Console.WriteLine("BMI: " + newBMI.b);
            Console.WriteLine(newBMI.risk);
            Console.WriteLine(newBMI.more[1]);

            Console.ReadLine();
        }
    }
}
