Feature: Registration
	To be able to use all the benefits of a website, a user will have to sign up



@mytag
Scenario: Valid Registration
	Given I navigate to the website "https://angularjs.realworld.io/#/"
	And I click on sign up 
	And I enter my username "amoke"
	And I enter my email address "shasha11"
	And i enter my password "baby"
	When I click on the sign up button
	Then I should be able to sign up successfully