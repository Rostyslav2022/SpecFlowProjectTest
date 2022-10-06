Feature: SearchFunction


@SearchMenu
Scenario:Check the search menu
	Given I open Asos   website
	And I create a "<с>"request
	When When I click search btn
	Then I get a search "<result>"

	Examples: 
	| request | result                      |
	| с       | NOTHING MATCHES YOUR SEARCH |
