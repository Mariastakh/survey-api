using System.Collections.Generic;

namespace api
{
    public class FetchSurveysGateway : IFetchSurveysGateway
    {
        public FetchSurveysGateway()
        {

        }
        public List<Survey> Execute(string query)
        {
            List<Survey> response = new List<Survey>() { 
                new Survey(){ Topic="Topic one" },
                new Survey(){ Topic="Topic two" }
            };
            return response;
        }
    }
}