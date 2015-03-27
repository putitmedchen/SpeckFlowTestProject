using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.pages
{
    class BestBuyHomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "gh-search-input")]
        private IWebElement searchLine;

        [FindsBy(How = How.XPath, Using = "//button[@title='Search']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='list-item'][//a[contains(text(),'Surface Pro 3')] and .//span[@class='regular-price' and contains(text(),'$999.99')]]//span[@class='label-add-to-cart']")]
        private IWebElement product;

        [FindsBy(How = How.XPath, Using = "//div[@class='count-container']/span[@class='count']")]
        private IWebElement cartElements;

        public BestBuyHomePage(IWebDriver webdriver)
        {
            driver = webdriver;
            PageFactory.InitElements(driver, this);
        }

        public void search(String productName)
        {
            searchLine.SendKeys(productName);
            searchButton.Click();
        }

        public void addToCart()
        {
            product.Click();
            
        }

        public void checkCart()
        {
            Assert.AreEqual(1, int.Parse(cartElements.Text));
        }

    }
}
