using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject.Pages
{
    public class Employeepage : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //IWebElement createEmployeebutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            //createEmployeebutton.Click();
            //Thread.Sleep(1000);
            
            //// create name for employee in name testbox
            //IWebElement nameTextbox = driver.FindElement(By.Id("Name")); 
            //nameTextbox.SendKeys("HarshithaTests");
            //Thread.Sleep(500);
          
            //// create username in username textbox
            //IWebElement usernameEmployeeTextbox = driver.FindElement(By.Id("Username"));
            //usernameEmployeeTextbox.SendKeys("HarshithaAutomation");
            //Thread.Sleep(500);

            //// create contact details for employee

            //IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            //contactTextbox.SendKeys("444");
            //Thread.Sleep(500);

            ////create password details for employee

            //IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            //passwordTextbox.SendKeys("Automation_4");
            //Thread.Sleep(500);

            ////  Retyping password

            //IWebElement ReTypePasswordTextbox = driver.FindElement(By.Id("RetypePaasword"));
            //ReTypePasswordTextbox.SendKeys("Automation_4");
            //Thread.Sleep(500);

            ////create groups

            //IWebElement groupsdropDownTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            //groupsdropDownTextbox.Click();

            //// selecting bnn from groups

            //IWebElement selectbnn = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            //selectbnn.Click();
            //Thread.Sleep(500);

            //// saving all employee data

            //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            //saveButton.Click();


        }
        public void EditEmp(IWebDriver driver)
        {

        }
        public void DeleteEmp(IWebDriver driver)
        {

        }

    }

}



