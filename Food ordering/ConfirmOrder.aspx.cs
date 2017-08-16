using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food_ordering.App_Code.Order;

namespace Food_ordering
{
    public partial class ConfirmOrder : System.Web.UI.Page
    {
        OrderDAO OrderDao = new OrderDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

           
            itemvalue.Text = Session["passres"].ToString();
            quantityvalue.Text = Session["passquan"].ToString();

            getbill.Text = Session["passtotalprice"].ToString();
            //quantityvalue.Text = DateTime.Now.ToString("hh:mm:ss tt");
            // getbill.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        

        protected void ConfirmPayment_Click(object sender, EventArgs e)
        {
            string Ordered_by = Session["passuser"].ToString();
            string Ordered_from = Session["passvalue"].ToString();
            string Ordered_item = Session["passres"].ToString();
            int Quantity = Convert.ToInt32(Session["passquan"].ToString());
            int Total_Price = Convert.ToInt32(Session["passtotalprice"].ToString());

            string Time = DateTime.Now.ToString("hh:mm:ss tt");
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            string TrxID = TrxInput.Text;




        //    OrderDao.AddOrder(new OrderDTO(Ordered_by, Ordered_from, Ordered_item, Quantity, Total_Price, Date, Time, TrxID));


            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Ordered Successfully');</script>");


            int milliseconds = 500;
            System.Threading.Thread.Sleep(milliseconds);

            Response.Write("<script language='javascript'>alert('Order Confirmed');</script>");
            Server.Transfer("WebForm2.aspx", true);
            //Response.Redirect("home.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("test.aspx");
        }
    }
    }
