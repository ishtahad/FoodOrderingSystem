using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace Food_ordering.App_Code.Cart
{
    public class CartDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public CartDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddCart(CartDTO CartDto)
        {

            string query = " insert into Cart( Ordered_by, Ordered_from , Ordered_item , Quantity , Price) values ('" + CartDto.Ordered_By + "','"
                                                            + CartDto.Ordered_From + "','"
                                                            + CartDto.Ordered_Item + "','"
                                                            + CartDto.QuanTity + "','"
                                                            + CartDto.price + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


        }

    }
}