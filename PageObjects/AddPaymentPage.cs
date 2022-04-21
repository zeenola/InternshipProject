using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class AddPaymentPage
    {

        public IWebDriver driver;


        public AddPaymentPage()
        {
            driver = BaseTest.driver;
        }


        private By PaymentsButton = By.XPath("//span[normalize-space()='Payments']");
        private By Amount = By.XPath("//input[@id='amount']");
        private By Description = By.CssSelector("input[id='description']");
        private By Receipt = By.CssSelector("input[id='receiptno']");
        private By ApprovalDropDown = By.CssSelector("span[id='select2-approval-container']");
        private By Approval = By.CssSelector("span[class= 'select2-selection select2-selection--single']");
        private By Date = By.CssSelector("input[id='date_selected']");
        private By Save = By.CssSelector("button[type= 'submit']");
        private By SuccessfulMessage = By.CssSelector("div[class= 'dataTables_length']");
        private By ErrorMessage = By.CssSelector("label[id= 'description-error']");


        public void ClickPaymentsButton()
        {
            driver.FindElement(PaymentsButton).Click();
        }

        public void EnterAmount(string amount)
        {
            driver.FindElement(Amount).SendKeys(amount);
        }

        public void EnterDescription(string description)
        {
            driver.FindElement(Description).SendKeys(description);
        }

        public void EnterReceipt(string receipt)
        {
            driver.FindElement(Receipt).SendKeys(receipt);
        }

        public void ClickApprovalDropDown()
        {
            driver.FindElement(ApprovalDropDown).Click();
        }

        public void EnterApproval( string JonDoh)
        {
            driver.FindElement(Approval).SendKeys(JonDoh);
        }

        public void EnterDate(string date)
        {
            driver.FindElement(Date).SendKeys(date);
        }

        public void ClickSaveButton()
        {
            driver.FindElement(Save).Click();
        }

        public bool SuccessfulMessageIsDisplayed()
        {
            return driver.FindElement(SuccessfulMessage).Displayed;
        }

        public bool ErrorMessageIsDisplayed()
        {
            return driver.FindElement(ErrorMessage).Displayed;
        }








    }
}
