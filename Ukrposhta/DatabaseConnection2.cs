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
        
        public SqlConnection connection { get; set; }
        public SqlDataReader reader { get; set; }
        public DataTable dataTable { get; set; }

        SqlCommand command;
        
        SqlDataAdapter adapter;
        
        string connectionString = string.Empty;

        int id = 0;
        public DatabaseConnection()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ukrposhta;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlDataReader Connection(string comand)
        {
           
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(comand, connection);
                reader = command.ExecuteReader();
                return reader;

            
        }
        public void ConnectionAdapter(string comand)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            adapter = new SqlDataAdapter(comand, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
        }
        public int ConnectionGiveId(string comand)
        {
            
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(comand, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            connection.Close();
            return id;

        }

        


    }
}
