using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.AdminMenuUpdate
{
    public class AdminMenuUpdateDTO
    {
        private string Name, Description, Status;
        int R_id, Price_TK, P_id;

        public AdminMenuUpdateDTO(int P_id, string Name, string Description, string Status, int Price_TK, int R_id)
        {
            this.P_id = P_id;
            this.Name = Name;
            this.Description = Description;
            this.Status = Status;
            this.Price_TK = Price_TK;
            this.R_id = R_id;
        }

        public int p_id
        {
            get { return P_id; }
            set { P_id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }


        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        public int price_tk
        {
            get { return Price_TK; }
            set { Price_TK = value; }
        }
        public int r_id
        {
            get { return R_id; }
            set { R_id = value; }
        }
    }
}