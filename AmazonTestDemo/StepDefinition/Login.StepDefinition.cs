using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ProSeedPageFactory.LoginPage.EnterUidandPwd("g.kumar@prowareness.nl", "Jan@12345");
            ProSeedPageFactory.LoginPage.clickLogin();            
        }
        
        [When(@"The user should be logged in to the system")]
        [Then(@"The user should be logged in to the system")]
        public void ThenTheUserShouldBeLoggedInToTheSystem()
        {

            if (ProSeedPageFactory.LoginPage.getTitle().Contains("Home"))
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Passed Scenario 1: Login With Valid User Email Id.");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Failed Scenario 1: Login With Valid User Email Id.");
                Console.WriteLine("**************************************************");
            }
        }

        //[Given(@"I open ProSeed SignIn Page")]
        //[When(@"I open ProSeed SignIn Page")]
        //[Then(@"I open ProSeed SignIn Page")]
        //public void GivenIOpenProSeedSignInPage()
        //{
        //    ProSeedPageFactory.LoginPage.OpenApplication();
        //}

        //[Given(@"I enter invalid username and password")]
        //[When(@"I enter invalid username and password")]
        //[Then(@"I enter invalid username and password")]
        //public void GivenIEnterInvalidUsernameAndPassword()
        //{
        //    ProSeedPageFactory.LoginPage.EnterUidandPwd("abc@prowareness.nl", "dsjhfg");
        //}

        //[Given(@"I click on Sign in button")]
        //[When(@"I click on Sign in button")]
        //[Then(@"I click on Sign in button")]
        //public void GivenIClickOnSignInButton()
        //{
        //    ProSeedPageFactory.LoginPage.clickLogin();
        //}

        //[Then(@"I check tool tip appearing as Invalid Email ID / Password")]
        //public void ThenICheckToolTipAppearingAsInvalidEmailIDPassword()
        //{
        //    if (ProSeedPageFactory.LoginPage.getInvalidEmailMsg().Contains("Invalid"))
            
        //        {
        //            Console.WriteLine("**************************************************");
        //            Console.WriteLine("Passed Scenario 2: Login With Valid User Email Id.");
        //            Console.WriteLine("**************************************************");
        //        }
        //        else
        //        {
        //            Console.WriteLine("**************************************************");
        //            Console.WriteLine("Failed Scenario 2: Login With Valid User Email Id.");
        //            Console.WriteLine("**************************************************");
        //        }
        //}
        

        //[Given(@"I enter username of wrong format and password")]
        //[When(@"I enter username of wrong format and password")]
        //public void GivenIEnterUsernameOfWrongFormatAndPassword()
        //{
        //   ProSeedPageFactory.LoginPage.EnterUidandPwd("abc@prowareness.nl", "dsjhfg");
        //}

        //[Then(@"I check tool tip appearing as Invalid Email Id")]
        //public void ThenICheckToolTipAppearingAsInvalidEmailId()
        //{
        //    if (ProSeedPageFactory.LoginPage.getInvalidEmailMsg().Contains("Invalid"))
        //    {
        //        Console.WriteLine("**************************************************");
        //        Console.WriteLine("Passed Scenario 3: Login With Valid User Email Id.");
        //        Console.WriteLine("**************************************************");
        //    }
        //    else
        //    {
        //        Console.WriteLine("**************************************************");
        //        Console.WriteLine("Failed Scenario 3: Login With Valid User Email Id.");
        //        Console.WriteLine("**************************************************");
        //    }
        //}

        //[Given(@"I enter (.*) and (.*)")]
        //public void GivenIEnterAnd(string uname, string pwd)
        //{
        //    ProSeedPageFactory.LoginPage.EnterUidandPwd(uname, pwd);
        //}

    }
}
