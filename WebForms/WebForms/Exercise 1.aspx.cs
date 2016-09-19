using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Exercise_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            lblDetails.Text = "<div><h4>Sarasota has a lot to offer!</h4><ul><li>Siesta Key Beach</li><li>St.Armands Circle</li><li>Tons of restaurants</li></ul></div>";
        }
    }
}