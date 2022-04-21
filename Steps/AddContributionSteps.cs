using Cams.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Cams.Steps
{
    [Binding]
    public class AddContributionSteps
    {


        AddContributionPage _addContributionPage = new AddContributionPage();


        [When(@"i click on contributions button")]
        public void WhenIClickOnContributionsButton()
        {
            Thread.Sleep(3000);
            _addContributionPage.ClickContributions();
        }
        
        [When(@"i click on member dropdown arrow")]
        public void WhenIClickOnMemberDropdownArrow()
        {
            _addContributionPage.ClickCategoryDropDown();
        }
        
        [When(@"i enter Member name ""(.*)""")]
        public void WhenIEnterMemberName(string member)
        {
            _addContributionPage.EnterMember(member);
        }
        
        [When(@"i enter Amount ""(.*)""")]
        public void WhenIEnterAmount(string amount)
        {
            _addContributionPage.EnterAmount(amount);
        }

        [When(@"i click on category dropdown")]
        public void WhenIClickOnCategoryDropdown()
        {
            _addContributionPage.ClickCategoryDropDown();
        }


        [When(@"i enter category ""(.*)""")]
        public void WhenIEnterCategory(string OFFERING)
        {
            _addContributionPage.EnterCategory(OFFERING);
        }
        
        [When(@"i enter the date ""(.*)""")]
        public void WhenIEnterTheDate(string date)
        {
            _addContributionPage.EnterDate(date);
        }
        
        [When(@"i click on the save button")]
        public void WhenIClickOnTheSaveButton()
        {
            Thread.Sleep(3000);
            _addContributionPage.ClickSave();
        }
        
        [Then(@"contribution is added successfuly")]
        public void ThenContributionIsAddedSuccessfuly()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
