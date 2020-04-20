using NUnit.Framework;

namespace api.test
{
    public class AcceptanceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ItCanServeASingleSurvey()
        {
            Survey survey = FetchQuestionnaires.Execute();
            Assert.NotNull(survey);
        }
    }
}