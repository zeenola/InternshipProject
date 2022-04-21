Feature: DeleteMember
	As an admin user on cams
	I want to delete member
	So that i can remove them from the application

@mytag
Scenario: DeleteMember
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button 
	And i click on members records button
	And i click on add member button
	And i enter lastname "Ajiboye"
	And i enter firstname "Bunmi"
	And i click on gender dropdown arrow
	And i click on marital status dropdown
	And i enter member email "ronke@gmail.com"
	And i enter phone number "07859202561"
	And i enter home address "74 pinner grove"
	And i enter Date of Birth "03/08/2000"
	And i click on choose file to add picture
	And i click on save
	Then Member added Successfully message is displayed
	When i click on ok
	And i click on the members records
	And i Enter Member firstname in the search box "Bunmi"
	And i click on delete icon 
	And i click on delete button
	#Then member successfully deleted message is displayed