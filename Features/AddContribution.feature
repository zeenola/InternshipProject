Feature: AddContribution
	As an admin user of cams 
	I want to add contribution
	So that the church account ledger can be updated

@mytag
Scenario: AddContribution
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
	And i click on contributions button
	And i click on member dropdown arrow
	And i enter Member name "Ajiboye Bunmi"
	And i enter Amount "50.00"
	And i click on category dropdown
	And i enter category "OFFERING"
	And i enter the date "04/03/2022"
	And i click on the save button 
	#Then contribution is added successfuly