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

            //Test Case 1 Login to TurnUp Portal
            
            // Open Chrome Browser

            IWebDriver driver = new ChromeDriver(@"C:\Users\averm\Desktop\Automation\Automation_test1");
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


            // Check If User Is Logged In Successfully

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
                if(helloHari.Text== "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
        else
            { Console.WriteLine("Log in failed, Test failed");
            }
            
                //Test Case 2 Create new record

                // Look for Administration Tab and click

            IWebElement adminsitration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminsitration.Click();

            // Identify Time and Material Option and click

            IWebElement timeandmaterial  = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterial.Click();

            // Identify Create New Button and click

            IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnew.Click();

            // Identify TypeCode Dropdown and Click

            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));                                 
            typecode.Click();
            Thread.Sleep(2000);

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
            Thread.Sleep(500);
            IWebElement priceadd = driver.FindElement(By.Id("Price"));
            priceadd.SendKeys("20");

            // Identify Select Files and click

            // Identify Save Button and Click

            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();
            Thread.Sleep(1500);

            // Navigate to last page

            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(3000);

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

            // Test Case 3 Validate edit button
                                     
            //Identify edit button and click

            IWebElement editbutton1 = driver.FindElement(By.XPath("//td[text()='222']//following::a[1]"));
            editbutton1.Click();


            // Identify TypeCode Dropdown and Click

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000); 

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
            Thread.Sleep(500);
            IWebElement priceadd1 = driver.FindElement(By.Id("Price"));
            priceadd1.Clear();
            price1.Click();
            priceadd1.SendKeys("200");

            Thread.Sleep(500);

            // Identify Select Files and click

            // Identify Save Button and Click

            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1500);

            // Navigate to last page

             driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
             Thread.Sleep(3000);

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
                 
            // Test Case 4 Delete created record

            // Identify Delete Button and Delete Record

            IWebElement delete = driver.FindElement(By.XPath("//td[text()='567']//following::a[2]"));
            delete.Click();
            driver.SwitchTo().Alert().Accept();
            

            // Navigate to last page

             driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
             Thread.Sleep(3000);

            // Validate Record Deletion 

            IWebElement recentcode2 = driver.FindElement(By.XPath("//td[text()='567']"));
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
