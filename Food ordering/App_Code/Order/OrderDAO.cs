using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace Food_ordering.App_Code.Order
{
    public class OrderDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public OrderDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddOrder(OrderDTO OrderDto)
        {

            string query = " insert into ConfirmOrders( Ordered_by, Ordered_from , Total_Price, Date , Time , TrxID) values ('" + OrderDto.Ordered_By + "','"
                                                            + OrderDto.Ordered_From + "','"
                                                            + OrderDto.Total_price + "','"
                                                            + OrderDto.DaTe + "','"
                                                            + OrderDto.TiMe + "','"
                                                            + OrderDto.TRXID + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


        }


    }
}
