using System.Collections.Generic;

namespace api
{
  public class FetchSurveys
  { 
    IFetchSurveysGateway gateway;

      public FetchSurveys(IFetchSurveysGateway gateway)
      {
        this.gateway = gateway;
      }
      public List<Survey> Execute()
      {
          return gateway.Execute();
      }
  }
}