using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api
{
    [Produces("application/json")]
    public class SurveyController
    {
        List<string> topics = new List<string>() { "cats", "bananas", "shoes" };
        List<Survey> surveys = new List<Survey>() {
             new Survey { Topic = "bananas"},
             new Survey { Topic = "shoes"},
             new Survey { Topic = "cats"}
         };

        [Route("api/topics")]
        [HttpGet]
        public List<string> SurveyTopics()
        {

            return topics;
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