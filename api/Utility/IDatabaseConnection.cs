using System.Collections.Generic;

namespace api {
    public interface IDatabaseConnection {
        public bool open(string connectionString);
        public List<string> executeQuery(string query);
    }
}