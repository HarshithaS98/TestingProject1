using System;
using TechTalk.SpecFlow;
using testingproject.Pages;

namespace testingproject.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into turnup portal")]
        public void GivenILoggedIntoTurnupPortal()
        {
            driver = new ChromeDriver();

            loginpage loginPageObj = new loginpage();
            loginPageObj.loginActions(driver);
        }

        [When(@"I navigated to time and material page")]
        public void WhenINavigatedToTimeAndMaterialPage()
        {
            // Home page feature initialization and definition
            homepage homePageObj = new homepage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a time and material record")]
        public void WhenICreateATimeAndMaterialRecord()
        {
            //TM Page create feature initialization and definition
            Tmpage tmPageObj = new Tmpage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be createdsuccessfully")]
        public void ThenTheRecordShouldBeCreatedsuccessfully()
        {
            Tmpage tmPageObj = new Tmpage();
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);
            Assert.That(newCode == "Testproject1", "Actual code and expected code do not match");
            Assert.That(newDescription == "Testproject1", "Actual description and expected description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expeected price do not match.");
        }
        [When(@"I update '([^']*)' on an existing time record")]
        public void WhenIUpdateOnAnExistingTimeRecord(string Description)
        {
            Tmpage tmPageObj = new Tmpage();
            tmPageObj.EditTM(driver, Description);
        }

        [Then(@"The record should have been updated '([^']*)'")]
        public void ThenTheRecordShouldHaveBeenUpdated(string Description)
        {
            Tmpage tmPageObj = new Tmpage();

            string editDescription = tmPageObj.GetEditedDescription(driver);

            Assert.That(editDescription == Description, "Actual desription and expected description do not match");

        }
    }
}
