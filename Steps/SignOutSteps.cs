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
    public class SignOutSteps
    {
        public IWebDriver driver = BaseTest.driver;
        SignOutPage _signOutPage = new SignOutPage();

      
        

        [When(@"i click on hi, admin'")]
        public void WhenIClickOnHiAdmin()
        {
            _signOutPage.ClickHiAdminButton();
        }

        [When(@"i click on Sign out button")]
        public void WhenIClickOnSignOutButton()
        {
            _signOutPage.ClickSignOutButton();
        }

        [Then(@"i am taken back to the login page")]
        public void ThenIAmTakenBackToTheLoginPage()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_signOutPage.ThenIAmTakenBackToTheLandingPage());
        }
    }
}
