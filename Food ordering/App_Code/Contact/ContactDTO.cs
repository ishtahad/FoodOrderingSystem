using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_ordering.App_Code.Contact
{
    public class ContactDTO
    {
        private string User_ID, subject, Text;



        public ContactDTO(string User_ID, string subject, string Text)
        {
            this.User_ID = User_ID;
            this.subject = subject;
            this.Text = Text;


        }

        public string user_id
        {
            get { return User_ID; }
            set { User_ID = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string TexT
        {
            get { return Text; }
            set { Text = value; }
        }

    }
}