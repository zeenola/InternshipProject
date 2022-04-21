using Cams.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class DeleteMemberSteps
    {

        DeleteMemberPage _deleteMemberPage = new DeleteMemberPage();


        [When(@"i click on ok")]
        public void WhenIClickOnOk()
        {
            _deleteMemberPage.ClickOkButton();
        }
        
        [When(@"i click on the members records")]
        public void WhenIClickOnTheMembersRecords()
        {
            _deleteMemberPage.ClickMembersRecords();
        }
        
        [When(@"i Enter Member firstname in the search box ""(.*)""")]
        public void WhenIEnterMemberFirstnameInTheSearchBox(string firstname)
        {
            _deleteMemberPage.EnterFirstName(firstname);
        }
        
        [When(@"i click on delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            _deleteMemberPage.ClickDeleteIcon();
        }
        
        [When(@"i click on delete button")]
        public void WhenIClickOnDeleteButton()
        {
            Thread.Sleep(3000);
            _deleteMemberPage.ClickDeleteButton();
        }
    }
}
