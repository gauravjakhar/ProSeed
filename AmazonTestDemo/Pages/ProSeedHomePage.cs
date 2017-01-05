using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedSolution.Pages
{
    public class ProSeedHomePage
    {   IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Dashboard')]")]
        public IWebElement TabDashboard;

        [FindsBy(How = How.XPath, Using = "//a//span[contains(text(),'Batch')]")]
        public IWebElement TabBatch;

        [FindsBy(How = How.XPath, Using = "//a//span[contains(text(),'Trainee')]")]
        public IWebElement TabTrainee;

        [FindsBy(How = How.XPath, Using = "//*[@id='sidebar']/ul/li[4]")]
        public IWebElement TabLogOut;

        public ProSeedHomePage(IWebDriver driver)
        {
            this._driver=driver;
            PageFactory.InitElements(driver,this);
        }

        public String getTitle()
        {
            return _driver.Title;
        }

        public void verifyClickTabs()
        {
            TabBatch.Click();
            if (getTitle().Contains("Batch list"))
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Passed Scenario Batch tab.");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Failed Scenario Batch tab");
                Console.WriteLine("**************************************************");
            }

            TabTrainee.Click();

            if (getTitle().Contains("Trainee List"))
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Passed Scenario Trainee tab.");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Failed Scenario Trainee tab.");
                Console.WriteLine("**************************************************");
            }

            TabLogOut.Click();
            if (getTitle().Contains("Login"))
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Passed Scenario Logout tab.");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Failed Scenario Logout tab.");
                Console.WriteLine("**************************************************");
            }






        }






    }
}
