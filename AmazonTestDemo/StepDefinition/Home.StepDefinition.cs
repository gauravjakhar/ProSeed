﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProceedSolution
{   
    public partial class StepDefinition
    {
        [Then(@"The user should be able to see the tabs on the left side")]
        public void ThenTheUserShouldBeAbleToSeeTheTabsOnTheLeftSide()
        {
            ProSeedPageFactory.HomePage.verifySideBar();
        }

        [Given(@"I am on Admin Page")]
        [Then(@"I am on Admin Page")]
        public void GivenIAmOnAdminPage()
        {
            ProSeedPageFactory.HomePage.ClickAdminandVerify();
        }

        [Then(@"Validate the role")]
        [Then(@"Get a message that you are not authorized")]
        public void ThenGetAMessageThatYouAreNotAuthorized()
        {
            ProSeedPageFactory.HomePage.CheckAuthorization();
        }
    }
}
