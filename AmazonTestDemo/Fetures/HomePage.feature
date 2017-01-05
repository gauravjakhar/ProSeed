Feature: HomePageTabs


@HomePageFeature
Scenario: Validate the left side tabs
	Given I login to ProSeed Application
	Then The user should be able to see the tabs on the left side
