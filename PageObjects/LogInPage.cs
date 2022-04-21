using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class LogInPage
    {
        public IWebDriver driver;


        public LogInPage()
        {
            driver = BaseTest.driver;
        }

        private By Email = By.XPath("//*[@id='email']");
        private By Password = By.XPath("//*[@id='password']");
        private By SignIn = By.XPath("//*[@id='kt_login_signin_submit']");
        private By ApplicationPage = By.CssSelector(".kt-header__topbar-username.kt-hidden-mobile");
        private By WrongEmail = By.CssSelector("div[class*='kt-alert']");
        private By WrongPassword = By.CssSelector("div[role='alert']");
        public void EnterEmail(string email)
        {
            driver.FindElement(Email).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(Password).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            driver.FindElement(SignIn).Click();
        }

        public bool ThenApplicationPageIsDisplayed()
        {
            return driver.FindElement(ApplicationPage).Displayed;

        }

        public bool WrongEmailErrorMessageIsDisplayed()
        {
            return driver.FindElement(WrongEmail).Displayed;
        }

        public bool WrongPasswordMessageIsDisplayed()
        {
            return driver.FindElement(WrongPassword).Displayed;
        }







    }

}
