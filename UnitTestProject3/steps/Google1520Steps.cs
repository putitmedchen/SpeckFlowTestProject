using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3
{
    [Binding]
    public class Google1520Steps
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


             [Given(@"I entered (.*) as base url")]
        public void GivenIEnteredBaseUrlAsBaseUrl(string baseUrl)
        {
            googlePage.openBaseUrl(baseUrl);
        }

                [Given(@"I entered (.*) into the search line")]
        public void GivenIEnteredIntoTheSearchLine(string search)
        {
            googlePage.typeSearch(search);
        }

                [When(@"I press on search button")]
        public void WhenIPressOnSearchButton()
        {
            googlePage.submitSearch();
        }

            [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
        {
            Assert.AreEqual(expectedResult, googlePage.getResult());
            Console.WriteLine("--------------------------" + googlePage.getResult());
        }
       
     }
}
