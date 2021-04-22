using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenValleySystem
{
    public partial class CustomerPortal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome, " + Session["UserName"].ToString();
        }
        protected void btnToLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("customerLogin.aspx?loggedout=true");
        }
        protected void btnToUpdatePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerupdatePassword.aspx");
        }
    }
}