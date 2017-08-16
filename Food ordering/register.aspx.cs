using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Food_ordering.App_Code.Reg;
using Food_ordering.App_Code;

namespace Food_ordering
{
    
    public partial class register : System.Web.UI.Page
    {
        RegDAO RegDao = new RegDAO();
        UserCheck UserChk = new UserCheck();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // registerimg();
            }
        }

        protected void reg_Click(object sender, EventArgs e)
        {
            string userName = usertxt.Text;
            string firstName = firsttxt.Text;
            string lastName = lasttxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;

            if (userName == "" || firstName == "" || lastName == "" || email == "" || password == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill all the required field');</script>");

            }

            else
            {
                if (CheckEmail(email) == true)
                {
                    if (UserChk.ChkUser(userName) == true)
                    {
                        usertxt.Text = "";
                        Response.Write("<script language='javascript'>alert('This username already exists');</script>");
                    }
                    else
                    {
                        RegDao.RegUser(new RegDTO(userName, firstName, lastName, email, password));

                        //   Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful');</script>");
                        usertxt.Text = "";
                        firsttxt.Text = "";
                        lasttxt.Text = "";
                        emailtxt.Text = "";
                        passtxt.Text = "";
                        //  Response.Redirect("login.aspx");
                        Response.Write("<script language='javascript'>alert('Registration Successful');</script>");
                        Server.Transfer("login.aspx", true);
                        /* String connectionString = "Server=DESKTOP-5UHHJB2;Database=foodorder;User Id=sa ; password=sakif;";
                         SqlConnection con = new SqlConnection(connectionString);
                         String query = "insert into Users(userName,firstName,lastName,email,password)values('" + usertxt.Text + "','" + firsttxt.Text + "','" + lasttxt.Text + "','" + emailtxt.Text + "','" + passtxt.Text + "')";
                         SqlCommand cmd = new SqlCommand(query, con);
                         con.Open();
                         cmd.ExecuteNonQuery();
                         con.Close();
                         Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful');</script>");
                         usertxt.Text = "";
                         firsttxt.Text = "";
                         lasttxt.Text = "";
                         emailtxt.Text = "";
                         passtxt.Text = "";
                         Response.Redirect("login.aspx");
                         */






                    }
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Invalid Email');</script>");
                }
            }

        }
        private bool CheckEmail(string EmailAddress)
        {


            string strPattern = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            if (System.Text.RegularExpressions.Regex.IsMatch(EmailAddress, strPattern))
            { return true; }
            return false;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
          //  registerimg();
        }

        /*private void registerimg()
        {
            Random _rand = new Random();
            int i = _rand.Next(9, 12);
            Image1.ImageUrl = "~/resimg/" + i.ToString() + ".jpg";
        }*/
    }
    }

    

    
    
