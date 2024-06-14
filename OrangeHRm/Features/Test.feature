Feature: Test HRM





	@mytag
Scenario: Login with invalid credential2
	Given user  login with invalid application
	When user enter invalid username and password
	Then login should be unsuccessfull