Feature: Google1520Task2Feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Multiply two numbers add result to the search
	Given I have entered 15*20 into the calculator
	And I have result for multiplying 15*20
	And I add result into search line
	When I press search
	Then the result should be 600 on the screen

