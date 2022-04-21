Feature: DeletePayment
	As a user of cams
	I want to delete payment
	So that incorrect payment entries can be removed and ledger updated

@mytag
Scenario: DeletePayment
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
	And i click on payments button 
	And i enter amount "10.00"
	And i enter description "Catering"
	And i enter receipt Number "1010"
	And i Click on approval dropdown arrow
	And i enter approval "Jon Doh"
	And i enter Date "04/04/22"
	And i click on save button
	And i enter transaction ID to search payment "1219"
	And i click on delete icon to delete the selected payment
	And i click on delete button to confirm deletion
	#Then payment successfully deleted message is displayed