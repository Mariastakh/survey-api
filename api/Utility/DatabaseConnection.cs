using System;
using System.Data;
using System.Collections.Generic;
using Npgsql;

namespace api
{
    public class DatabaseConnection : IDatabaseConnection
    {

        NpgsqlConnection conn;
        public DatabaseConnection()
        {

        }

        public void open(string connectionString)
        {
            conn = new NpgsqlConnection(connectionString);
            //$"Server=127.0.0.1; Port=5432; User Id={Environment.GetEnvironmentVariable("DB_USER")}; Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}; Database=surveys"
            conn.Open();
            if(conn.State==ConnectionState.Closed) { throw new BadConnectionStringException("Bad connection string");}
        }

        public List<string> executeQuery(string query)
        {
            List<string> result = new List<string>() { "Compliance", "Infrastructure" };
            return result;
        }
    }
}

//  conn = new NpgsqlConnection($"Server=127.0.0.1; Port=5432; User Id={Environment.GetEnvironmentVariable("DB_USER")}; Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}; Database=surveys");
//             if (conn.Open()) { throw new BadConnectionStringException("Bad connection string"); }
//             else
//             {
//                 db.open();
//             }