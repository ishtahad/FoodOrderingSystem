using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_ordering
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetImageUrl();
            }
        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("login.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Response.Redirect("menu.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SetImageUrl();
        }

        private void SetImageUrl()
        {
            Random _rand = new Random();
            int i = _rand.Next(2, 4);
            Image1.ImageUrl = "~/menuimg/" + i.ToString() + ".jpg";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
            
        }

    }
}