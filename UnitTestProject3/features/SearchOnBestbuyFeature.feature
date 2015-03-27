Feature: SearchOnBestbuyFeature
	In order to avoid silly mistakes
	I want to be found 'Surface pro 3' with price 999.99

@mytag
Scenario: Finf Surface pro 3 with price 999.99
	Given I have entered surface pro 3 into the search 
	And I choose from list surface pro 3 with price 999.99
	When I press on add to Cart button
	Then The product should be added  to Cart
