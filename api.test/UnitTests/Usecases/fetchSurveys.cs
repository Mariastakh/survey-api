using NUnit.Framework;
using System.Collections.Generic;
using Moq;

namespace api.test
{
  public class fetchSurveysUnitTest
  {
    FetchSurveys fetchSurveys; 
    Mock<IFetchSurveysGateway> mockGateway;
    List<Survey> response;
    [SetUp]
    public void Setup()
    { 
      mockGateway = new Mock<IFetchSurveysGateway>();
      fetchSurveys = new FetchSurveys(mockGateway.Object);
      //mockGateway.Setup(p => p.Execute()).Returns(response);

    }

    [Test]
    public void itGetsASurvey()
    {
      string query = "Compliancy";
      fetchSurveys.Execute(query);
      mockGateway.Verify(mockGateway => mockGateway.Execute(query), Times.AtLeastOnce());
    }

    [Test]
    public void itGetsATopic()
    {
      fetchSurveys.getTopics();
      mockGateway.Verify(mockGateway => mockGateway.getTopics(), Times.AtLeastOnce());
    }
  }
}