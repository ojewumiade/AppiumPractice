Feature: Login
	As a reister user of Giftrete
	I want to log in 
	so that I can use the Site

@mytag
Scenario:Login successfull
	Given I navigate to the site
	When I click on Login link
	And I enter my username
	And I enter my password
	And i click on login button
	Then I should be on the Giftrete site
