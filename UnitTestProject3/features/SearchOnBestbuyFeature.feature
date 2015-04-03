Feature: SearchOnBestbuyFeature
	In order to avoid silly mistakes
	I want to be found 'Surface pro 3' with price 999.99

@mytag
Scenario: Finf Surface pro 3 with price 999.99
	Given I have opened page www.bestbuy.com/?intl=nosplash
	And I have typed Surface pro 3 into the search
	When I add to cart Surface pro 3 with price 999.99
	Then The product should be added  to Cart
