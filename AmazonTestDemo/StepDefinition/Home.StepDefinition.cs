using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    }
}
