Feature: EditPayment
	As a user on cams
	I want to edit payment
	So that the account ledger can be updated

@mytag
Scenario: EditPayment
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
	And i click on payments button
	And i enter amount "40.00"
	And i enter description "painting"
	And i enter receipt Number "0507"
	And i Click on approval dropdown arrow
	And i enter approval "Jon Doh"
	And i enter Date "04/04/22"
	And i click on save button
	Then payment is successfully added
	When i enter transaction id "1210"
	And i click on the edit icon
	And i edit amount "30.00"
	And i click save button
	#Then the payment is successfully edited