using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UnitTestProject3.pages;

namespace UnitTestProject3
{
    [Binding]
    public class ApplyToJobFromMultipleUsersFeatureSteps
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


        [Given(@"I have ciklum home page (.*)")]
        public void GivenIHaveCiklumHomePage(string url){
            ciklumPage.openUrl(url);
        }

        [Given(@"I have found vacancy (.*)")]
        public void GivenIHaveEnteredCiklumJobsPage(string vacancy)
        {
            ciklumPage.findVacancy(vacancy);
        }

        [When(@"I have entered name, lastname, phone, email for each of users")]
        public void WhenIHaveEnteredNameLastnamePhoneEmailForEachOfUsers(Table table)
        {
            foreach (var row in table.Rows)
            {
                var name = row["Name"];
                var lastName = row["LastName"];
                var email = row["Email"];
                var phone = row["Phone"];

                vacancyPage.multipleUsersApply(name, lastName,email ,phone);
            }
        }

        [Then(@"I applied for job from (.*) users")]
        public void ThenIAppliedForJobFromUsers()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
