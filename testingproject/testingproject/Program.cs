

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

IWebDriver driver = new ChromeDriver();
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

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHari.Text == "Hello hari!")
{
    Console.Write("Logged in successfully,test passed");
      }
else
{
    Console.Write("Logged in failed, test failed");

}
Thread.Sleep(1000);
//navigate to Time and material page
IWebElement adminstrationDropbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminstrationDropbox.Click();
Thread.Sleep(500);
IWebElement tmmodulepage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmmodulepage.Click();

//click on create new button
Thread.Sleep(1500);
IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNew.Click();
Thread.Sleep(500);

//select typecode as time
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodeDropdown.Click();
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();
//enter code in code text box
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Testproject1");

//enter description in description text box
IWebElement desDropbox = driver.FindElement(By.Id("Description"));
desDropbox.SendKeys("Testproject1");
//enter price per unit in price per unit text box
IWebElement overlappingElement = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
overlappingElement.Click();
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");
// click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(1500);
//check new record has been created successfully
IWebElement gotoLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastpage.Click();
IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(newcode.Text=="Testproject1")
    {
    Console.WriteLine(" newcode created successfully");
}

  else

{ 
        Console.WriteLine("newcode hasn't been created successfully");
}








