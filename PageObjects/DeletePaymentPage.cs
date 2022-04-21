using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class DeletePaymentPage
    {
        public IWebDriver driver;


        public DeletePaymentPage()
        {
            driver = BaseTest.driver;
        }

      
        private By TransactionId = By.CssSelector("input[class='form-control form-control-sm']");

        public void EnterTransactionId(string transactionid)
        {
            driver.FindElement(TransactionId).SendKeys(transactionid);
        }

        private By DeleteIcon = By.CssSelector("a[class='btn btn-sm btn-clean btn-icon btn-icon-md deletebut']");

        public void ClickDeleteIcon()
        {
            driver.FindElement(DeleteIcon).Click();
        }


        private By DeleteButton = By.CssSelector("button[class='swal2-confirm btn btn-danger']");

        public void ClickDeleteButton()
        {
            driver.FindElement(DeleteButton).Click();
        }

        private By SuccessfullMessage = By.XPath("//div[@class='dataTables_scrollBody']");

        public bool ThenSuccessfullMessageIsDisplayed()
        {
            return driver.FindElement(SuccessfullMessage).Displayed;
        }

        
          
         





























    }
}
