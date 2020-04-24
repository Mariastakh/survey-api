using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api
{
    [Produces("application/json")]
    public class SurveyController
    {
        List<string> topics = new List<string>() { "cats", "bananas" };
        List<Survey> surveys = new List<Survey>() {
             new Survey { Topic = "bananas"},
             new Survey { Topic = "shoes"}
         };

        [Route("api/topics")]
        [HttpGet]
        public List<string> SurveyTopics()
        {

            return topics;
        }

       [Route("api/surveys")]
       [HttpGet]
        public IActionResult Surveys(string topics)
        {
            var survey =  surveys.FirstOrDefault(x => x.Topic == topics);

            if(survey == null){
                return new NotFoundResult();
            }
            
            return new OkObjectResult(survey);
        }
    }

}