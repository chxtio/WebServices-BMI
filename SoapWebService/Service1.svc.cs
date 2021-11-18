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

        // bmi = [weight(lb) / height(in) / height(in)] x 703
        public double myBMI(int height, int weight)
        {
            double BMI = (weight * 703.0) / (height * height); 

            return BMI;
        }

        public bmi myHealth(int height, int weight)
        {
            bmi BMI = new bmi();
            BMI.b = myBMI(height, weight);

            if (BMI.b < 18)
                BMI.risk = "You are underweight if BMI is < 18"; // Blue
            else if (BMI.b < 25)
                BMI.risk = "You are normal if BMI is ≥ 18 and < 25"; // Green
            else if (BMI.b < 30)
                BMI.risk = "You are pre-obese if BMI is between 25 and 30"; // Purple
            else
                BMI.risk = "You are obese if BMI is greater than 30"; // Red

            BMI.more = new string[3] { "https://www.cdc.gov/healthyweight/assessing/bmi/index.html", "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm", "https://www.ucsfhealth.org/education/body_mass_index_tool/" };

            return BMI;

        }

    }
}
