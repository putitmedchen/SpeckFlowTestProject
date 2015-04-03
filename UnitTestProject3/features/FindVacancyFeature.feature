Feature: FindVacancyFeature
	
	I want to find vacancy for which I applied

@mytag
Scenario: Validate error message in vacancy form
	Given I have entered jobs.ciklum.com/search-and-apply/ Ciklum jobs search page
	And I opened vacancy Automated QAs for e-Boks
	When I submitted my application
	Then the result should be Error message  on the form
		| Error type | Error message                             |
		| Name       | ERROR: “Name” is a required field.        |
		| LastName   | ERROR: “Last Name” is a required field.   |
		| Email      | ERROR: “Email” is a required field.       |  