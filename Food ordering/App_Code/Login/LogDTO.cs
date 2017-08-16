using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.Login
{
    public class LogDTO
    {
        private string userName, password;

        public LogDTO(string userName, string password)
        {
            this.userName = userName;

            this.password = password;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}