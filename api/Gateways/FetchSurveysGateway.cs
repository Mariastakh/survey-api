using System.Collections.Generic;

namespace api
{
    public class FetchSurveysGateway : IFetchSurveysGateway
    {
        IDatabaseConnection db;
        public FetchSurveysGateway(IDatabaseConnection db)
        {
            this.db = db;
        }
        public List<Survey> Execute(string query)
        {
            List<Survey> response = new List<Survey>() {
                new Survey(){ Topic="Topic one" },
                new Survey(){ Topic="Topic two" }
            };
            return response;
        }

        public List<string> getTopics()
        {
            db.open("Server: server; Post: port; User: Maria; password: pwd; Database: mydb");
            List<string> response = db.executeQuery("the query");
            return response;
        }
    }
}