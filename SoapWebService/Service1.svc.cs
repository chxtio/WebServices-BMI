using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double piValue()
        {
            return Math.PI;
        }
        public int absValue(int x)
        {
            if (x >= 0)
                return x;
            else
                return (-x);
        }
        public int add2(int x, int y)
        {
            int sum = 0;
            sum = x + y;
            return sum;
        }
        public results computeStat(string str)
        {
            results res = new results();
            int d = 0, u = 0, l = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    u = u + 1;
                }
                if (Char.IsLower(str[i]))
                {
                    l = l + 1;
                }
                if (Char.IsDigit(str[i]))
                {
                    d = d + 1;
                }
            }
            res.digits = d;
            res.upper_case_letters = u;
            res.lower_case_letters = l;

            return res;
        }
    }
}
