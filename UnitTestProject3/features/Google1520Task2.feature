Feature: Google1520Task2Feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Multiply two numbers and add result to the search
	Given I have entered 15*20 into the www.google.com
	And I recieved result from multiplying 
	And I + result into search line
	When I press search
	Then the result must be 600 on the screen

