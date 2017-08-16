using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food_ordering.App_Code.AdminLogin;

namespace Food_ordering
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        AdminLogDAO AdminLogDao = new AdminLogDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string adminID = usernametxt.Text;

            string adminPassword = passwordtxt.Text;

            // Session["passuser"] = usernametxt.Text;

            // LogDao.LogUser(new LogDTO(userName,  password));
            /* cmd.CommandText = "select * from Users where userName='"+ usernametxt.Text + "' and password='" + passwordtxt.Text + "'";
             cmd.Connection = con;
             sda.SelectCommand = cmd;
             sda.Fill(ds, "Users");
             if(ds.Tables[0].Rows.Count > 0)
             {
                 Response.Redirect("home.aspx");
             }
             else
             {
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
             } */
            if (AdminLogDao.LogAdmin(new AdminLogDTO(adminID, adminPassword)) == true)
            {
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
            }

        }
    }
}