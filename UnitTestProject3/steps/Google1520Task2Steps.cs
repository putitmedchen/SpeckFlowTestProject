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

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            googlePage.openBaseUrl();
            googlePage.typeSearch("15*20");
            googlePage.submitSearch();
        }

        [Given(@"I have result for multiplying (.*)")]
        public void GivenIHaveResultForMultiplying(string p0)
        {
            result = googlePage.getResult();
        }

        [Given(@"I add result into search line")]
        public void GivenIAddResultIntoSearchLine()
        {
            googlePage.typeSearch("+" + result);
        }

        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            googlePage.submitSearch();
        }
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnThe_Screen(int p0)
        {
            result = googlePage.getResult();
            Assert.AreEqual("600", result);
            Console.WriteLine("--------------------------" + result);
        }
    }
}
