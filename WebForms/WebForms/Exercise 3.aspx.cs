using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Exercise_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lstStuff.Items.Add(txtThing.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = lstStuff.SelectedItem.Value;
        }
    }
}