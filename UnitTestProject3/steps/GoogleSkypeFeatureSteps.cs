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
        private String searchWord = "skype";


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

                [Given(@"I have entered www\.google\.com for search")]
        public void GivenIHaveEnteredWww_Google_ComForSearch()
        {
            googlePage.openBaseUrl();
        }

                [Given(@"I have entered skype")]
        public void GivenIHaveEnteredSkype()
        {
            googlePage.typeSearch(searchWord);
        }

                [When(@"I press search skype")]
        public void WhenIPressSearchSkype()
        {
            googlePage.submitSearch();
        }

                [Then(@"the result should be  counts of search result  on the search list")]
        public void ThenTheResultShouldBeCountsOfSearchResultOnTheSearchList()
        {
            googlePage.countSearchResult();
            Console.WriteLine(googlePage.countSearchResult());
        }
     }
}
