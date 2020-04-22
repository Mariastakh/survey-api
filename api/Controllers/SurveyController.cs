using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api
{
    [Produces("application/json")]
    [Route("api")]

    public class SurveyController
    {
        [HttpGet("topics")]
        public List<string> SurveyTopics()
        {
            List<string> topics = new List<string>() { "cats", "bananas" };
            return topics;
        }
    }

}