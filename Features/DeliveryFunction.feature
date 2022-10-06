Feature: DeliveryFunction



@DeliveryFunction
Scenario: Check Delivery Function
	Given I open Asos site
	And I click on the delivery button
    When I select a country
	Then I click a "<newCountry>"  
	
	