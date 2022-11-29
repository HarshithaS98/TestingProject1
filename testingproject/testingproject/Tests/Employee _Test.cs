using testingproject.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.DevTools;
using testingproject.Utilities;

namespace testingproject.Tests
{
    [TestFixture]
    public  class Employee__Test : CommonDriver
  
    {
         [Test, Order(1)]
        [Parallelizable]
        public void CreateEmployee()
            {
                // Home page object initialization and definition
              homepage homePageObj = new homepage();
                 homePageObj.GoToEmployeepage(driver);

                 //employee Page object initialization and definition
                Employeepage employeePageObj = new Employeepage();
                employeePageObj.CreateEmployee(driver);

            }  
                
             [Test, Order(2)]
             
             public void EditEmployeepage()
             {
             // Home page object initialization and definition
                homepage homePageObj = new homepage();
                homePageObj.GoToEmployeepage(driver);

                // edit page object initialization
              Employeepage employeePageObj = new Employeepage();
                 employeePageObj.EditEmp(driver);

             }
        
             [Test, Order(3)]
              public void DeleteEmployeepage()
              {
               // Home page object initialization and definition
                 homepage homePageObj = new homepage();
                  homePageObj.GoToEmployeepage(driver);

               // delete employee page object initialization
                 Employeepage employeePageObj = new Employeepage();
                employeePageObj.DeleteEmp(driver);
              }



    }
}

