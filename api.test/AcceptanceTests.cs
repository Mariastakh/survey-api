using NUnit.Framework;
using System.Collections.Generic;

namespace api.test
{
    public class AcceptanceTests
    {
        FetchSurveys fetchSurveys;
        [SetUp]
        public void Setup()
        {
           // fetchSurveys = new FetchSurveys();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ItCanServeAnEmptySurvey()
        {
            //List<Survey> response = fetchSurveys.Execute();
            //Assert.IsEmpty(response);
        }
    }
}