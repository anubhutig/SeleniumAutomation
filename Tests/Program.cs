using Automation_testscript1.Pages;
using Automation_testscript1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Automation_testscript1
{
    [TestFixture]
    class Program : CommonDriver
    {
       
        [SetUp]
        public void LoginSteps()
        {
            // Open Chrome Browser
             driver = new ChromeDriver(@"C:\Users\averm\Desktop\Automation\Automation_test1");

            // Object for Login Page
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginActions(driver);

            // Object for Home Page
            HomePage HomeObj = new HomePage();
            HomeObj.GoToTimeMaterial(driver);
        }

        [Test]
        public void CreateTimeMaterial()
        {
            // Object for Time and Material
            TimeMaterial TMObj = new TimeMaterial();
            TMObj.CreateTimeMaterial(driver);

        }

        [Test]
        public void EditTimeMaterial()
        {
            // Object to edit record
            TimeMaterial TMObj = new TimeMaterial();
            TMObj.EditTimeMaterial(driver);
        }

        [Test]
        public void DeleteTimeMaterial()
        {
            // Object to delete record
            TimeMaterial TMObj = new TimeMaterial();
            TMObj.DeleteTimeMaterial(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
