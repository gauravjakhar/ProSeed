Feature: Report
	In order to test batch creation schenario, addedd below scenario.
	
@ReportPage
Scenario: Verify the report page displays the average rating
	Given I login to ProSeed Application
	And I click on Trainee tab
	And I click on Create Trainee button
	And I fill the form on Create Trainee page
	And I click on Create Trainee button
	Then The user should be able to add a new trainee on Trainee List page
