using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ProceedSolution.Util;
using ProSeed_Test.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProceedSolution
{
    
    public partial class StepDefinition
    {
        public PageFactories ProSeedPageFactory;
        private IWebDriver _driver;

        [BeforeScenario]
        public void LaunchBrowser()
        {
            _driver = DriverInit.Init();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
             ProSeedPageFactory = new PageFactories(_driver);
            LogFiles.WriteToFileStart();
        }
        
               
        [AfterScenario]
        public void quit()
        {
            Thread.Sleep(1000);
            LogFiles.WriteToFileEnd();
            _driver.Quit();
        }        
    }
}