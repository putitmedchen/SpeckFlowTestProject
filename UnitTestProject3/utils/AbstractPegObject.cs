using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    abstract class AbstractPegObject
    {
        private IWebDriver driver;

        public AbstractPegObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
