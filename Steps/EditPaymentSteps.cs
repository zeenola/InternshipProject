using Cams.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class EditPaymentSteps
    {


        EditPaymentPage _editPaymentPage = new EditPaymentPage();


        [When(@"i enter transaction id ""(.*)""")]
        public void WhenIEnterTransactionId(string transactionId)
        {
            _editPaymentPage.EnterTransactionId(transactionId);
        }

        [When(@"i click on the edit icon")]
        public void WhenIClickOnTheEditIcon()
        {
            _editPaymentPage.ClickEditIcon();
        }
        
        [When(@"i edit amount ""(.*)""")]
        public void WhenIEditAmount(string amount)
        {
            _editPaymentPage.EnterAmount(amount);
        }
        
        [When(@"i click save button")]
        public void WhenIClickSaveButton()
        {
            _editPaymentPage.ClickSaveButton();
        }
        
        [Then(@"the payment is successfully edited")]
        public void ThenThePaymentIsSuccessfullyEdited()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
