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

        [SetUp]
        public void Setup()
        {  
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public async Task ItGetsASpecifiedSurvey()
        {
            //HttpResponseMessage response = await client.GetAsync($"{LOCALHOST}");
            //response.Should().Be("Status 200");
        }
    }
}