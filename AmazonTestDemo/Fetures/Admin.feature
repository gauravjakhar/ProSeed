Feature: Admin

@AdminTest
Scenario: Add Trainee
	Given I login to ProSeed Application
	And I am on Admin Page
	When I click Add Member Button
	Then Create Trainee page should appear
	And I Enter all data needed and click Create
	Then It should navigate to Trainee Page with Trainee recently added appearing


	@AdminTest
Scenario: Delete Trainee
	Given I login to ProSeed Application
	And I am on Admin Page
	When I click Delete Trainee icon corresponding to a trainee
	Then corresponding Trainee should be removed

	@AdminTest
Scenario: Update Trainee
	Given I login to ProSeed Application
	And I am on Admin Page
	When I click Update Trainee icon corresponding to a trainee
	Then update Trainee page should appear
	And I Enter all data changes and click Update
	Then It should show an alert, click ok
	And Go to admin Page
	And verify updated trainee