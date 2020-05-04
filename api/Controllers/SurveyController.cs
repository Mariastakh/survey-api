using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api
{
    [Produces("application/json")]
    public class SurveyController
    {
        DatabaseConnection db;
        FetchSurveysGateway fetchSurveysGateway;
        FetchSurveys fetchSurveys;
        //List<string> topics = new List<string>() { "cats", "bananas", "shoes" };
        List<string> topics = new List<string>();
        List<Survey> surveys = new List<Survey>() {
             new Survey { Topic = "bananas"},
             new Survey { Topic = "shoes"},
             new Survey { Topic = "cats"}
         };

        [Route("api/topics")]
        [HttpGet]
        public List<string> SurveyTopics()
        {
            db = new DatabaseConnection();
            string connectionString = $"Server=127.0.0.1; Port=5432; User Id=maria; Password=1234; Database=survey";
            fetchSurveysGateway = new FetchSurveysGateway(db, connectionString);
            fetchSurveys = new FetchSurveys(fetchSurveysGateway);
            List<string> response = fetchSurveys.getTopics();
            return response;
        }

       [Route("api/surveys")]
       [HttpGet]
        public IActionResult Surveys(List<string> topics)
        {
            //var survey =  surveys.FirstOrDefault(x => x.Topic == topics);
            List<string> surveyTopics = new List<string>();
            foreach(string topic in topics)
            {
                foreach(Survey survey in surveys)
                {
                    if(survey.Topic == topic)
                    {
                        surveyTopics.Add(topic);
                    }
                }
            }


            if(surveyTopics == null){
                return new NotFoundResult();
            }

            return new OkObjectResult(surveyTopics);
        }
    }

}