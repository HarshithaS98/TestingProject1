using testingproject.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.DevTools;
using testingproject.Utilities;

namespace testingproject.Tests
{
    [TestFixture]
    public  class Timematerial : Commondriver
    {
        [SetUp]
        public void LoginSteps()
        {
              driver = new ChromeDriver();
              // Login page object initialization and definition
               loginpage loginPageObj = new loginpage();
               loginPageObj.loginActions(driver);

              // Home page object initialization and definition
              homepage homePageObj = new homepage();
              homePageObj.GoToTMPage(driver);

        }

        [Test]
        public void CreateTm()
        {
               //TM Page object initialization and definition
                Tmpage tmPageObj = new Tmpage();
                tmPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTm()

        {
                Tmpage tmPageObj = new Tmpage();
                tmPageObj.EditTM(driver);
        }
        [Test]
        public void DeleteTm()
        {
                 Tmpage tmPageObj = new Tmpage();
                 tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()

        {
            driver.Quit();

        }
        
        
        
       

        
        

        

        



    }
}
