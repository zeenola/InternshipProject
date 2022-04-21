Feature: SignOut
	As an admin user of cams
	I want to sign out 
	So that i can log out of the application 

@mytag
Scenario: SignOut
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
    Then the application page is displayed
	When i click on hi, admin'
	And i click on Sign out button
	Then i am taken back to the login page
	
	
	
	
    
	
	