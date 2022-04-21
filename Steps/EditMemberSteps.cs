using Cams.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class EditMemberSteps
    {

        EditMemberPage _editMemberPage = new EditMemberPage();


        [When(@"i click on ok Button")]
        public void WhenIClickOnOkButton()
        {
            _editMemberPage.ClickOkButton();
        }


        [When(@"i click on members records")]
        public void WhenIClickOnMembersRecords()
        {
            Thread.Sleep(3000);
            _editMemberPage.ClickMembersRecords();
        }
        
        [When(@"i enter first name in the search box ""(.*)""")]
        public void WhenIEnterFirstNameInTheSearchBox(string firstname)
        {
            _editMemberPage.EnterFirstName(firstname);
        }
        
        [When(@"i click on edit icon")]
        public void WhenIClickOnEditIcon()
        {
            _editMemberPage.ClickEditIcon();
        }
        
        [When(@"i Edit the phone number ""(.*)""")]
        public void WhenIEditThePhoneNumber(string phonenumber)
        {
            _editMemberPage.EnterPhoneNumber(phonenumber);
        }
        
        [When(@"i cick on save button")]
        public void WhenICickOnSaveButton()
        {
            _editMemberPage.ClickSaveButton();
        }
        
        [Then(@"successfull message is displayed")]
        public void ThenSuccessfullMessageIsDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_editMemberPage.SuccessfullMessageDisplayed());
        }
    }
}
