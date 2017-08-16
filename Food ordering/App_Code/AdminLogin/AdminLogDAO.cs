using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Food_ordering.App_Code.AdminLogin
{
    public class AdminLogDAO
    {
        private string connectionString = "Server=EMON;Database=foodorder;User Id=sa ; password=emon108481;";

        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();



        public AdminLogDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }





        public Boolean LogAdmin(AdminLogDTO AdminLogDto)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = " select * from Admin where adminID = '" + AdminLogDto.adminID + "' and adminPassword = '" + AdminLogDto.adminPassword + "'";
            sqlCommand.Connection = sqlConnection;
            //    //string query = " select * from Users where userName = '" + LogDto.UserName + "' and password = '" + LogDto.PassWord + "'" ;
            // string query = " select * from Users where userName = 'sakif' and password =  '123' ";
            // sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataSet, "Admin");
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                //Response.Redirect("home.aspx");
                return true;
            }
            else
            {
                return false;
                // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
            }
        }
    }
}