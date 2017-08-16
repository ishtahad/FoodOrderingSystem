using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_ordering
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminuser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUser.aspx");
        }



        protected void admincontact_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminContact.aspx");
        }

        protected void adminres_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminRestaurant.aspx");
        }

        protected void adminorder_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminOrder.aspx");
        }

        protected void adminlogoutbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}