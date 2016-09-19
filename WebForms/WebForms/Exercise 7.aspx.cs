using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Exercise_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chkS_CheckedChanged(object sender, EventArgs e)
        {
            txtS.Enabled = chkS.Checked;
        }

        protected void chkM_CheckedChanged(object sender, EventArgs e)
        {
            txtM.Enabled = chkM.Checked;
        }

        protected void chkL_CheckedChanged(object sender, EventArgs e)
        {
            txtL.Enabled = chkL.Checked;
        }

        protected void chkXL_CheckedChanged(object sender, EventArgs e)
        {
            txtXL.Enabled = chkXL.Checked;
        }

        protected void chkXXL_CheckedChanged(object sender, EventArgs e)
        {
            txtXXL.Enabled = chkXXL.Checked;
        }

        protected void btnCalcCost_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal NORM_SHIRT_COST = 26M;
                const decimal XXL_SHIRT_COST = 30M;
                const decimal TAX_RATE = 1.07M;

                decimal total = 0;

                if (chkS.Checked)
                    total += NORM_SHIRT_COST * decimal.Parse(txtS.Text);
                if (chkM.Checked)
                    total += NORM_SHIRT_COST * decimal.Parse(txtM.Text);
                if (chkL.Checked)
                    total += NORM_SHIRT_COST * decimal.Parse(txtL.Text);
                if (chkXL.Checked)
                    total += NORM_SHIRT_COST * decimal.Parse(txtXL.Text);
                if (chkXXL.Checked)
                    total += XXL_SHIRT_COST * decimal.Parse(txtXXL.Text);

                lblCost.Text = (total * TAX_RATE).ToString("C");
            }
            catch
            {
                lblCost.Text = "Invalid Quantity";
            }
        }
    }
}