using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Exercise_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);
            lblRes.Text = (num1 + num2).ToString("N");
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);
            lblRes.Text = (num1 - num2).ToString("N");
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);
            if (num1 == 0 || num2 == 0)
                lblRes.Text = "0.00";
            else
                lblRes.Text = (num1 / num2).ToString("N");
        }

        protected void btnModulus_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);
            if (num1 == 0 || num2 == 0)
                lblRes.Text = "0.00";
            else
                lblRes.Text = (num1 % num2).ToString("N");
        }
    }
}