using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testingproject.Pages
{
    public class Tmpage
    {
        public void CreateTM(IWebDriver driver)
        {
            // click on Create New button
            Thread.Sleep(1500);
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            Thread.Sleep(500);

            //Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 6);

            // select Time in the typecode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            // enter code in the code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Testproject1");

            // enter description in the description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Newdescription");

            // enter price in price per unit textbox
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            overlappingTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 12);

            // check if new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "Testproject1")
            {
                Console.WriteLine("Time record created successfully.");
            }
            else
            {
                Console.WriteLine("Time record hasn't been created successfully");
            }
        }

        public void EditTM(IWebDriver driver)
        {

            //edit the newcode which created
            IWebElement editNewcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            editNewcode.Click();//click on edit button
            Thread.Sleep(1500);




            //edit code  in code text box
            IWebElement editcodeTextbox = driver.FindElement(By.Id("Code"));
            editcodeTextbox.Clear();
            editcodeTextbox.SendKeys("newtestproject1");
            Thread.Sleep(500);

            //edit description in des text box

            IWebElement editdescTextbox = driver.FindElement(By.Id("Description"));
            editdescTextbox.Clear();
            editdescTextbox.SendKeys("editeddescription");
            Thread.Sleep(500);

            //edit price per unit in pric per unit textbox
            IWebElement overlappingeditElement = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
           

            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            overlappingeditElement.Click();
            editPriceTextbox.Clear();
            overlappingeditElement.Click();
            editPriceTextbox.SendKeys("15");
            Thread.Sleep(1500);

            //save the edited value
            IWebElement saveEditvalue = driver.FindElement(By.Id("SaveButton"));
            saveEditvalue.Click();
            Thread.Sleep(1500);
        }

        public void DeleteTM(IWebDriver driver)
        {
            // click go to the late page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            
            Thread.Sleep(1500);
            //Delete the time and material details
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(500);
            driver.SwitchTo().Alert().Accept();

            IWebElement delCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
        }
    }
    
    
}
 



