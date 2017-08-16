using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Food_ordering.App_Code.AdminMenuUpdate
{
    public class AdminMenuUpdateDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public AdminMenuUpdateDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddItem(AdminMenuUpdateDTO AdminUpdateDto)
        {

            string query = " insert into Menu(P_id,Name,Description,Status,Price_TK,R_id) values ('" + AdminUpdateDto.p_id + "','"
                                                            + AdminUpdateDto.name + "','"
                                                            + AdminUpdateDto.description + "','"
                                                            + AdminUpdateDto.status + "','"
                                                            + AdminUpdateDto.price_tk + "','"
                                                            + AdminUpdateDto.r_id + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void DelItem(AdminMenuUpdateDTO AdminMenuUpdateDto)
        {
            sqlConnection.Open();
            string query = " delete from Menu where P_id = '" + AdminMenuUpdateDto.p_id + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateItem(AdminMenuUpdateDTO AdminMenuUpdateDto)
        {
            sqlConnection.Open();
            string query = " update Menu set Name ='" + AdminMenuUpdateDto.name + "', Description = '" + AdminMenuUpdateDto.description + "', Status = '" + AdminMenuUpdateDto.status + "', Price_TK = '" + AdminMenuUpdateDto.price_tk + "', R_id = '" + AdminMenuUpdateDto.r_id + "' where P_id = '" + AdminMenuUpdateDto.p_id + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}