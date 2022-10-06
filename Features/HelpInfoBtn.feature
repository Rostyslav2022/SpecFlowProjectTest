Feature: HelpInfo

@HelpInfoBtn
Scenario: Check the HelpInfo button
	Given I open  Asos website
	When When I click on the HelpInfo btn
	Then I am redirected to "<Helpinfo>" menu

	Examples: 
	| Helpinfo           |
	| HELP & INFORMATION |