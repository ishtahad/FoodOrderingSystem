using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Food_ordering.App_Code.Reg
{
    public class RegDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public RegDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void RegUser(RegDTO RegDto)
        {

            string query = " insert into Users(userName,firstName,lastName,email,password) values ('" + RegDto.UserName + "','"
                                                            + RegDto.FirstName + "','"
                                                            + RegDto.LastName + "','"
                                                            + RegDto.EMAIL + "','"
                                                            + RegDto.PassWord + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}