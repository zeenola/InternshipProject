using Cams.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class AddPaymentSteps
    {

        AddPaymentPage _addPaymentPage = new AddPaymentPage();

        [When(@"i click on payments button")]
        public void WhenIClickOnPaymentsButton()
        {
            Thread.Sleep(3000);
            _addPaymentPage.ClickPaymentsButton();
        }

        [When(@"i enter amount ""(.*)""")]
        public void WhenIEnterAmount(string amount)
        {
            _addPaymentPage.EnterAmount(amount);
        }


        [When(@"i enter description ""(.*)""")]
        public void WhenIEnterDescription(string description)
        {
            _addPaymentPage.EnterDescription(description);
        }



        [When(@"i enter receipt Number ""(.*)""")]
        public void WhenIEnterReceiptNumber(string receipt)
        {
            _addPaymentPage.EnterReceipt(receipt);
        }


        [When(@"i Click on approval dropdown arrow")]
        public void WhenIClickOnApprovalDropdownArrow()
        {
            _addPaymentPage.ClickApprovalDropDown();
        }

        [When(@"i enter approval ""(.*)""")]
        public void WhenIEnterApproval(string JonDoh)
        {
            _addPaymentPage.EnterApproval(JonDoh);
        }


        [When(@"i enter Date ""(.*)""")]
        public void WhenIEnterDate(string date)
        {
            _addPaymentPage.EnterDate(date);
        }


        [When(@"i click on save button")]
        public void WhenIClickOnSaveButton()
        {
            _addPaymentPage.ClickSaveButton();
        }

        [Then(@"payment is successfully added")]
        public void ThenPaymentIsSuccessfullyAdded()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_addPaymentPage.SuccessfulMessageIsDisplayed());
        }

        [Then(@"Error message '(.*)' is displayed")]
        public void ThenErrorMessageIsDisplayed(string message)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_addPaymentPage.ErrorMessageIsDisplayed());
        }



    }
}
