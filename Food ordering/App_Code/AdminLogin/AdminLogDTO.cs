using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.AdminLogin
{
    public class AdminLogDTO
    {
        private string AdminID, AdminPassword;

        public AdminLogDTO(string AdminID, string AdminPassword)
        {
            this.AdminID = AdminID;

            this.AdminPassword = AdminPassword;
        }

        public string adminID
        {
            get { return AdminID; }
            set { AdminID = value; }
        }


        public string adminPassword
        {
            get { return AdminPassword; }
            set { AdminPassword = value; }
        }
    }
}