using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject3.utils;

namespace UnitTestProject3.pages
{
    class VacancyPage
    {
        private IWebDriver driver;
        private string myVacancy = "http://jobs.ciklum.com/jobs/automated-qas-for-e-boks/";

        private string nameError = "ERROR: “Name” is a required field.";
        private string lastNameError = "ERROR: “Name” is a required field.";
        private string emailError = "ERROR: “Name” is a required field.";


        [FindsBy(How = How.XPath, Using = "//form[@class='main_form']/p/input[@class='submit']")]
        private IWebElement submitAplication;

        [FindsBy(How = How.XPath, Using = ".//*[@id='sr2']/div[2]/a")]
        private IWebElement applyButton;

        [FindsBy(How = How.XPath, Using = "//a[@class='apply apply_online' or @class='apply apply_online active']")]
        private IWebElement applyOnline;
       
        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement nameRequired;

        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement lastNameRequired;

        [FindsBy(How = How.XPath, Using = "//div[@class='notice error']/span/div[1]")]
        private IWebElement emailRequired;

        [FindsBy(How = How.XPath, Using = "//input[@id='your_name']")]
        private IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//input[@id='your_last_name']")]
        private IWebElement lastNameField;

        [FindsBy(How = How.XPath, Using = "//input[@id='your_email']")]
        private IWebElement emailField;

        [FindsBy(How = How.XPath, Using = "//input[@id='your_tel']")]
        private IWebElement phoneField;

        
        public VacancyPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }


        public  void applyToJob()
        {
            pause(8000);
            applyButton.Click();
        }
       

        public void validateError()
        {
            applyOnline.Click();
            submitAplication.Click();
            applyOnline.Click();

            Assert.That(nameError, Is.EqualTo(nameRequired.Text));
            Assert.That(lastNameError, Is.EqualTo(lastNameRequired.Text));
            Assert.That(emailError, Is.EqualTo(emailRequired.Text));
            
        }

        public void pause(int miliSeconds)
        {
            System.Threading.Thread.Sleep(miliSeconds);
        }


        [TestCase("sgo","sgoLast","qwe@mail.ru", "987654321")]
        public void multipleUsersApply(string name, string lastName, string email, string phone)
        {
            nameField.SendKeys(name);
            lastNameField.SendKeys(lastName);
            emailField.SendKeys(email);
            phoneField.SendKeys(phone);
        }

    }
}
