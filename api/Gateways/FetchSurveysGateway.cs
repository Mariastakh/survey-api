using System.Collections.Generic;

namespace api
{
    public class FetchSurveysGateway : IFetchSurveysGateway
    {
        public List<Survey> Execute()
        {
            List<Survey> response = new List<Survey>() { 
                new Survey(){ },
                new Survey(){ }
            };
            return response;
        }
    }
}