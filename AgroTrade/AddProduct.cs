using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using AgroTradeApp;

namespace AgroTrade
{
    [Binding]
    public class CreateProductSteps
    {
        Product prod = new Product();
        ProductBL prodBL = new ProductBL();

        [Given(@"farmer ""(.*)"" has entered product name as ""(.*)""")]
        public void GivenFarmerHasEnteredProductNameAs(string farmerName, string productName)
        {
            prod.FarmerName = farmerName;
            prod.ProductName = productName;
        }

        [Given(@"his email is ""(.*)"" and phone is ""(.*)""")]
        public void GivenHisEmailIsAndPhoneIs(string email, int phone)
        {
            prod.Email = email;
            prod.ContactNo = phone;
        }

        [Given(@"farmer enter name ""(.*)"" and contact number ""(.*)""")]
        public void GivenFarmerEnterNameAndContactNumber(string farmerName, int phone)
        {
            prod.FarmerName = farmerName;
            prod.ContactNo = phone;
        }

        [Given(@"user clicks on ""(.*)"" button")]
        public void GivenUserClicksOnButton(string createButton)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"fill all details")]
        public void GivenFillAllDetails()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"user clicks on ""(.*)"" button")]
        public void WhenUserClicksOnButton(string cancelButton)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"System display message ""(.*)"" with ""(.*)"" button")]
        public void ThenSystemDisplayMessageWithButton(string successMessage, string p1)
        {
            Assert.AreEqual(successMessage, prodBL.Validate(prod));
        }

        [Then(@"clicking on ""(.*)"" will take seller on ""(.*)"" page")]
        public void ThenClickingOnWillTakeSellerOnPage(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"System display error message ""(.*)"" with ""(.*)"" button")]
        public void ThenSystemDisplayErrorMessageWithButton(string errorMessage, string p1)
        {
            Assert.AreEqual(errorMessage, prodBL.Validate(prod));
        }

        [Then(@"clicking on ""(.*)"" will remain on the same page")]
        public void ThenClickingOnWillRemainOnTheSamePage(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the values in the fields will remain same")]
        public void ThenTheValuesInTheFieldsWillRemainSame()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"System redirects to ""(.*)"" page")]
        public void ThenSystemRedirectsToPage(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
