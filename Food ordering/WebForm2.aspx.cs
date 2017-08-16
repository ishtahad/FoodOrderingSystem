using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_ordering
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SetImageUrl();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //SetImageUrl();
        }

        private void SetImageUrl()
        {
           /* Random _rand = new Random();
            int i = _rand.Next(2,4);
            Image1.ImageUrl = "~/menuimg/" + i.ToString() + ".jpg";*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("menu.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UserOrder.aspx");
        }

       

        protected void aboutusbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void usercontact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        protected void usercart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void reg_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");

        }

        protected void MENU_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void contact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        protected void LOGOUT_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void MYCART_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void ABOUT_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }

        protected void my_click(object sender, EventArgs e)
        {
            Response.Redirect("UserOrder.aspx");
        }
    }
}