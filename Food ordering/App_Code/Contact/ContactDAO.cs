using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace Food_ordering.App_Code.Contact
{
    public class ContactDAO
    {

        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public ContactDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddContact(ContactDTO ContactDto)
        {

            string query = " insert into Contacts( User_ID, subject , Text ) values ('" + ContactDto.user_id + "','"
                                                            + ContactDto.Subject + "','"
                                                            + ContactDto.TexT + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


        }
    }
}