using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using Food_ordering.App_Code.Order;
namespace Food_ordering
{
    public partial class ConfirmCart : System.Web.UI.Page
    {
        string _connStr = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";
        OrderDAO OrderDao = new OrderDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            // itemvalue.Text = Session["passres"].ToString();
            //  quantityvalue.Text = Session["passquan"].ToString();

            // getbill.Text = Session["passtotalprice"].ToString();
            //quantityvalue.Text = DateTime.Now.ToString("hh:mm:ss tt");
            // getbill.Text = DateTime.Now.ToString("dd/MM/yyyy");
            itemvalue.Text = Session["passuser"].ToString();
            quantityvalue.Text = Session["passordersfrom"].ToString();
            getbill.Text = Session["passcartprice"].ToString();
        }


        // repopulate the fresh data







        protected void ConfirmPayment_Click(object sender, EventArgs e)
        {
            string Ordered_by = Session["passuser"].ToString();
            //  string Ordered_by = "sakiftahmid";
            string Ordered_from = Session["passordersfrom"].ToString();
            // string Ordered_item = Session["passres"].ToString();
            // string Ordered_item = "biriani";
            // int Quantity = Convert.ToInt32(Session["passquan"].ToString());
            // int Quantity = 5;
            int Total_Price = Convert.ToInt32(Session["passcartprice"].ToString());

            string Time = DateTime.Now.ToString("hh:mm:ss tt");
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            string TrxID = TrxInput.Text;




            OrderDao.AddOrder(new OrderDTO(Ordered_by, Ordered_from, Total_Price, Date, Time, TrxID));


            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Ordered Successfully');</script>");
            int n = Convert.ToInt32(Session["passlistsize"].ToString());
            ArrayList al2 = (ArrayList)Session["arrayList"];
            for (int i = 0; i < n; i++)
            {

                using (SqlConnection conn = new SqlConnection(_connStr))

                {

                    string sql = "Delete from Cart" + " where Cart_ID = @search2";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))

                    {

                        cmd.Parameters.AddWithValue("@search2", (string)al2[i]);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        conn.Close();

                    }
                }

            }

            int milliseconds = 500;
            System.Threading.Thread.Sleep(milliseconds);

            Response.Write("<script language='javascript'>alert('Order Confirmed');</script>");
            Server.Transfer("WebForm2.aspx", true);
            //Response.Redirect("home.aspx");



        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }

}