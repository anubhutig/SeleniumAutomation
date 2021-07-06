using Automation_testscript1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Automation_testscript1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Open Chrome Browser
            IWebDriver driver = new ChromeDriver(@"C:\Users\averm\Desktop\Automation\Automation_test1");

            // Object for Login Page
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginActions(driver);

            // Object for Home Page
            HomePage HomeObj = new HomePage();
            HomeObj.GoToTimeMaterial(driver);

            // Object for Time and Material
            TimeMaterial TMObj = new TimeMaterial();
            TMObj.CreateTimeMaterial(driver);

            // Object to edit record
            TMObj.EditTimeMaterial(driver);

            // Object to delete record
            TMObj.DeleteTimeMaterial(driver);

           









        }

    }
}
