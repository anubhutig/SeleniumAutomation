using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testscript1.Utilities
{
    class Wait
    {
        // Re-usable Function For Wait
        public static void WaitForWebElement(IWebDriver driver, string attributeValue, string attribute, int secondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
            if (attribute == "XPath")
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));
            }
            if (attribute =="Id")
            {
               
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributeValue)));
            }
            if (attribute == "CssSelector")
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));
            }

        }

        internal static void WaitForWebElementToExist(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
