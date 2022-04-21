using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class EditPaymentPage
    {

        public IWebDriver driver;

        public EditPaymentPage()
        {
            driver = BaseTest.driver;
        }

        private By TransactionId = By.CssSelector("input[class= 'form-control form-control-sm']");
        public void EnterTransactionId(string transactionId)
        {
            driver.FindElement(TransactionId).SendKeys(transactionId);
        }

        private By EditIcon = By.CssSelector("a[title='Edit details']");
        public void ClickEditIcon()
        {
            driver.FindElement(EditIcon).Click();
        }

        private By Amount = By.CssSelector("input[id='amount']");
        public void EnterAmount(string amount)
        {
            driver.FindElement(Amount).SendKeys(amount);
        }

        private By SaveButton = By.CssSelector("button[type='submit']");
        public void ClickSaveButton()
        {
            driver.FindElement(SaveButton).Click();
        }





    }
}
