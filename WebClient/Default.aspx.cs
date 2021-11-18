using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Compute BMI Button Clicked
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client myClient = new ServiceReference2.Service1Client("BasicHttpBinding_IService1"); // Portname
            int height = Int32.Parse(TextBox1.Text);
            int weight = Int32.Parse(TextBox2.Text);
            Double BMI = myClient.myBMI(height, weight);

            TextBox3.Text = BMI.ToString();
        }

        // Height input
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Weight Input
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // BMI Output
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}