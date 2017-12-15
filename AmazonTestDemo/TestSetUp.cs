using OpenQA.Selenium;
using System;
using System.Threading;
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
            Logger.WriteToFileStart();
        }        
               
        [AfterScenario]
        public void quit()
        {
            Thread.Sleep(1000);
            Logger.WriteToFileEnd();
            _driver.Quit();
        }        
    }
}