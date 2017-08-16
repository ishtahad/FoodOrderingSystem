using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Food_ordering
{
    public partial class UserOrder : System.Web.UI.Page
    {

        //String connectionString = "Server=DESKTOP-5UHHJB2;Database=foodorder;User Id=sa ; password=sakif;";
        // SqlConnection con = new SqlConnection(connectionString);
        SqlConnection con = new SqlConnection("Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;");

        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = "Pizza Hut";
            // Label1.Text = Page.Request.QueryString.ToString();
            Label1.Text = Session["passuser"].ToString();
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
            //  String str = "SELECT menu.Name,menu.description,menu.Price_TK FROM menu inner join restaurant on restaurant.R_ID=Menu.R_id where (restaurant.name like '%' + @search + '%')";
            // String str = "SELECT Orders.Ordered_from,Orders.Ordered_item,Orders.Quantity,Orders.Total_price,Orders.Date,Orders.Time,Orders.TrxID FROM Orders inner join Users on Orders.Ordered_by=Users.userName where (Users.userName like '%' + @search + '%')";
            String str = "SELECT ConfirmOrders.Order_ID,ConfirmOrders.Ordered_from,ConfirmOrders.Total_price,ConfirmOrders.Date,ConfirmOrders.Time,ConfirmOrders.TrxID FROM ConfirmOrders inner join Users on ConfirmOrders.Ordered_by=Users.userName where Users.userName =  @search ";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passuser"].ToString();

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

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //Response.Redirect("test.aspx");

          //  Session["passres"] = GridView1.SelectedRow.Cells[1].Text;
          //  Session["passprice"] = GridView1.SelectedRow.Cells[3].Text;
          //  Response.Redirect("Order.aspx");
            // Response.Redirect("test.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}