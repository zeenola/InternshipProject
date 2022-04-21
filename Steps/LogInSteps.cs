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
    public class LoginSteps
    {

        public IWebDriver driver = BaseTest.driver;
        LogInPage _logInPage = new LogInPage();

        [Given(@"user navigate to giftrete\.com/qacams/")]
        public void GivenUserNavigateToGiftrete_ComQacams()
        {
            driver.Navigate().GoToUrl(@"https://giftrete.com/qacams/");
        }
        
        [When(@"i enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            _logInPage.EnterEmail(email);
        }
        
        [When(@"i enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            _logInPage.EnterPassword(password);
        }
        
        [When(@"i click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            _logInPage.ClickSignInButton();
        }
        
        [Then(@"the application page is displayed")]
        public void ThenTheApplicationPageIsDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_logInPage.ThenApplicationPageIsDisplayed());
        }


        [Then(@"""(.*)"" is displayed")]
        public void ThenIsDisplayed(string Email)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_logInPage.WrongEmailErrorMessageIsDisplayed());
        }

        [Then(@"message ""(.*)""is displayed")]
        public void ThenMessageIsDisplayed(string password)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(_logInPage.WrongPasswordMessageIsDisplayed());
        }


    }
}
