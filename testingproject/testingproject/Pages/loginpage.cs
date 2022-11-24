using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject.Pages
{
    public class loginpage
    {
        public void loginActions(IWebDriver driver)
        {
            
            driver.Manage().Window.Maximize();
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // identify username test box and enter valid username

            IWebElement usernameTestbox = driver.FindElement(By.Id("UserName"));
            usernameTestbox.SendKeys("hari");
            //identify password testbox and enter valid password
            IWebElement passwordTestbox = driver.FindElement(By.Id("Password"));
            passwordTestbox.SendKeys("123123");

            //click login
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();
            //check if user loggedin successfully


        }

    }
}
