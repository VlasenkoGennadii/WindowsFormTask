using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta
{
    class DatabaseConnection
    {
        public string connectionString = string.Empty;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public SqlDataAdapter adapter;
        public DataTable dataTable;
        

        public DatabaseConnection()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ukrposhta;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlDataReader Connection(string comand)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(comand, connection);
            command.ExecuteNonQuery();
            return reader = command.ExecuteReader();
        }

        public void ConnectionAdapter(string comand)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            adapter = new SqlDataAdapter(comand, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);            
        }
    }
}
