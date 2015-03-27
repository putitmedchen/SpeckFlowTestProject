using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    class DriverManager
    {
        private static IWebDriver driver;

        private DriverManager() { }

        public static IWebDriver getInstance()
        {
            if (driver == null)
            {
                driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
            }
           
            return driver;
        }
    }
}
