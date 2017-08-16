using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Food_ordering.App_Code.Cart;

namespace Food_ordering
{

    public partial class Order : System.Web.UI.Page
    {
        CartDAO CartDao = new CartDAO();
        int Quan;
        protected void Page_Load(object sender, EventArgs e)
        {
            passres.Text = Session["passvalue"].ToString();
            passitem.Text = Session["passres"].ToString();
            passprice.Text = Session["passprice"].ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string d = DateTime.Now.ToString("dd/MM/yyyy");
            // Session["passquan"] = d;

            Session["passquan"] = QuantityList.SelectedItem.Text;
            Quan = Convert.ToInt32(QuantityList.SelectedItem.Text);

        }

        //protected void AdvanceOrder_Click(object sender, EventArgs e)
        //{
            //int Quan = Convert.ToInt32(Quantity);
            //int price = Convert.ToInt32(passprice.Text);
            //int totalprice = Quan * price;
            //Session["passtotalprice"] = Convert.ToString(totalprice);
            //Response.Redirect("ConfirmOrder.aspx");
        //}

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            /* int price = Convert.ToInt32(passprice.Text);
             int totalprice = Quan * price;
             Session["passtotalprice"] = Convert.ToString(totalprice);
             Response.Redirect("ConfirmOrder.aspx");*/
            int price = Convert.ToInt32(passprice.Text);
            int totalprice = Quan * price;
            Session["passtotalprice"] = Convert.ToString(totalprice);
            string Ordered_by = Session["passuser"].ToString();
            string Ordered_from = Session["passvalue"].ToString();
            string Ordered_item = Session["passres"].ToString();
            int Quantity = Convert.ToInt32(Session["passquan"].ToString());
            int Price = Convert.ToInt32(Session["passtotalprice"].ToString());

            string Time = DateTime.Now.ToString("hh:mm:ss tt");
            string Date = DateTime.Now.ToString("dd/MM/yyyy");




            CartDao.AddCart(new CartDTO(Ordered_by, Ordered_from, Ordered_item, Quantity, Price));


            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Ordered Successfully');</script>");


            int milliseconds = 500;
            System.Threading.Thread.Sleep(milliseconds);

            Response.Write("<script language='javascript'>alert('Added To Cart');</script>");
            Server.Transfer("WebForm2.aspx", true);

            // Response.Redirect("ConfirmOrder.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("test.aspx");
        }
    }
}