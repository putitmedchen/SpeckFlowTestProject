using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace UnitTestProject3
{
    class GooglePage 
    {

        private static IWebDriver driver;

        [FindsBy(How = How.Id, Using = "lst-ib")]
        private IWebElement searchLine;

        [FindsBy(How = How.XPath, Using = "//button[@name='btnG']")]
        private IWebElement searchButton;

        [FindsBy(How = How.Id, Using = "cwos")]
        private IWebElement resultPlaceholder;

        [FindsBy(How = How.XPath, Using = "//div/h3/a")]
        private IList<IWebElement> searchResults;

        public GooglePage(IWebDriver webdriver)
        {
            driver = webdriver;
            PageFactory.InitElements(driver, this);
        }

        public void openBaseUrl(string address)
        {
            driver.Navigate().GoToUrl("https://" + address);
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
            pause(3000);
            return resultPlaceholder.Text;
        }

        public void countsSearchResult(int expectedCounts)
        {

            Assert.AreEqual(expectedCounts, searchResults.Count);
        }

        public void pause(int miliSeconds)
        {
            System.Threading.Thread.Sleep(miliSeconds);
        }
        
    }
}
