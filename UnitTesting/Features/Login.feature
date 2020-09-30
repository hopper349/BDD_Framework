Feature: Login
	Check if the login functionality is working as expected with 
	diffrent permutation and combination of data

Background:
 #Given I delete 

@Smoke @Positive
Scenario: Check login with correct credentails
	Given I have navigate to the application 
	And I see application opened
	Then I click on login link
	When I entered Username and Password 
	 | Username | Password |
	 |yash.tekgrid@gmail.com |Abcd123#  |
	Then I click login button
	