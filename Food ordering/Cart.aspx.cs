using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Food_ordering
{
    public partial class Cart : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;");
        // string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        string _connStr = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        protected void Page_Load(object sender, EventArgs e)

        {

            if (!IsPostBack)

            {

                this.GetData();
            }
        }

        /// <summary>

        /// Paginates the data.

        /// </summary>

        /// <param name="sender">The sender.</param>

        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewPageEventArgs"/>instance containing the event data.</param>

        protected void PaginateTheData(object sender, GridViewPageEventArgs e)

        {

            GridView1.PageIndex = e.NewPageIndex;

            this.GetData();
        }



        private void GetData()

        {

            /*  DataTable table = new DataTable();

              // get the connection

              using (SqlConnection conn = new SqlConnection(_connStr))

              {

                  // write the sql statement to execute

                  string sql = "SELECT Orders.Order_ID,Orders.Ordered_by,Orders.Ordered_from,Orders.Ordered_item,Orders.Quantity,Orders.Total_price,Orders.Date,Orders.Time,Orders.TrxID FROM Orders inner join Users on Orders.Ordered_by=Users.userName where (Users.userName like '%' + @search + '%')";

                  // instantiate the command object to fire

                  using (SqlCommand cmd = new SqlCommand(sql, conn))

                  {

                      // get the adapter object and attach the command object to it

                      using (SqlDataAdapter ad = new SqlDataAdapter(cmd))

                      {

                          // fire Fill method to fetch the data and fill into DataTable

                          ad.Fill(table);
                      }
                  }
              }

              GridView1.DataSource = table;

              GridView1.DataBind();*/

            String str = "SELECT Cart.Cart_ID,Cart.Ordered_by,Cart.Ordered_from,Cart.Ordered_item,Cart.Quantity,Cart.Price FROM Cart inner join Users on Cart.Ordered_by=Users.userName where Users.userName = @search ";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passuser"].ToString();

            //xp.Parameters.Add("@search", SqlDbType.VarChar).Value = "sakif";
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



        /// <summary>

        /// Gets the selected records.

        /// </summary>

        /// <param name="sender">The sender.</param>

        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>

        protected void Button1_Click(object sender, EventArgs e)

        {
            ArrayList al = new ArrayList();
            int i = 0;
            string txt = "";
            int n = 0;
            // Response.Write("<h3>Selected records</h3>");

            foreach (GridViewRow row in GridView1.Rows)

            {

                CheckBox chk = (CheckBox)row.FindControl("chkSelect");

                if (chk.Checked)

                {

                    al.Add(row.Cells[0].Text);

                    // get the selected AutoId and cells text

                    //  Response.Write("AutoId: " + GridView1.DataKeys[row.RowIndex].Value + ", First Name: " + row.Cells[2].Text + "<br />");
                    i = i + Convert.ToInt32(row.Cells[5].Text);
                    txt = txt + "  " + row.Cells[2].Text;
                    n++;
                }
            }

            Session["passcartprice"] = i.ToString();
            Session["passordersfrom"] = txt;
            Session["arrayList"] = al;
            Session["passlistsize"] = n;
            //this.delete();
            Response.Redirect("ConfirmCart.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.delete();
            /*  Response.Write("<h3>Selected records</h3>");

              foreach (GridViewRow row in GridView1.Rows)

              {

                  CheckBox chk = (CheckBox)row.FindControl("chkSelect");

                  if (chk.Checked)

                  {

                      int Order_ID = 

                      int.Parse(GridView1.DataKeys[row.RowIndex].Value.ToString());

                      // get the selected AutoId and cells text

                      Response.Write("<p>AutoId: " + Order_ID + " deleted</p>");

                      // fire your DELETE method from BAL or service layer

                      using (SqlConnection conn = new SqlConnection(_connStr))

                      {

                          string sql = "Delete from Orders" + " where Order_ID = @search2";

                          using (SqlCommand cmd = new SqlCommand(sql, conn))

                          {

                              cmd.Parameters.AddWithValue("@search2", Order_ID);

                              conn.Open();

                              cmd.ExecuteNonQuery();

                              conn.Close();

                          }
                      }
                  }
              }

              // repopulate the fresh data

              this.GetData();*/
        }
        public void delete()
        {

            //Response.Write("<h3>Selected records</h3>");

            foreach (GridViewRow row in GridView1.Rows)

            {

                CheckBox chk = (CheckBox)row.FindControl("chkSelect");

                if (chk.Checked)

                {

                    int Cart_ID =

                    int.Parse(GridView1.DataKeys[row.RowIndex].Value.ToString());

                    // get the selected AutoId and cells text

                    //    Response.Write("<p>AutoId: " + Cart_ID + " deleted</p>");

                    // fire your DELETE method from BAL or service layer

                    using (SqlConnection conn = new SqlConnection(_connStr))

                    {

                        string sql = "Delete from Cart" + " where Cart_ID = @search2";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))

                        {

                            cmd.Parameters.AddWithValue("@search2", Cart_ID);

                            conn.Open();

                            cmd.ExecuteNonQuery();

                            conn.Close();

                        }
                    }
                }
            }

            // repopulate the fresh data

            this.GetData();



        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
