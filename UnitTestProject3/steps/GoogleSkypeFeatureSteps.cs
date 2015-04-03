using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3
{
    [Binding]
    public class GoogleSkypeFeatureSteps
    {

        private GooglePage googlePage;
        private IWebDriver driver;

        [BeforeScenario()]
        public void setUp()
        {
            driver = DriverManager.getInstance();
            googlePage = new GooglePage(driver);
        }

        [AfterScenario()]
        public void tearDown()
        {
            driver.Quit();
        }

                [Given(@"I have entered (.*) for search")]
        public void GivenIHaveEnteredForSearch(string address)
        {
            googlePage.openBaseUrl(address);
        }

                [Given(@"I have entered (.*) in search line")]
        public void GivenIHaveEnteredSkypeInSearchLine(string search)
        {
            googlePage.typeSearch(search);
        }

                [When(@"I press search skype")]
        public void WhenIPressSearchSkype()
        {
            googlePage.submitSearch();
        }

                [Then(@"the result should be (.*) counts")]
        public void ThenTheResultShouldBeCounts(int expectedCounts)
        {
            googlePage.countsSearchResult(expectedCounts);
        }
     }
}
