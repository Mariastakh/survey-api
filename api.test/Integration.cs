using NUnit.Framework;
using System.Net.Http;

namespace api.test
{
    public class IntegrationTests
    {
        static readonly HttpClient client = new HttpClient();
        string LOCALHOST = "http://localhost:3002";

        [SetUp]
        public void Setup()
        {  
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public async void ItGetsASpecifiedSurvey()
        {
            HttpResponseMessage response = await client.GetAsync($"{LOCALHOST}/survey?topic=compliance");
        }
    }
}