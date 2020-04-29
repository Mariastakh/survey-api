using NUnit.Framework;
using System.Collections.Generic;
using Moq;

namespace api.test
{
    public class fetchSurveysGatewayUnitTest
    {
        List<string> expectedResult;
        Mock<IDatabaseConnection> mockDb;
        FetchSurveysGateway fetchSurveysGateway;
        string connectionString;
        [SetUp]
        public void Setup()
        {
            expectedResult = new List<string>() { "Compliance", "Infrastructure" };
            mockDb = new Mock<IDatabaseConnection>();
            mockDb.Setup(foo => foo.executeQuery("the query")).Returns(expectedResult);
            fetchSurveysGateway = new FetchSurveysGateway(mockDb.Object);
        }

        [Test]
        public void itGetsTopics()
        {
            string connectionString = "Server: server; Post: port; User: Maria; password: pwd; Database: mydb";
            string query = "the query";
            List<string> response = fetchSurveysGateway.getTopics();
            mockDb.Verify(mockDb => mockDb.open(connectionString), Times.AtLeastOnce());
            mockDb.Verify(mockDb => mockDb.executeQuery(query), Times.AtLeastOnce());
            Assert.AreEqual(expectedResult, response);
        }
    }
}