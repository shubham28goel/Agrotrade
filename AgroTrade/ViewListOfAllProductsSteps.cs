using System;
using TechTalk.SpecFlow;

namespace AgroTrade
{
    [Binding]
    public class ViewListOfAllProductsSteps
    {
        [Given(@"clicks on ""(.*)"" button\.")]
        public void GivenClicksOnButton_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks on ""(.*)"" button\.")]
        public void WhenUserClicksOnButton_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" page should be visible with the list of all products\.")]
        public void ThenPageShouldBeVisibleWithTheListOfAllProducts_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it redirects to ""(.*)"" page\.")]
        public void ThenItRedirectsToPage_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
