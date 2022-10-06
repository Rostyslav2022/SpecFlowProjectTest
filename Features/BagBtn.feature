Feature: BagBtn


@BagBtn
    Scenario:Check the bag button work
	Given I open Asos website
	When  When I click on the bag button
	Then  I get a "<message>"


	Examples: 
	| message           |
	| Your bag is empty |
