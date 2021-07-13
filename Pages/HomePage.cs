using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testscript1.Pages
{
    class HomePage
    {
        // test
        // Function to navigate to Time and Material Page
        public void GoToTimeMaterial(IWebDriver driver)
        {
            //Test Case 2 Create new record

            // Look for Administration Tab and click

            IWebElement adminsitration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminsitration.Click();

            // Identify Time and Material Option and click

            IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterial.Click();
        }
             
    }
}
