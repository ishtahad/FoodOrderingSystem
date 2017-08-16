using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace Food_ordering.App_Code.AdminUpdate
{
    public class AdminUpdateDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public AdminUpdateDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddRes(AdminUpdateDTO AdminUpdateDto)
        {

            string query = " insert into Restaurant(R_ID,Name,Location,Type,Status) values ('" + AdminUpdateDto.r_id + "','"
                                                            + AdminUpdateDto.name + "','"
                                                            + AdminUpdateDto.location + "','"
                                                            + AdminUpdateDto.type + "','"
                                                            + AdminUpdateDto.status + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void DelRes(AdminUpdateDTO AdminUpdateDto)
        {
            sqlConnection.Open();
            string query = " delete from Restaurant where R_ID = '" + AdminUpdateDto.r_id + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateRes(AdminUpdateDTO AdminUpdateDto)
        {
            sqlConnection.Open();
            string query = " update Restaurant set Name ='" + AdminUpdateDto.name + "', Location = '" + AdminUpdateDto.location + "', Type = '" + AdminUpdateDto.type + "', Status = '" + AdminUpdateDto.status + "' where R_ID = '" + AdminUpdateDto.r_id + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}