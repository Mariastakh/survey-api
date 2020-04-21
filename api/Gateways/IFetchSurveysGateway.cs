using System.Collections.Generic;

namespace api {
    public interface IFetchSurveysGateway
    {
        public List<Survey> Execute();
    }
}