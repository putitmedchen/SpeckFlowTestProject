Feature: FindVacancyFeature
	
	I want to find vacancy for which I applied

@mytag
Scenario: Validate error message in vacancy form
	Given I have entered Ciklum jobs search page
	And I found vacancy for which I applied
	When I press Apply for
	Then the result should be Error message  on the form
