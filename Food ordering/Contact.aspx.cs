using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food_ordering.App_Code.Contact;

namespace Food_ordering
{
    public partial class Contact : System.Web.UI.Page
    {
        ContactDAO ContactDao = new ContactDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            string User_ID = Session["passuser"].ToString();
            //  string Ordered_by = "sakiftahmid";
            string Subject = subjecttxt.Text;
            // string Ordered_item = Session["passres"].ToString();
            // string Ordered_item = "biriani";
            // int Quantity = Convert.ToInt32(Session["passquan"].ToString());
            // int Quantity = 5;
            string Text = querytxt.Text;
           
            
                ContactDao.AddContact(new ContactDTO(User_ID, Subject, Text));
                Response.Redirect("WebForm2.aspx");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}