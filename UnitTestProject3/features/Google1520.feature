Feature: Google1520Feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the multiply of two numbers

@mytag
Scenario: Multiply two numbers
	Given I entered www.google.com as base url
	And I entered 15*20 into the search line 
	When I press on search button
	Then the result should be 300 on the screen

	