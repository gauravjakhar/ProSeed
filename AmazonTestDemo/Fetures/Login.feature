Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@LoginFeature
Scenario: Login With Valid User Email Id
	Given I login to ProSeed Application
	Then The user should be logged in to the system

@LoginFeature
Scenario: Login With InValid User Email Id
	Given I open ProSeed SignIn Page
	And I enter invalid username and password
	And I click on Sign in button
	Then I check tool tip appearing as Invalid Email ID / Password

@LoginFeature
Scenario: Login With Email Id of Wrong format
	Given I open ProSeed SignIn Page
	And I enter username of wrong format and password
	And I click on Sign in button
	Then I check tool tip appearing as Invalid Email Id
