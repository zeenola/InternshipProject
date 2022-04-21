using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class DeleteMemberPage
    {

        public IWebDriver driver;


        public DeleteMemberPage()
        {
            driver = BaseTest.driver;
        }

        private By Ok = By.CssSelector("button[class='swal2-confirm swal2-styled']");
        private By MembersRecords = By.XPath("//span[normalize-space()='Members Records']");
        private By FirstName = By.CssSelector("input[type= 'search']");
        private By DeleteIcon = By.CssSelector("a[title='delete this products']");
        private By DeleteButton = By.XPath("//button[normalize-space()='Yes']");


        public void ClickOkButton()
        {
            driver.FindElement(Ok).Click();
        }

        public void ClickMembersRecords()
        {
            driver.FindElement(MembersRecords).Click();
        }
        

        public void EnterFirstName(string firstname)
        {
            driver.FindElement(FirstName).SendKeys(firstname);
        }

        public void ClickDeleteIcon()
        {
            driver.FindElement(DeleteIcon).Click();
        }

        public void ClickDeleteButton()
        {
            driver.FindElement(DeleteButton).Click();
        }

































    }
}
