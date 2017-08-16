using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.Cart
{
    public class CartDTO
    {
        private string Ordered_by, Ordered_from, Ordered_item, Time, Date, TrxID;
        int Quantity, Price;

        public CartDTO(string Ordered_by, string Ordered_from, string Ordered_item, int Quantity, int Price)
        {
            this.Ordered_by = Ordered_by;
            this.Ordered_from = Ordered_from;
            this.Ordered_item = Ordered_item;
            this.Quantity = Quantity;
            this.Price = Price;

        }

        public string Ordered_By
        {
            get { return Ordered_by; }
            set { Ordered_by = value; }
        }

        public string Ordered_From
        {
            get { return Ordered_from; }
            set { Ordered_from = value; }
        }

        public string Ordered_Item
        {
            get { return Ordered_item; }
            set { Ordered_item = value; }
        }
        public int QuanTity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int price
        {
            get { return Price; }
            set { Price = value; }
        }

    }
}