using NUnit.Framework;
using System.Collections.Generic;

namespace api.test
{
  public class fetchSurveysUnitTest
  {
    FetchSurveys fetchSurveys; 
    [SetUp]
    public void Setup()
    {
        fetchSurveys = new FetchSurveys();
    }

    [Test]
    public void itGetsEmptySurveys()
    {
        List<Survey> response = fetchSurveys.Execute();
        Assert.IsEmpty(response);
    }
  }
}