Feature: EditMember
	As an admin user
	I want to edit member
	So that i can update member details

@mytag
Scenario: EditMember
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
	When i click on ok Button
	And i click on members records 
	And i enter first name in the search box "Ronke"
	And i click on edit icon
	And i Edit the phone number "07859202561"
	And i cick on save button
	#Then successfull message is displayed