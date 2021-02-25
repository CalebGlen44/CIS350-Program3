using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program3
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("LoginPage.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("RegistrationForm.aspx");
        }
    }
}