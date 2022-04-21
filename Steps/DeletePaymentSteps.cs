using Cams.Hooks;
using Cams.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class DeletePaymentSteps
    {

        
        DeletePaymentPage _deletePaymentPage = new DeletePaymentPage();


        

        [When(@"i enter transaction ID to search payment ""(.*)""")]
        public void WhenIEnterTransactionIDToSearchPayment(string transactionid)
        {
            _deletePaymentPage.EnterTransactionId(transactionid);
        }


        [When(@"i click on delete icon to delete the selected payment")]
        public void WhenIClickOnDeleteIconToDeleteTheSelectedPayment()
        {
            _deletePaymentPage.ClickDeleteIcon();
        }
        
        
        [When(@"i click on delete button to confirm deletion")]
        public void WhenIClickOnDeleteButtonToConfirmDeletion()
        {
            _deletePaymentPage.ClickDeleteButton();
        }
        
        [Then(@"payment successfully deleted message is displayed")]
        public void ThenPaymentSuccessfullyDeletedMessageIsDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_deletePaymentPage.ThenSuccessfullMessageIsDisplayed());
        }
    }
}
