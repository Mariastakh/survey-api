using System;
using NUnit.Framework;
using FluentAssertions;
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
            connectionString = "Server: server; Post: port; User: Maria; password: pwd; Database: mydb";
            expectedResult = new List<string>() { "Compliance", "Infrastructure" };
            mockDb = new Mock<IDatabaseConnection>();
            mockDb.Setup(foo => foo.executeQuery(It.IsAny<string>())).Returns(expectedResult);
            mockDb.Setup(m => m.open(connectionString)).Returns(true);
        }

        [Test]
        public void itShowsAnErrorMessageIfConnectionFailed()
        {
            fetchSurveysGateway = new FetchSurveysGateway(mockDb.Object, "bad connection");
            Action act = () => fetchSurveysGateway.getTopics();
            act.Should().Throw<BadConnectionStringException>();
        }

        [Test]
        public void itGetsTopics()
        {
            fetchSurveysGateway = new FetchSurveysGateway(mockDb.Object, connectionString);
            List<string> response = fetchSurveysGateway.getTopics();
            mockDb.Verify(mockDb => mockDb.open(connectionString), Times.AtLeastOnce());
            mockDb.Verify(mockDb => mockDb.executeQuery(It.IsAny<string>()), Times.AtLeastOnce());
            Assert.AreEqual(expectedResult, response);
        }
    }
}