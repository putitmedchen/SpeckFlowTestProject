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

        [FindsBy(How = How.XPath, Using = "//form[@class='main_form']/p/input[@class='submit']")]
        private IWebElement submitAplication;

        [FindsBy(How = How.XPath, Using = "//a[@class='apply apply_online' or @class='apply apply_online active']")]
        private IWebElement applyOnline;

        [FindsBy(How = How.XPath, Using = "//span/div[1]")]
        private IWebElement NameErrorField;

        [FindsBy(How = How.XPath, Using = "//span/div[2]")]
        private IWebElement LastNameErrorField;

        [FindsBy(How = How.XPath, Using = "//span/div[3]")]
        private IWebElement EmailErrorField;

        [FindsBy(How = How.XPath, Using = "//span/div")]
        private IList<IWebElement> errorsList;

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

        public void submitApplication()
        {
            applyOnline.Click();
            submitAplication.Click();

            applyOnline.Click();
        }

        public void validateErrors(List<string> expectedErrosList)
        {

            for (int i = 0; i < errorsList.Count; i++)
            {
                IWebElement error = errorsList[i];
                for (int k = i; k < expectedErrosList.Count; k++)
                {
                    string expectedError = expectedErrosList[i];
                    Assert.AreEqual(expectedError, error.Text);
                    break;
                }

            }

        }

        public void pause(int miliSeconds)
        {
            System.Threading.Thread.Sleep(miliSeconds);
        }

        public void multipleUsersApply(string name, string lastName, string email, string phone)
        {
            applyOnline.Click();

            nameField.SendKeys(name);
            lastNameField.SendKeys(lastName);
            emailField.SendKeys(email);
            phoneField.SendKeys(phone);

            submitAplication.Click();
        }

    }
}
