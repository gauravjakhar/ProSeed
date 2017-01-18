using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProceedSolution.Temp;
using ProceedSolution.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProceedSolution.Pages
{
    public class ProSeedHomePage
    {
        IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'sidebar']")]
        public IWebElement sideBar;

        [FindsBy(How = How.XPath, Using = "//a//span[contains(text(),'Batch')]")]
        public IWebElement tabBatch;

        [FindsBy(How = How.XPath, Using = "//a//span[contains(text(),'Trainee')]")]
        public IWebElement tabTrainee;

        [FindsBy(How = How.XPath, Using = "//*[@id='sidebar']/ul/li[4]")]
        public IWebElement tabLogOut;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Admin')]")]
        public IWebElement tabAdmin;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'page-header')]")]
        public IWebElement header;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'text-right')]/span")]
        public IWebElement userRole;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'text-right')]/span[2]/a")]
        public IWebElement lnkLogOut;

        public ProSeedHomePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            return _driver.Title;
        }

        public void verifySideBar()
        {
            if (sideBar.Enabled)
            {
                Console.Write("SideBar Visible");
            }
        }

        public void CheckAuthorization()
        {
            if (userRole.Enabled)
                LogFiles.WriteLineInFile("Logged in User is - " + userRole.Text, "pass");
            else
                LogFiles.WriteLineInFile("Not Authorized User", "fail");
        }

        public bool CheckLoggedIn()
        {
            if (_driver.Title.Contains("Dash"))
                return true;
            else
                return false;
        }

        public void ClickAdminandVerify()
        {
            tabAdmin.ClickCustom("Admin Tab");
            Thread.Sleep(1000);
            if (header.Text.Contains("Admin"))
            {
                Console.WriteLine("Admin Page Open");
            }
        }
        public void CheckTabName(string tabname)
        {
            if (header.Text.Contains(tabname))
            {
                Console.WriteLine(tabname + "Page Open");
            }
        }
    }
}
