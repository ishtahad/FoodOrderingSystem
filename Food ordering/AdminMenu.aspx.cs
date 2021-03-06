﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Food_ordering.App_Code.AdminMenuUpdate;
namespace Food_ordering
{
    public partial class AdminMenu : System.Web.UI.Page
    {
        AdminMenuUpdateDAO AdminMenuUpdateDao = new AdminMenuUpdateDAO();
        SqlConnection con = new SqlConnection("Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;");

        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = "Pizza Hut";
            // Label1.Text = Page.Request.QueryString.ToString();
            Label2.Text = Session["passrname"].ToString();
            //Label2.Text = Session["passuser"].ToString();
            //Label1.Text = Page.Request.QueryString.ToString();
            //String xyz = "Pizza Hut";
            // String xyz =  Request.QueryString["label1"];
            //  Label1.Text = xyz;
            if (!Page.IsPostBack)
            {
                show_data();
            }
        }
        private void show_data()
        {
            //Label1.Text = Request.QueryString["label1"];
            /* String a = "Available";
             DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            String connectionString = "Server=DESKTOP-5UHHJB2;Database=foodorder;User Id=sa ; password=sakif;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Menu ", con);
            con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
           // cmd.ExecuteNonQuery();
           // SqlDataAdapter dr = new SqlDataAdapter();
            //dr.SelectCommand = cmd;
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();*/
            // String str = "select * from Menu";

            // String str = "SELECT menu.Name,menu.description,menu.Price_TK FROM menu inner join restaurant on restaurant.R_ID=Menu.R_id where restaurant.R_id = @search";
            String str = "SELECT menu.P_id,menu.Name,menu.description,menu.Status,menu.Price_TK  FROM menu inner join restaurant on restaurant.R_ID=Menu.R_id where restaurant.R_id = @search";
            // String str = "SELECT R_ID, name , location , type , status from Restaurant";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passrid"].ToString();

            //  xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Label2.Text;
            con.Open();
            xp.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = xp;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }




        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='khaki';";
                e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";

            }

        }
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

            // Session["passresid"] = GridView1.SelectedRow.Cells[0].Text;
            //  Session["passresname"] = GridView1.SelectedRow.Cells[1].Text;
            // Response.Redirect("AdminMenu.aspx");
            RIDtxt.Text = GridView1.SelectedRow.Cells[0].Text;
            resNametxt.Text = GridView1.SelectedRow.Cells[1].Text;
            resLoctxt.Text = GridView1.SelectedRow.Cells[2].Text;
            resTypTxt.Text = GridView1.SelectedRow.Cells[3].Text;
            resStattxt.Text = GridView1.SelectedRow.Cells[4].Text;
            show_data();
        }

        protected void insertbtn_Click(object sender, EventArgs e)
        {
            int P_id = Convert.ToInt32(RIDtxt.Text);
            int R_id = Convert.ToInt32(Session["passrid"].ToString());
            string Name = resNametxt.Text;


            string Description = resLoctxt.Text;
            string Status = resTypTxt.Text;
            int Price_TK = Convert.ToInt32(resStattxt.Text);




            AdminMenuUpdateDao.AddItem(new AdminMenuUpdateDTO(P_id, Name, Description, Status, Price_TK, R_id));
            show_data();
            RIDtxt.Text = "";
            resNametxt.Text = "";
            resLoctxt.Text = "";
            resTypTxt.Text = "";
            resStattxt.Text = "";
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            int P_id = Convert.ToInt32(RIDtxt.Text);
            int R_id = Convert.ToInt32(Session["passrid"].ToString());
            string Name = resNametxt.Text;


            string Description = resLoctxt.Text;
            string Status = resTypTxt.Text;
            int Price_TK = Convert.ToInt32(resStattxt.Text);



            AdminMenuUpdateDao.UpdateItem(new AdminMenuUpdateDTO(P_id, Name, Description, Status, Price_TK, R_id));
            show_data();
            RIDtxt.Text = "";
            resNametxt.Text = "";
            resLoctxt.Text = "";
            resTypTxt.Text = "";
            resStattxt.Text = "";
        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {

            int P_id = Convert.ToInt32(RIDtxt.Text);
            int R_id = Convert.ToInt32(Session["passrid"].ToString());
            string Name = resNametxt.Text;


            string Description = resLoctxt.Text;
            string Status = resTypTxt.Text;
            int Price_TK = Convert.ToInt32(resStattxt.Text);

            AdminMenuUpdateDao.DelItem(new AdminMenuUpdateDTO(P_id, Name, Description, Status, Price_TK, R_id));

            show_data();
            RIDtxt.Text = "";
            resNametxt.Text = "";
            resLoctxt.Text = "";
            resTypTxt.Text = "";
            resStattxt.Text = "";
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}