using Automation_testscript1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation_testscript1.Pages
{
    class TimeMaterial
    {
        // Test - Create new Record
        public void CreateTimeMaterial(IWebDriver driver)
        {
            // Identify Create New Button and click

            IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnew.Click();

            // Identify TypeCode Dropdown and Click

            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecode.Click();
            Wait.WaitForWebElement(driver, "//*[@id='TypeCode_option_selected']","XPath",5);

            // Identify Material from list and Click

            IWebElement material = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            material.Click();

            // Identify Code Textbox and Enter Valid Input

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("222");

            // Identify Description Textbox and Enter valid Description

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Test Automation");


            // Identify Price Per Unit Textbox and Enter Valid Price

            IWebElement price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            price.Click();
            Wait.WaitForWebElement(driver, "Price", "Id", 5);
            IWebElement priceadd = driver.FindElement(By.Id("Price"));
            priceadd.SendKeys("20");

            // Identify Select Files and click

            // Identify Save Button and Click

            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();
            Wait.WaitForWebElement(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);

            // Navigate to last page

            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Wait.WaitForWebElement(driver, "//td[text()='222']", "XPath", 5);

            // Validate new record creation

            IWebElement recentcode = driver.FindElement(By.XPath("//td[text()='222']"));
            if (recentcode.Text == "222")
            {
                Console.WriteLine("Record created successfully");
            }
            else
            {
                Console.WriteLine("Record creation failed");
            }
        }

        // Test - Edit Created Record
        public void EditTimeMaterial(IWebDriver driver)
        {
            // Test Case 3 Validate edit button

            //Identify edit button and click

            IWebElement editbutton1 = driver.FindElement(By.XPath("//td[text()='222']//following::a[1]"));
            editbutton1.Click();


            // Identify TypeCode Dropdown and Click

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            

            // Identify Time from list and Click

            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();

            // Identify Code Textbox and Enter Valid Input

            driver.FindElement(By.Id("Code")).Clear();
            driver.FindElement(By.Id("Code")).SendKeys("567");



            // Identify Description Textbox and Enter valid Description

            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("Test Automation edited record");


            // Identify Price Per Unit Textbox and Enter Valid Price

            IWebElement price1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            price1.Click();
            Wait.WaitForWebElement(driver, "Price", "Id", 5);
            IWebElement priceadd1 = driver.FindElement(By.Id("Price"));
            priceadd1.Clear();
            price1.Click();
            priceadd1.SendKeys("200");

            

            // Identify Select Files and click

            // Identify Save Button and Click

            driver.FindElement(By.Id("SaveButton")).Click();
            
            // Navigate to last page

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Wait.WaitForWebElement(driver, "//td[text()='567']", "XPath", 5);

            // Validate new record creation

            IWebElement recentcode1 = driver.FindElement(By.XPath("//td[text()='567']"));
            if (recentcode1.Text == "567")
            {
                Console.WriteLine("Record edited successfully");
            }
            else
            {
                Console.WriteLine("Record editing failed");
            }
        }

        // Test - Delete Created Record
        public void DeleteTimeMaterial(IWebDriver driver)
        {
            // Test Case 4 Delete created record

            // Identify Delete Button and Delete Record

            IWebElement delete = driver.FindElement(By.XPath("//td[text()='567']//following::a[2]"));
            delete.Click();
            driver.SwitchTo().Alert().Accept();


            // Navigate to last page

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Wait.WaitForWebElement(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", "XPath", 5);

            // Validate Record Deletion 

            IWebElement recentcode2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (recentcode2.Text == "567")
            {
                Console.WriteLine("Record not deleted");
            }
            else
            {
                Console.WriteLine("Record deleted");
            }
        }
    }
}
