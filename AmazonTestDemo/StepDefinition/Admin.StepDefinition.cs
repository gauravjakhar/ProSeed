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
        [When(@"I click Add Member Button")]
        public void WhenIClickAddMemberButton()
        {
            ProSeedPageFactory.AdminPage.AddMember();
        }

        [Then(@"Create Trainee page should appear")]
        public void ThenCreateTraineePageShouldAppear()
        {
            ProSeedPageFactory.AdminPage.VerifyCreateTrainee();
        }

        [Then(@"I Enter all data needed and click Create")]
        public void ThenIEnterAllDataNeededAndClickCreate()
        {
            ProSeedPageFactory.AdminPage.EnterDataandCreate();
        }

        [Then(@"It should navigate to Trainee Page with Trainee recently added appearing")]
        public void ThenItShouldNavigateToTraineePageWithTraineeRecentlyAddedAppearing()
        {
            ProSeedPageFactory.AdminPage.VerifyAddedTrainee();
        }

        [When(@"I click Delete Trainee icon corresponding to a trainee")]
        public void WhenIClickDeleteTraineeIconCorrespondingToATrainee()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"corresponding Trainee should be removed")]
        public void ThenCorrespondingTraineeShouldBeRemoved()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Update Trainee icon corresponding to a trainee")]
        public void WhenIClickUpdateTraineeIconCorrespondingToATrainee()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"update Trainee page should appear")]
        public void ThenUpdateTraineePageShouldAppear()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I Enter all data changes and click Update")]
        public void ThenIEnterAllDataChangesAndClickUpdate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should show an alert, click ok")]
        public void ThenItShouldShowAnAlertClickOk()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"verify updated trainee")]
        public void ThenVerifyUpdatedTrainee()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
