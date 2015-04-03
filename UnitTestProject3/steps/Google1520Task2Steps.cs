using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3
{
    [Binding]
    public class Google1520Task2Steps
    {

        private GooglePage googlePage;
        private IWebDriver driver;
        private String result;


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

        [Given(@"I have entered (.*) into the (.*)")]
        public void GivenIHaveEnteredIntoTheCalculator(string search, string baseUrl)
        {
            googlePage.openBaseUrl(baseUrl);
            googlePage.typeSearch(search);
            googlePage.submitSearch();
        }

        [Given(@"I recieved result from multiplying")]
        public void GivenIRecievedResultFromMultiplying()
        {
            result = googlePage.getResult();
        }

        [Given(@"I (.*) result into search line")]
        public void GivenIAddResultIntoSearchLine(string action )
        {
            googlePage.typeSearch(action + result);
        }

        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            googlePage.submitSearch();
        }
        [Then(@"the result must be (.*) on the screen")]
        public void ThenTheResultMustBeCountsOnThe_Screen(string expectedResult)
        {
            Assert.AreEqual(expectedResult, googlePage.getResult());
        }
    }
}
