using Cams.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cams.PageObjects
{
    class AddContributionPage
    {


        public IWebDriver driver;

        public  AddContributionPage()
        {
            driver = BaseTest.driver;
        }

        private By Contributions = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[4]/a[1]/span[2]");
        public void ClickContributions()
        {
            driver.FindElement(Contributions).Click();
        }

        private By MemberDropDown = By.CssSelector("span[id = 'select2-member_id-container']");
        public void ClickMemberDropDown()
        {
            driver.FindElement(MemberDropDown).Click();
        }

        private By Member = By.CssSelector("input[class='select2-search__field']");
        public void EnterMember(string member)
        {
            driver.FindElement(Member).SendKeys(member);
        }

        private By Amount = By.CssSelector("input[name='amount']");
        public void EnterAmount(string amount)
        {
            driver.FindElement(Amount).SendKeys(amount);
        }

        private By CategoryDropDown = By.CssSelector("span[class='select2-selection__arrow']");
        public void ClickCategoryDropDown()
        {
            driver.FindElement(CategoryDropDown).Click();
        }

        private By Category = By.CssSelector("span[id='select2-contype_id-container']");
        public void EnterCategory(string OFFERING)
        {
            driver.FindElement(Category).SendKeys(OFFERING);
        }

        private By Date = By.CssSelector("input[id='date_selected']");
        public void EnterDate(string date)
        {
            driver.FindElement(Date).SendKeys(date);
        }

        private By Save = By.CssSelector("button[id='btn_save_user_update']");
        public void ClickSave()
        {
            driver.FindElement(Save).Click();
        }





    }
}
