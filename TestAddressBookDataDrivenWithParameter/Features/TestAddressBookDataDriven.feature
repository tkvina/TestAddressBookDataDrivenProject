Feature: TestAddressBookDataDriven
	In order to register and sign up on the site 
	after signing up to create a New address

@mytag
Scenario: TestAddressBookDataDriven valid Registration
	Given I Navigate to website "http://a.testaddressbook.com"
	#And I click on the Hamburger dropdown
	And I click on Sign in
	And I Enter Email "terez@gmail.com"
	And I Enter Password "brazil"
	When I click on SignUp button
	#Then I should be able to login successfully to register
