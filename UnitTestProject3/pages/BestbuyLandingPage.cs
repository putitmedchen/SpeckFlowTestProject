using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.pages
{
    class BestbuyLandingPage
    {
        private static IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//select[@name='select_locale']/option[contains(text(),'United States - English')]")]
        private IWebElement countryChooser;

        [FindsBy(How = How.XPath, Using = "//img[@alt='Go']")]
        private IWebElement goButton;


        public BestbuyLandingPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);

        }

        public void openBaseUrl(string url)
        {
            driver.Navigate().GoToUrl("http://" + url);
        }

        public void chooseLanguage(string language)
        {
            countryChooser.Click();
            goButton.Click();
        }

    }
}
