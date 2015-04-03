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

        public void addProductToCart(string productName, string price)
        {
            driver.FindElement(By.XPath("//div[@class='list-item'][//a[contains(text(),'" + productName + "')] and .//div[@class='medium-item-price'] and contains(text(),'" + price + "')]]//span[@class='label-add-to-cart']"));
        }

        public void checkCart()
        {
            Assert.AreEqual(1, int.Parse(cartElements.Text));
        }
    }
}
