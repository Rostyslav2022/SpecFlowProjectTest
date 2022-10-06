Feature: CheckHomePageTitle


@HomePageTitle
Scenario: CheckHomePageTitle
	Given I open Asos home page
	When Home page is downloaded
	Then I get a "<title>" title

	Examples: 
	| title      |
	| ABOUT ASOS |
