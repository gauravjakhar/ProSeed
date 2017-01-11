Feature: Login

@LoginFeature
Scenario: Login With Valid(Role) User Email Id
	Given I login to ProSeed Application
	#Then The user should be logged in to the system
	#And Validate the role


	@LoginFeature
Scenario: Login With Not Valid User Email Id
	Given I login to ProSeed Application
	Then The user should be logged in to the system
	And Get a message that you are not authorized