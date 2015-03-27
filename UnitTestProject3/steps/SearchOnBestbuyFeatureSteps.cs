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
        private string productName = "surface pro 3";
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

                [Given(@"I have entered surface pro (.*) into the search")]
        public void GivenIHaveEnteredSurfaceProIntoTheSearch(int p0)
        {
            bestbuyLandingPage.openBaseUrl();
            bestbuyLandingPage.chooseLanguage(language);


        }

                [Given(@"I choose from list surface pro (.*) with price (.*)")]
        public void GivenIChooseFromListSurfaceProWithPrice(int p0, Decimal p1)
        {
            bestbuyHomePage.search(productName);
           
        }

                [When(@"I press on add to Cart button")]
        public void WhenIPressOnAddToCartButton()
        {
            bestbuyHomePage.addToCart();
        }

                [Then(@"The product should be added  to Cart")]
        public void ThenTheProductShouldBeAddedToCart()
        {
            bestbuyHomePage.checkCart();
        }
     }
}
