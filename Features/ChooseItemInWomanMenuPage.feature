Feature: ChooseItemInWomanMenuPage


@WomanMenuPage
Scenario: Check select function in Woman page
	Given I click Woman page button on the Main page 
	And I click Sale list
	When I select a item
	Then I get a "<itemTitleTextW>"  title item name

	Examples: 
	| itemTitleTextW  |
	| Sale Dresses    |
