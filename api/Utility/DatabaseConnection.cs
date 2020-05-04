using System;
using System.Data;
using System.Collections.Generic;
using Npgsql;

namespace api
{
    public class DatabaseConnection : IDatabaseConnection
    {

        NpgsqlConnection conn;
        List<string> topics = new List<string>();
        public DatabaseConnection()
        {

        }

        public bool open(string connectionString)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open) { return true; }
            return false;
        }

        public List<string> executeQuery(string query)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
            {
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string topic = reader.GetString(reader.GetOrdinal("topic"));

                    topics.Add(topic);
                }

                conn.Close(); //close the current connection
            }

            return topics;
        }
    }
}

//  conn = new NpgsqlConnection($"Server=127.0.0.1; Port=5432; User Id={Environment.GetEnvironmentVariable("DB_USER")}; Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}; Database=surveys");
//             if (conn.Open()) { throw new BadConnectionStringException("Bad connection string"); }
//             else
//             {
//                 db.open();
//             }