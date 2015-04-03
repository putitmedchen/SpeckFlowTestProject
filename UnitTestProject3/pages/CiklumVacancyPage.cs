using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.pages
{
    class CiklumVacancyPage
    {
        
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//select[@name='location']")]
        private IWebElement allOffices;

        [FindsBy(How = How.XPath, Using = "//button[@title='search']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='srg']/li")]
        private IList<IWebElement> searchResults;

        public CiklumVacancyPage(IWebDriver webdriver)
        {
            driver = webdriver;
            PageFactory.InitElements(driver, this);
        }

        public void openUrl(string url)
        {
            driver.Navigate().GoToUrl("http://" + url);
        }

        public void findVacancy(string vacancyName)
        {
            allOffices.FindElement(By.Name("Lviv")).Click();
            searchButton.Click();

            pause(7000);

            driver.FindElement(By.XPath("//a[contains(text(),'" + vacancyName + "')]")).Click();
        }

        public void pause(int miliSeconds)
        {
            System.Threading.Thread.Sleep(miliSeconds);
        }

    }
}
