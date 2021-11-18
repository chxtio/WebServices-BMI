using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
     [OperationContract]
        double piValue();
        [OperationContract]
        int absValue(int x);
        [OperationContract]
        int add2(int x, int y);

        [OperationContract]
        results computeStat(string str);

    }

    [DataContract]
    public class results
    {
        [DataMember]
        public int digits { get; set; }
        [DataMember]
        public int upper_case_letters { get; set; }

        [DataMember]
        public int lower_case_letters { get; set; }
    }
}
