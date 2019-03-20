Feature: Login
	As a giftrete web user
	I would like to login
	So i can use the website

Background: 
	Given I navigate to giftrete website
	And I click on the login button

Scenario: Valid Login
	And I enter a Valid Username
	And I enter a Valid Password
	When I click on the SignIn button
	Then I am logged in successfully


Scenario:  Invalid Login 1 - valid username and invalid password
 And I enter a Valid Username
 And I enter an InValid password
 When I click on the SignIn button
 And I wait for Element
 # Then I am not logged in with login button still available
 Then I am not logged in

 Scenario: Invalid Login 2 - invalid username and valid password
 And I enter an InValid Username
 And I enter a Valid Password
 When I click on the SignIn button
 Then I am not logged in with login button still available







