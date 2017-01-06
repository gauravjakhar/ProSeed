using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedSolution.Pages
{
    public class ProSeedAdminPage
    {
        IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Member')]")]
        public IWebElement btnAdd;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Member')]")]
        public IWebElement btnDelete;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Member')]")]
        public IWebElement btnUpdate;

        public ProSeedAdminPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
