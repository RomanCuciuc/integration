Feature: AuthenticationSteps
  In order to access the system
  As a user
  I want to authenticate via the API



@tag1
Scenario: User authentication with valid credentials
	Given I have a valid user credential
	When I send a POST request to 'https:'
	Then the response should be 200	

