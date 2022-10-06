Feature: ChooseItemInMenMenuPage



@MenMenuPage
Scenario: Check select function in Man page
	Given I click Man page buttonon on the Main page 
	And I click  Sale list
	When I select an item
	Then I get a "<itemTitleTextM>" title item name

	Examples: 
	| itemTitleTextM     |
	| Men's Sale: Shirts |
	