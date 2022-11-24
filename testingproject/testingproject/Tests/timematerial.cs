using testingproject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
loginpage loginPageObj = new loginpage();
loginPageObj.loginActions(driver);

// Home page object initialization and definition
homepage homePageObj = new homepage();
homePageObj.GoToTMPage(driver);

// TM Page object initialization and definition
Tmpage tmPageObj = new Tmpage();
tmPageObj.CreateTM(driver);

tmPageObj.EditTM(driver);

tmPageObj.DeleteTM(driver);






