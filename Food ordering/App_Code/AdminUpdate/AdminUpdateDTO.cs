using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.AdminUpdate
{
    public class AdminUpdateDTO
    {
        private string Name, Location, Type, Status;
        int R_ID, Total_Price;

        public AdminUpdateDTO(int R_ID, string Name, string Location, string Type, string Status)
        {
            this.R_ID = R_ID;
            this.Name = Name;
            this.Location = Location;
            this.Type = Type;
            this.Status = Status;
        }

        public int r_id
        {
            get { return R_ID; }
            set { R_ID = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }


        public string location
        {
            get { return Location; }
            set { Location = value; }
        }
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

    }
}