using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class EditMemberPage
    {

        public IWebDriver driver;
        public EditMemberPage()
        {
            driver = BaseTest.driver;
        }


       
        private By Ok = By.CssSelector("button[class='swal2-confirm swal2-styled']");
        public void ClickOkButton()
        {
            driver.FindElement(Ok).Click();
        }

        private By MembersRecordsButton = By.XPath("//span[normalize-space()='Members Records']");
        public void ClickMembersRecords()
        {
            driver.FindElement(MembersRecordsButton).Click();
        }

        private By Search = By.XPath("//input[@type='search']");
        public void EnterFirstName(string firstname)
        {
            driver.FindElement(Search).SendKeys(firstname);
        }

        private By EditIcon = By.CssSelector("a[title='edit this products']");
        public void ClickEditIcon()
        {
            driver.FindElement(EditIcon).Click();
        }

        private By PhoneNumber = By.XPath("//*[@id='phonenumber']");
        public void EnterPhoneNumber(string phonenumber)
        {
            driver.FindElement(PhoneNumber).SendKeys(phonenumber);
        }

        private By SaveButton = By.XPath("//*[@id='btn_save_general']");
        public void ClickSaveButton()
        {
            driver.FindElement(SaveButton).Click();
        }

        private By SuccessfullMessage = By.XPath("//div[@class='swal2-header']");
        public bool SuccessfullMessageDisplayed()
        {
            return driver.FindElement(SuccessfullMessage).Displayed;
        }































    }
}
