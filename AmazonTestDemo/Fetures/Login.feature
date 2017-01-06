Feature: Login

@LoginFeature
Scenario: Login With Valid User Email Id
	Given I login to ProSeed Application
	Then The user should be logged in to the system