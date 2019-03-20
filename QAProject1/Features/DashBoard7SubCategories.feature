Feature: DashBoard7SubCategories
	As a giftrete web user
    I want to have a dashboard when I click on the categories
	So that I can access my sub categories easily 

@mytag
Scenario: SubCategory Access
	Given I navigate to giftrete website
	And I click on the login button
	And I enter a Valid Username
	And I enter a Valid Password
	And I click on the SignIn button
	And I click on Categories button
	Then I can access my SubCategories

