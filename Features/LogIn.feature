Feature: Login
	As an admin user of cams
	I want to login to the website
	So that i can add member

@tag
Scenario: Valid Login 
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
    Then the application page is displayed


Scenario: Invalid Login (Wrong Password)
    Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1235"
	And i click on sign in button
    Then "Wrong Password, Please try again or click forget Password" is displayed


Scenario: Invalid Login (Wrong Email)
    Given user navigate to giftrete.com/qacams/
	When i enter email "books@gmail.com"
	And i enter password "Test1234"
	And i click on sign in button
    Then message "Email (Books@gmail.com) is not registered with BuyNowPayLater.com.ng"is displayed