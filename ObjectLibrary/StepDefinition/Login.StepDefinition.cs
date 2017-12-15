using ProceedSolution.Helper;
using ProceedSolution.Util;
using TechTalk.SpecFlow;

namespace ProceedSolution
{
    [Binding]
     public partial class StepDefinition
    {
        [Given(@"I login to ProSeed Application")]
        [When(@"I login to ProSeed Application")]
        public void GivenILoginToProSeedApplication()
        {            
            ProSeedPageFactory.LoginPage.OpenApplication();          
        }
        
        [When(@"The user should be logged in to the system")]
        [Then(@"The user should be logged in to the system")]
        public void ThenTheUserShouldBeLoggedInToTheSystem()
        {
            bool log = false;
            log = ProSeedPageFactory.HomePage.CheckLoggedIn();
            if (log)
                Logger.WriteLineInFile("Logged in", "pass");
            else
                Logger.WriteLineInFile("Not Logged in", "fail");
        }

    }
}
