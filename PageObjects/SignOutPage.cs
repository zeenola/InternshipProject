using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class SignOutPage
    {
        public IWebDriver driver;

        public SignOutPage()
        {
            driver = BaseTest.driver;
        }


       
       
        private By HiAdminButton = By.CssSelector(".kt-header__topbar-username.kt-hidden-mobile");
        private By SignOut = By.XPath("//*[@id='kt_header']/div[2]/div/div[2]/div[2]/div/a[1]");
        private By LandingPage = By.XPath("//*[@id='kt_login']");





          public void ClickHiAdminButton()
        {
            driver.FindElement(HiAdminButton).Click();
        }

        public void ClickSignOutButton()
        {
            driver.FindElement(SignOut).Click();
        }

        public bool ThenIAmTakenBackToTheLandingPage()
        {
            return driver.FindElement(LandingPage).Displayed;
        }















        












}



        }

