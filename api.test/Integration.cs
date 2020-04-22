using NUnit.Framework;
using System.Net.Http;
using FluentAssertions;
using System.Threading.Tasks;

namespace api.test
{
    public class IntegrationTests
    {
        static readonly HttpClient client = new HttpClient();
        string LOCALHOST = "http://localhost:5000";
 SurveyController controller = new  SurveyController();
        [SetUp]
        public void Setup()
        {  
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ItGetsASurveyTopic()
        {
            var response = controller.SurveyTopics();
            response.Should().Contain("bananas");
        }
    }
}