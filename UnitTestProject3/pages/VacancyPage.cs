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
    class VacancyPage
    {
        private IWebDriver driver;
        private string myVacancy = "http://jobs.ciklum.com/jobs/automated-qas-for-e-boks/";

        private string nameError = ": “Name” is a required field.";
        private string lastNameError = ": “Last Name” is a required field.";
        private string emailError = ": “Email” is a required field.";


       

        [FindsBy(How = How.XPath, Using = "//form[@class='main_form']/p/input[@class='submit']")]
        private IWebElement submitAplication;

        [FindsBy(How = How.XPath, Using = ".//*[@id='sr2']/div[2]/a")]
        private IWebElement applyButton;
       

        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement nameRequired;

        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement lastNameRequired;

        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement emailRequired;


        public VacancyPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }


        public void applyToJob()
        {
            applyButton.Click();
        }
       

        public void validateError()
        {
            submitAplication.Submit();
            applyButton.Click();

            Assert.That(nameError, Is.EqualTo(nameRequired.Text));
            Assert.That(lastNameError, Is.EqualTo(lastNameRequired.Text));
            Assert.That(emailError, Is.EqualTo(emailRequired.Text));
            

        }

    }
}
