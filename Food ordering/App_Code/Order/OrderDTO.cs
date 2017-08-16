using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.Order
{
    public class OrderDTO
    {
        private string Ordered_by, Ordered_from, Ordered_item, Time, Date, TrxID;
        int Quantity, Total_Price;

        public OrderDTO(string Ordered_by, string Ordered_from, int Total_Price, string Date, string Time, string TrxID)
        {
            this.Ordered_by = Ordered_by;
            this.Ordered_from = Ordered_from;

            this.Total_Price = Total_Price;
            this.Date = Date;
            this.Time = Time;
            this.TrxID = TrxID;
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


        public int Total_price
        {
            get { return Total_Price; }
            set { Total_Price = value; }
        }
        public string DaTe
        {
            get { return Date; }
            set { Date = value; }
        }
        public string TiMe
        {
            get { return Time; }
            set { Time = value; }
        }
        public string TRXID
        {
            get { return TrxID; }
            set { TrxID = value; }
        }
    }
}