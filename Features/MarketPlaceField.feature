Feature: MarketPlaceField



@MarketPlace
Scenario: Check redirect to MarketPlace page
	Given I open Asos  website
	When When I click on the MarketPlace btn
	Then I am redirected to "<MarketPlace>" page

	Examples: 
	| MarketPlace          |
	| DISCOVER MARKETPLACE |
