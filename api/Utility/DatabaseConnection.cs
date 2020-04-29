using System.Collections.Generic;

namespace api
{
    public class DatabaseConnection : IDatabaseConnection
    {

        public DatabaseConnection()
        {

        }

        public void open(string connectionString)
        {

        }

        public List<string> executeQuery(string query)
        {
            List<string> result = new List<string>() { "Compliance", "Infrastructure" };
            return result;
        }
    }
}