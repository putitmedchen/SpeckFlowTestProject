using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UnitTestProject3.pages;

namespace UnitTestProject3
{
    [Binding]
    public class FindVacancyFeatureSteps
    {

        private CiklumVacancyPage ciklumPage;
        private VacancyPage vacancyPage;
        private IWebDriver driver;

        [BeforeScenario()]
        public void setUp()
        {
            driver = DriverManager.getInstance();
            ciklumPage = new CiklumVacancyPage(driver);
            vacancyPage = new VacancyPage(driver);
        }

        [AfterScenario()]
        public void tearDown()
        {
            driver.Quit();
        }

        [Given(@"I have entered (.*) Ciklum jobs search page")]
        public void GivenIHaveEnteredCiklumJobsSearchPage(string url)
        {
            ciklumPage.openUrl(url);
        }

        [Given(@"I opened vacancy (.*)")]
        public void GivenIOpenedVacancy(string vacancy)
        {
            ciklumPage.findVacancy(vacancy);
        }

        [When(@"I submitted my application")]
        public void WhenISubmittedMyApplication()
        {
            vacancyPage.submitApplication();

        }

        [Then(@"the result should be Error message  on the form")]
        public void ThenTheResultShouldBeErrorMessageOnTheForm(Table table)
        {
            List<string> errors = new List<string>();

            foreach (var row in table.Rows)
            {
                var error = row["Error message"];
                errors.Add(error);
            }
            vacancyPage.validateErrors(errors);
        }
    }
}
