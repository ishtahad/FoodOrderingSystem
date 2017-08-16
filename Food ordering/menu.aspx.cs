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
    public partial class menu : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;");

        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = "Pizza Hut";
            // Label1.Text = Page.Request.QueryString.ToString();
            // Label2.Text = Session["passvalue"].ToString();
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
            //    String str = "SELECT menu.Name,menu.description,menu.Price_TK FROM menu inner join restaurant on restaurant.R_ID=Menu.R_id where (restaurant.name like '%' + @search + '%')";
            String str = "SELECT name , location , type , status from Restaurant";
            SqlCommand xp = new SqlCommand(str, con);
            //    xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passvalue"].ToString();

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

        protected void searchbtn_Click(object sender, EventArgs e)
        {
            //GridView1.DataSource = null;
            //  GridView1.DataBind();

            // string a = SearchList.SelectedItem.Text;
            if (SearchList.SelectedItem.Text == "Restaurant")
            {

                String str2 = "SELECT name , location , type , status from Restaurant where (name like '%' + @search1 + '%')";
                SqlCommand xp1 = new SqlCommand(str2, con);
                xp1.Parameters.Add("@search1", SqlDbType.VarChar).Value = TextBox1.Text;

                //  xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Label2.Text;
                con.Open();

                xp1.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = xp1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                GridView1.DataSource = ds1;
                GridView1.DataBind();

                con.Close();
            }
            else if (SearchList.SelectedItem.Text == "Location")
            {
                String str3 = "SELECT name , location , type , status from Restaurant where (location like '%' + @search2 + '%')";
                SqlCommand xp = new SqlCommand(str3, con);
                xp.Parameters.Add("@search2", SqlDbType.VarChar).Value = TextBox1.Text;

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
            else if (SearchList.SelectedItem.Text == "Type")
            {
                String str4 = "SELECT name , location , type , status from Restaurant where (type like '%' + @search3 + '%')";
                SqlCommand xp = new SqlCommand(str4, con);
                xp.Parameters.Add("@search3", SqlDbType.VarChar).Value = TextBox1.Text;

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
            else if (TextBox1.Text == "")
            {
                show_data();
            }
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

            Session["passvalue"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("test.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}