using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.Reg
{
    public class RegDTO
    {
        private string userName, firstName, lastName, email, password;

        public RegDTO(string userName, string firstName, string lastName, string email, string password)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}