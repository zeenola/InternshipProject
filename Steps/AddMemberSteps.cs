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
    public class AddMemberSteps
    {

        
        AddMemberPage _addMemberPage = new AddMemberPage();
       
        [When(@"i click on members records button")]
        public void WhenIClickOnMembersRecordsButton()
        {
            Thread.Sleep(3000);
            _addMemberPage.ClickMembersRecordsButton();
        }
        
        [When(@"i click on add member button")]
        public void WhenIClickOnAddMemberButton()
        {
            _addMemberPage.ClickAddMemberButton();
        }
        
       
        [When(@"i enter lastname ""(.*)""")]
        public void WhenIEnterLastname(string lastName)
        {
            _addMemberPage.EnterLastName(lastName);
        }
        
        [When(@"i enter firstname ""(.*)""")]
        public void WhenIEnterFirstname(string firstName)
        {
            _addMemberPage.EnterFirstName(firstName);
        }
        
        [When(@"i click on gender dropdown arrow")]
        public void WhenIClickOnGenderDropdownArrow()
        {
            _addMemberPage.ClickGenderDropDown();
          
        }

        [When(@"i click on marital status dropdown")]
        public void WhenIClickOnMaritalStatusDropdown()
        {
            _addMemberPage.ClickMaritalStatusDropDown();
        }

       

        [When(@"i enter member email ""(.*)""")]
        public void WhenIEnterMemberEmail(string memberEmail)
        {
            _addMemberPage.EnterMemberEmail(memberEmail);
        }

        [When(@"i enter phone number ""(.*)""")]
        public void WhenIEnterPhoneNumber(string phoneNumber)
        {
            _addMemberPage.EnterPhoneNumber(phoneNumber);
        }
        
        [When(@"i enter home address ""(.*)""")]
        public void WhenIEnterHomeAddress(string homeAddress)
        {
            _addMemberPage.EnterHomeAddress(homeAddress);
        }
        
        [When(@"i enter Date of Birth ""(.*)""")]
        public void WhenIEnterDateOfBirth(string dateOfBirth)
        {
            _addMemberPage.EnterDateOfBirth(dateOfBirth);
        }
        
        [When(@"i click on choose file to add picture")]
        public void WhenIClickOnChooseFileToAddPicture()
        {
            _addMemberPage.ClickChooseFile();
        }

        

        [When(@"i click on save")]
        public void WhenIClickOnSave()
        {
            _addMemberPage.ClickSaveButton();
        }

        [Then(@"Member added Successfully message is displayed")]
        public void ThenMemberAddedSuccessfullyMessageIsDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_addMemberPage.ThenMemberAddedSuccessfullyMessageIsDisplayed());
        }





        [Then(@"Error message ""(.*)"" is displayed")]
        public void ThenErrorMessageIsDisplayed( String Lastname)
        {
           Assert.IsTrue(_addMemberPage.ErrorMessageIsDisplayed());
        }



    }
}
;