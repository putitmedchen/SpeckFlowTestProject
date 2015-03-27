using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    class GooglePage 
    {

        private static IWebDriver driver;
        private String baseUrl = "https://www.google.com";

        [FindsBy(How = How.Id, Using = "lst-ib")]
        private IWebElement searchLine;

        [FindsBy(How = How.XPath, Using = "//button[@name='btnG']")]
        private IWebElement searchButton;

        [FindsBy(How = How.Id, Using = "cwos")]
        private IWebElement resultPlaceholder;

        [FindsBy(How = How.XPath, Using = "//div[@class='srg']/li")]
        private IList<IWebElement> searchResults;

        public GooglePage(IWebDriver webdriver)
        {
            driver = webdriver;
            
            PageFactory.InitElements(driver, this);

        }

        public void openBaseUrl()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void typeSearch(String str)
        {
            searchLine.SendKeys(str);
        }


        public void submitSearch()
        {
            searchButton.Click();
        }

        public String getResult()
        {
            return resultPlaceholder.Text;
        }

        public int countSearchResult()
        {
            return searchResults.Count;
        }
    }
}
