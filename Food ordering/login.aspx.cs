using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Food_ordering.App_Code.Login;

namespace Food_ordering
{
    public partial class login : System.Web.UI.Page
    {
        LogDAO LogDao = new LogDAO();
        //  SqlCommand cmd = new SqlCommand();
        //SqlConnection con = new SqlConnection();
        //SqlDataAdapter sda = new SqlDataAdapter();
        // DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
          //  String connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";
          //  con = new SqlConnection(connectionString);
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string userName = usernametxt.Text;

            string password = passwordtxt.Text;

            Session["passuser"] = usernametxt.Text;
            // cmd.CommandText = "select * from Users where userName='"+ usernametxt.Text + "' and password='" + passwordtxt.Text + "'";
            //cmd.Connection = con;
            //sda.SelectCommand = cmd;
            //sda.Fill(ds, "Users");
            /*  if(ds.Tables[0].Rows.Count > 0)
              {
                  Response.Redirect("WebForm2.aspx");
              }
              else
              {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
              }*/
            if (LogDao.LogUser(new LogDTO(userName, password)) == true)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
            }
        }

        protected void regbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}