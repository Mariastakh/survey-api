using System.Collections.Generic;

namespace api {
    public interface IFetchSurveysGateway
    {
        public List<Survey> Execute(string query);
        public List<string> getTopics();
    }
}