using OpenQA.Selenium;
using ProceedSolution.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedSolution
{
    public partial class PageFactories

    {
        public readonly ProSeedLoginPage LoginPage;
        public readonly ProSeedHomePage HomePage;
        public readonly ProSeedAdminPage AdminPage;

        public PageFactories(IWebDriver driver)
        {
            LoginPage = new ProSeedLoginPage(driver);
            HomePage = new ProSeedHomePage(driver);
            AdminPage = new ProSeedAdminPage(driver);
        }


    }
}
