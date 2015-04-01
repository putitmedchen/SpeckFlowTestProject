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
        private String baseUrl = "http://jobs.ciklum.com/search-and-apply/";

        [FindsBy(How = How.XPath, Using = "//select[@name='location']")]
        private IWebElement allOffices;

        [FindsBy(How = How.XPath, Using = "//button[@title='search']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='sr2']/div[2]/a")]
        private IWebElement applyButton;
      
        [FindsBy(How = How.XPath, Using = "//div[@class='srg']/li")]
        private IList<IWebElement> searchResults;

        public CiklumVacancyPage(IWebDriver webdriver)
        {
            driver = webdriver;
            PageFactory.InitElements(driver, this);

        }


        public void openBaseUrl()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void findVacancy()
        {
            allOffices.FindElement(By.Name("Lviv")).Click();
            searchButton.Click();
        }

        

    }
}
