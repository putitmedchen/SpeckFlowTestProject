Feature: ApplyToJobFromMultipleUsersFeature
	In order to avoid repeated work
	I want to send apply to job once time from 15 users

@mytag
Scenario: Apply to job from 15 users
	Given I have ciklum home page jobs.ciklum.com/search-and-apply/
	And I have found vacancy Automated QAs for e-Boks
	When I have entered name, lastname, phone, email for each of users
	    |Name    | LastName  | Email                   | Phone |
		| Andrey | Birmingam | agb@mailinator.com      | 37552 |
		| Devid  | Boui      | db@mailinator.com       | 99635 |
		| Ann    | Mild      | annm@mailinator.com     | 78453 |
		| Grace  | Crued     | grace@malinator.com     | 77777 |
		| Alan   | Mundy     | Mundy@malinator.com     | 77777 |
		| Naomi  | Burgland  | Burgland@malinator.com  | 77777 |
		| Rachel | Sheader   | Sheader@malinator.com   | 77777 |
		| Sarah  | Wiltshire | Wiltshire@malinator.com | 77777 |
		| Cris   | Hinde     | Hinde@malinator.com     | 77777 |
		| Adelle | Saville   | Saville@malinator.com   | 77777 |
		| Albert | Hamill    | Hamill@malinator.com    | 77777 |
		| Pablo  | Dover     | Dover@malinator.com     | 77777 |
		| Nikola | Sneddon   | Sneddon@malinator.com   | 77777 |
		| Nikita | Till      | Till@malinator.com      | 77777 |
		| Jasper | Wilton    | Wilton@malinator.com    | 77777 |
	Then I applied for job from 15 users
