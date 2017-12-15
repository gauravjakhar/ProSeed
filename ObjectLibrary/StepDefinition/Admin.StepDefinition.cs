using TechTalk.SpecFlow;

namespace ObjectLibrary.StepDefinition
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

        [When(@"I click Update Trainee icon corresponding to a trainee")]
        public void WhenIClickUpdateTraineeIconCorrespondingToATrainee()
        {
            ProSeedPageFactory.AdminPage.ClickUpdate();
        }

        [Then(@"update Trainee page should appear")]
        public void ThenUpdateTraineePageShouldAppear()
        {
            ProSeedPageFactory.HomePage.CheckTabName("Edit Inductee");
        }

        [Then(@"I Enter all data changes and click Update")]
        public void ThenIEnterAllDataChangesAndClickUpdate()
        {
            ProSeedPageFactory.AdminPage.EnterDataandRole();
        }

        [Then(@"It should show an alert, click ok")]
        public void ThenItShouldShowAnAlertClickOk()
        {
            ProSeedPageFactory.AdminPage.ClickAlertOK();
        }
    }
}
