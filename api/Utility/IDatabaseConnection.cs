using System.Collections.Generic;

namespace api {
    public interface IDatabaseConnection {
        public void open(string connectionString);
        public List<string> executeQuery(string query);
    }
}