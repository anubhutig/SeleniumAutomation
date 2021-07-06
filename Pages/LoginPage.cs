using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testscript1.Pages
{
    class LoginPage
    {
        // Function to allow users to Login
        public void LoginActions(IWebDriver driver) 
        {
            //Test Case 1 Login to TurnUp Portal

            // Open Chrome Browser

            driver.Manage().Window.Maximize();

            // Launch Turn Up Portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

            // Identify Username Textbox and Enter Valid Username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Identify Password Textbox and Enter Valid Password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Identify Login Action Button And Click

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
