using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject.Pages
{
    public class homepage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            Thread.Sleep(1500);
            //navigate to Time and material page
            IWebElement adminstrationDropbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropbox.Click();
            Thread.Sleep(500);
            IWebElement tmmodulepage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmmodulepage.Click();

            // IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            //if (helloHari.Text == "Hello hari!")
            //{
            //  Console.Write("Logged in successfully,test passed");
            //}
            //else
            //{
            //  Console.Write("Logged in failed, test failed");

            //}   

        }

        public void GoToEmployeepage(IWebDriver driver)
        //navigating to employee page

        {
            Thread.Sleep(1500);
            //navigate to empployee page
            IWebElement adminstrationDropbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropbox.Click();
            Thread.Sleep(500);
            IWebElement Employeepagebutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeepagebutton.Click();
        }
    
    
    }
}
