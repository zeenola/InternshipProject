using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class AddMemberPage
    {
        public IWebDriver driver;


        public AddMemberPage()
        {
            driver = BaseTest.driver;
        }


        private By MembersRecordsButton = By.CssSelector("span.kt-menu__link-text");
        private By AddMember = By.XPath("//*[@id='btn_add_new']");
        private By LastName = By.XPath("//*[@id='lastname']");
        private By FirstName = By.XPath("//*[@id='firstname']");
        private By GenderDropDown = By.CssSelector("span[id='select2-gender-container']");
        private By Gender = By.CssSelector("input[type='search']");
        private By MaritalStatusDropDown = By.CssSelector("span[id='select2-marital_status-container']");
        private By MaritalStatus = By.CssSelector("input[type= 'search']");
        private By MemberEmail = By.XPath("//*[@id='emailaddress']");
        private By PhoneNumber = By.XPath("//*[@id='phonenumber']");
        private By HomeAddress = By.XPath("//*[@id='address']");
        private By DateOfBirth = By.XPath("//*[@id='dob']");
        private By ChooseFile = By.XPath("//*[@id='product_image']");
        private By SaveButton = By.XPath("//*[@id='btn_save_general']");
        private By SuccessfulMessage = By.XPath("/html/body/div[3]/div/div[1]/div[5]/div[2]");
        private By ErrorMessage = By.CssSelector("#lastname-error");
       


        public void ClickMembersRecordsButton()
        {
            driver.FindElement(MembersRecordsButton).Click();
        }

        public void ClickAddMemberButton()
        {
            driver.FindElement(AddMember).Click();
        }

        public void EnterLastName(string lastname)
        {
            driver.FindElement(LastName).SendKeys(lastname);
        }

        public void EnterFirstName(string firstname)
        {
            driver.FindElement(FirstName).SendKeys(firstname);
        }

        public void ClickGenderDropDown()
        {
            driver.FindElement(GenderDropDown).Click();
            driver.FindElement(Gender).SendKeys("female" + Keys.Enter);
        }
        

        public void ClickMaritalStatusDropDown()
        {
            driver.FindElement(MaritalStatusDropDown).Click();
            driver.FindElement(MaritalStatus).SendKeys("single" + Keys.Enter);
        }
        
        public void EnterMemberEmail(string memberemail)
        {
            driver.FindElement(MemberEmail).SendKeys(memberemail);
        }

        public void EnterPhoneNumber(string phonenumber)
        {
            driver.FindElement(PhoneNumber).SendKeys(phonenumber);
        }

        public void EnterHomeAddress(string homeaddress)
        {
            driver.FindElement(HomeAddress).SendKeys(homeaddress);
        }

        public void EnterDateOfBirth(string dateofbirth)
        {
            driver.FindElement(DateOfBirth).SendKeys(dateofbirth);
        }

        public void ClickChooseFile()
        {
            driver.FindElement(ChooseFile).SendKeys(@"C:\Users\zdanm\OneDrive\Desktop\rose.jpg");
        }
        

        public void ClickSaveButton()
        {
            driver.FindElement(SaveButton).Click();
        }

        public bool ThenMemberAddedSuccessfullyMessageIsDisplayed()
        {
           
            return driver.FindElement(SuccessfulMessage).Displayed;
        }

        public bool ErrorMessageIsDisplayed()
        {
            return driver.FindElement(ErrorMessage).Displayed;

        }

       






    }
}
