Feature: AddMember
	As an Admin user of cams
	I want to add member
	So that i can add them to the application

@mytag
Scenario: Valid AddMember
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button 
	And i click on members records button
	And i click on add member button
	And i enter lastname "Jones"
	And i enter firstname "Ronke"
	And i click on gender dropdown arrow
	#And i select gender 
	And i click on marital status dropdown
	#And i select marital status
	And i enter member email "ronke@gmail.com"
	And i enter phone number "07559202561"
	And i enter home address "2 Basket street"
	And i enter Date of Birth "03/08/2000"
	And i click on choose file to add picture
	And i click on save
	Then Member added Successfully message is displayed
	
	




Scenario: Invalid AddMember
Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button 
	And i click on members records button
	And i click on add member button
	And i enter firstname "Ronke"
	And i click on gender dropdown arrow
	#And i select gender 
	And i click on marital status dropdown
	#And i select marital status
	And i enter member email "ronke@gmail.com"
	And i enter phone number "07559202561"
	And i enter home address "2 Basket street"
	And i enter Date of Birth "03/08/2000"
	And i click on choose file to add picture
	And i click on save
	Then Error message "This field is required" is displayed
	
