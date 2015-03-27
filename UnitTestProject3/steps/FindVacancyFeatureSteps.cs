using OpenQA.Selenium;
using System;
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
               
                [Given(@"I have entered Ciklum jobs search page")]
        public void GivenIHaveEnteredCiklumJobsSearchPage()
        {
            ciklumPage.openBaseUrl();
        }

                [Given(@"I found vacancy for which I applied")]
        public void GivenIFoundVacancyForWhichIApplied()
        {
            ciklumPage.findVacancy();
        }

                [When(@"I press Apply for")]
        public void WhenIPressApplyFor()
        {
            //driver.Url("http://jobs.ciklum.com/jobs/automated-qas-for-e-boks/");
            vacancyPage.applyToJob();

        }

                [Then(@"the result should be Error message  on the form")]
        public void ThenTheResultShouldBeErrorMessageOnTheForm()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
