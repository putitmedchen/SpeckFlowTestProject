Feature: GoogleSkypeFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the number of search results

@mytag
Scenario: Get numbers of search result
	Given I have entered www.google.com for search
	And I have entered skype in search line
	When I press search skype
	Then the result should be 6 counts 
