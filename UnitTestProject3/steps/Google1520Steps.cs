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


             [Given(@"I have entered www\.google\.com")]
        public void GivenIHaveEnteredWww_Google_Com()
        {
            googlePage.openBaseUrl();
        }

                [Given(@"I have entered (.*) into the search line")]
        public void GivenIHaveEnteredIntoTheSearchLine(string p0)
        {
            googlePage.typeSearch("15*20");
        }

                [When(@"I press on search button")]
        public void WhenIPressOnSearchButton()
        {
            googlePage.submitSearch();
        }

                [Then(@"the result should be as expected (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual("300", googlePage.getResult());
            Console.WriteLine("--------------------------" + googlePage.getResult());
        }
       
     }
}
