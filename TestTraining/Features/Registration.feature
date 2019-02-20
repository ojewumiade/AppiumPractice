Feature: Registration
	As a user of Giftrete
	I would like to register 
	so that I can use the site

@mytag
Scenario: Valid registration
	Given That i navigate to the site
	When i click on register link
	And I enter my firstname
	And I enter "test@giftrete.com"
	And I enter my mobile number
	And I enter my password
	And I confirm password
	And I click on sign up button
	Then I should be able to register


Scenario: Invalid registration
	Given That I navigate to the site
	When I click on register link
	And I enter my firstname
	And I enter "test@giftrete.com"
	And I enter my mobile number
	And I enter wrong password
	And I confirm password
	And I click on sign up button
	Then I should not be able to register