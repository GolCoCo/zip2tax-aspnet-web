using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Zip2TaxWebApp.Models;
using System.Web.DynamicData;

namespace WebApplication4.Controller
{
    public class ManagerMSSQLServer
    {
        private SqlConnection _connection = null;
        public ManagerMSSQLServer()
        {

        }

        public bool ConnectMSSQLServer()
        {
            try
            {
                string connectionString = $"Server={Utils.MSSQL_SERVER_NAME};Database={Utils.MSSQL_DATABASE_NAME};User Id={Utils.MSSQL_USERNAME};Password={Utils.MSSQL_PASSWORD};TrustServerCertificate={Utils.MSSQL_TRUSTSERVER};";
                _connection = new SqlConnection(connectionString);
                _connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void CloseMSSQLServer()
        {
            try
            {
                // Open the connection
                _connection.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public DataTable GetAllZip2TaxDataTable(int val)
        {
            try
            {
                string tableName = "wsTrayTypeAdj";
                // Define a query to select data
                string query = $"SELECT * FROM {tableName}"; // Replace with your table name

                DataTable dataTable = new DataTable("Zip2TaxAccount");
                // Add columns to the DataTable
                dataTable.Columns.Add("ID", typeof(string));
                dataTable.Columns.Add("Keyword", typeof(string));
                dataTable.Columns.Add("Count", typeof(string));
                int index = 1;
                // Create a SqlCommand
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    // Execute the command and retrieve data using a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Read through the data
                        while (reader.Read())
                        {
                            if (val < index) return dataTable;
                            var keyword = reader.GetValue(1); // Get the second column
                            var count = reader.GetValue(2); // Get the second column

                            dataTable.Rows.Add($"{index}", $"{keyword}", $"{count}");
                            index++;
                        }
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetAllZip2TaxDataTable(DateTime fromDt, DateTime toDt)
        {
            try
            {

                DataTable dataTable = new DataTable("Zip2TaxAccount");
                // Create a SqlCommand
                using (SqlCommand command = new SqlCommand(Utils.MSSQL_SP, _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@DateFrom", SqlDbType.SmallDateTime).Value = fromDt;
                    command.Parameters.Add("@DateTo", SqlDbType.SmallDateTime).Value = toDt;
                    // Add columns to the DataTable
                    dataTable.Columns.Add("ID", typeof(string));
                    dataTable.Columns.Add("Keyword", typeof(string));
                    dataTable.Columns.Add("Count", typeof(string));
                    int index = 1;
                    // Execute the command and retrieve data using a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Read through the data
                        while (reader.Read())
                        {
                            var keyword = reader.GetValue(1); // Get the second column
                            var count = reader.GetValue(2); // Get the second column
                            dataTable.Rows.Add($"{index}", $"{keyword}", $"{count}");
                        }
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}