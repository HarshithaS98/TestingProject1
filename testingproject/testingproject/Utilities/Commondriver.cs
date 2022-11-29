
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testingproject.Pages;
namespace testingproject.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void loginSteps()
        {
            driver = new ChromeDriver();
            // Login page object initialization and definition
            loginpage loginpageObj = new loginpage();
            loginpageObj.loginActions(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


        [OneTimeTearDown]
        public void closeTestRun()

        {
            driver.Quit();

        }



    }

}