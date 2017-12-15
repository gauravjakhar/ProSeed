using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using CustomizedExtendedMethods;

namespace ObjectLibrary.Pages
{
    public class ProSeedAdminPage
    {
        IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add User')]")]
        public IWebElement btnAdd;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'')]")]
        public IWebElement btnDelete;

        [FindsBy(How = How.XPath, Using = "//*[@id='main - container']/div[2]/div/div/div[2]/div/div/table[2]/tbody/tr[1]/td[7]/a[1]")]
        public IWebElement btnUpdate;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'page-header')]/h1")]
        public IWebElement header;

        [FindsBy(How = How.XPath, Using = "//span[contains(@id,'BatchID')]")]
        public IWebElement ddlBatch;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'EmpId')]")]
        public IWebElement txtEmpId;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Name')]")]
        public IWebElement txtName;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Email')]")]
        public IWebElement txtEmail;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Phone')]")]
        public IWebElement txtPhone;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'RoleSelection')]")]
        public IWebElement ddlRole;        

        [FindsBy(How = How.XPath, Using = "//input[contains(value(),'Create')]")]
        public IWebElement btnCreate;

        [FindsBy(How = How.XPath, Using = "//input[contains(value(),'Update')]")]
        public IWebElement btnUpdateUser;

        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'table-striped')]/tbody/tr")]
        public IList <IWebElement> allRows;

        public ProSeedAdminPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void AddMember()
        {
            btnAdd.ClickCustom("Add Member");
        }
        public void VerifyCreateTrainee()
        {
            Thread.Sleep(1000);
            if (header.Text.Contains("Create Tra"))
            {
                Console.WriteLine("Create Trainee Open");
            }
        }
        public void EnterDataandCreate()
        {
            ddlBatch.SelectCustom("5 idiots", "Batch");
            txtEmpId.SendKeysCustom("12345", "Empid");
            txtName.SendKeysCustom("Test", "Name");
            txtEmail.SendKeysCustom("Email@Email.com", "Email");
            txtPhone.SendKeysCustom("9654885678", "Phone");
            btnCreate.ClickCustom("Create");
        }
        public void EnterDataandRole()
        {
            txtPhone.SendKeysCustom("1234567890", "Phone");
            btnUpdateUser.SelectCustom("Admin", "Role");
        }
        public void ClickAlertOK()
        {
            string windowhandle = _driver.CurrentWindowHandle;
            IAlert a = _driver.SwitchTo().Alert();
            a.Accept();
            _driver.SwitchTo().Window(windowhandle);
        }
        public void VerifyAddedTrainee()
        {
            Thread.Sleep(1000);
            if (header.Text.Contains("Admin"))
            {
                Console.WriteLine("Admin Page Open");
            }
            int count = allRows.Count;
            bool found = false;
            foreach(IWebElement item in allRows)
            {
                string name = item.FindElement(By.XPath("/td[2]")).Text;
                if(name.Equals("Test"))
                {
                    Console.WriteLine("Successfully Added");
                    found = true;
                    break;
                }
            }
            if(!found)
                Console.WriteLine("Not Added");
        }
        public void ClickUpdate()
        {
            btnUpdate.ClickCustom("Update button");
        }
    }
}
