using NUnit.Framework;
using System.Collections.Generic;
using Moq;

namespace api.test
{
  public class fetchSurveysUnitTest
  {
    FetchSurveys fetchSurveys; 
    [SetUp]
    public void Setup()
    { 
    }

    [Test]
    public void itGetsEmptySurveys()
    {
      var mockGateway = new Mock<IFetchSurveysGateway>();
      List<Survey> response = new List<Survey>() { };
      mockGateway.Setup(p => p.Execute()).Returns(response);

      fetchSurveys = new FetchSurveys(mockGateway.Object);
      fetchSurveys.Execute();
      mockGateway.Verify(mockGateway => mockGateway.Execute(), Times.AtLeastOnce());
    }
  }
}