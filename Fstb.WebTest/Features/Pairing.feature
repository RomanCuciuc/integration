Feature: Pairing

A short summary of the feature

@tag1
Scenario: Get Device Status
	Given I have valid userId and devieId
	When I send GET request to 'https:'
	Then I'm getting response 1
