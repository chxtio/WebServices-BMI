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
        double myBMI(int height, int weight); // calculates the BMI.

        [OperationContract]
        bmi myHealth(int height, int weight); //this API returns the bmi structure,]


    }

    [DataContract]
    public class bmi
    {
        [DataMember]
        public double b { get; set;}
        [DataMember]
        public string risk { get; set; }
        [DataMember]
        public string[] more { get; set; }
}

}
