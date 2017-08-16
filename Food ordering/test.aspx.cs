using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Food_ordering
{
    public partial class test : System.Web.UI.Page
    {

        //String connectionString = "Server=DESKTOP-5UHHJB2;Database=foodorder;User Id=sa ; password=sakif;";
        // SqlConnection con = new SqlConnection(connectionString);
        SqlConnection con = new SqlConnection("Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;");

        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = "Pizza Hut";
            // Label1.Text = Page.Request.QueryString.ToString();
            Label2.Text = Session["passvalue"].ToString();
            //Label2.Text = Session["passuser"].ToString();
            //Label1.Text = Page.Request.QueryString.ToString();
            //String xyz = "Pizza Hut";
            // String xyz =  Request.QueryString["label1"];
            //  Label1.Text = xyz;

            show_data();
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
            String str = "SELECT menu.Name,menu.description,menu.Price_TK FROM menu inner join restaurant on restaurant.R_ID=Menu.R_id where (restaurant.name like '%' + @search + '%')";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passvalue"].ToString();

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

        /* protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
         {
             Response.Redirect("test.aspx");
         }*/

        /*  protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
           {
               //Response.Redirect("test.aspx");

               Session["passres"] = GridView1.SelectedRow.Cells[1].Text;
               Session["passprice"] = GridView1.SelectedRow.Cells[3].Text;
               Response.Redirect("Order.aspx");
               // Response.Redirect("test.aspx");
           } */
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
            /*  foreach (GridViewRow row in GridView1.Rows)
              {
                  if (row.RowIndex == GridView1.SelectedIndex)
                  {
                      Response.Redirect("nxtpage.aspx");

                  }
                  else
                  {
                     // row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                      row.ToolTip = "Click to select this row.";
                     // Response.Redirect("nxtpage.aspx");
                  }
              }*/
            //GridView1.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            //   Session["passvalue"] = GridView1.SelectedRow.Cells[1].Text;
            // Response.Redirect("nxtpage.aspx");
            Session["passres"] = GridView1.SelectedRow.Cells[0].Text;
            Session["passprice"] = GridView1.SelectedRow.Cells[2].Text;
            Response.Redirect("Order.aspx");
        }



        protected void Timer1_Tick(object sender, EventArgs e)
        {
            settestimg();
        }

        private void settestimg()
        {
            Random _rand = new Random();
            int i = _rand.Next(5, 8);
            Image1.ImageUrl = "~/testimg/" + i.ToString() + ".jpg";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }
    }
}