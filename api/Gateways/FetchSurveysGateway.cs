using System;
using System.Collections.Generic;

namespace api
{
    public class BadConnectionStringException : Exception
    {
        public BadConnectionStringException(string message) : base(message)
        {
        }
    }
    public class FetchSurveysGateway : IFetchSurveysGateway
    {
        IDatabaseConnection db;
        string connectionString;
        public FetchSurveysGateway(IDatabaseConnection db, string connectionString)
        {
            this.db = db;
            this.connectionString = connectionString;
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
            if(db.open(connectionString) == false){throw new BadConnectionStringException("bad connection");};
            
            List<string> response = db.executeQuery("SELECT * FROM surveys WHERE topic = ANY('{Compliance, Infrastructure}')");
            return response;
        }
    }
}