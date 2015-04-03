using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UnitTestProject3.pages;

namespace UnitTestProject3
{
    [Binding]
    public class SearchOnBestbuyFeatureSteps
    {

        private BestbuyLandingPage bestbuyLandingPage;
        private IWebDriver driver;
        private string language = "United States - English";
        private BestBuyHomePage bestbuyHomePage;


        [BeforeScenario()]
        public void setUp()
        {
            driver = DriverManager.getInstance();
            bestbuyLandingPage = new BestbuyLandingPage(driver);
            bestbuyHomePage = new BestBuyHomePage(driver);
        }

        [AfterScenario()]
        public void tearDown()
        {
            driver.Quit();
        }

        [Given(@"I have opened page (.*)")]
        public void GivenIHaveOpenedPage(string url)
        {
            bestbuyLandingPage.openBaseUrl(url);
            bestbuyLandingPage.chooseLanguage(language);


        }

        [Given(@"I have typed (.*) into the search")]
        public void GivenIHaveEnteredIntoTheSearch(string productName)
        {
            bestbuyHomePage.search(productName);

        }

        [When(@"I add to cart (.*) with price (.*)")]
        public void GivenIHaveEnteredIntoTheSearch(string productName, string price)
        {
            bestbuyHomePage.addProductToCart(productName, price);
        }

        [Then(@"The product should be added  to Cart")]
        public void ThenTheProductShouldBeAddedToCart()
        {
            bestbuyHomePage.checkCart();
        }
    }
}
