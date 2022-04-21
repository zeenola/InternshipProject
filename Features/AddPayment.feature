Feature: AddPayment
	As an admin user on cams
	I want to Add payment
	So that the church account ledger will be updated

@mytag
Scenario: Valid AddPayment
	Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
	And i click on payments button
	And i enter amount "20.00"
	And i enter description "chairs"
	And i enter receipt Number "2211"
	And i Click on approval dropdown arrow
	And i enter approval "Jon Doh"
	And i enter Date "02/03/22"
	And i click on save button
	Then payment is successfully added



Scenario: Invalid AddPayment
    Given user navigate to giftrete.com/qacams/
	When i enter email "admin@cams.com"
	And i enter password "Test1234"
	And i click on sign in button
	And i click on payments button
	And i enter amount "20.00"
	And i enter receipt Number "2211"
	And i Click on approval dropdown arrow
	And i enter approval "Jon Doh"
	And i enter Date "02/03/22"
	And i click on save button
	Then  Error message 'This field is required' is displayed
	