using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using AgroTradeApp;

namespace AgroTrade
{
    [Binding]
    public class TestingCreateProductSteps
    {
        Product prod = new Product();
        ProductBL prodBL = new ProductBL();

        [Given(@"farmer ""(.*)"" has entered product ""(.*)""")]
        public void GivenFarmerHasEnteredProduct(string farmerName, string productName)
        {
            prod.FarmerName = farmerName;
            prod.ProductName = productName;
        }

        [Given(@"his email is ""(.*)"" and phone ""(.*)""")]
        public void GivenHisEmailIsAndPhone(string email, int phone)
        {
            prod.Email = email;
            prod.ContactNo = phone;
        }

        [When(@"click on button ""(.*)""")]
        public void WhenClickOnButton(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"System display message ""(.*)"" with button ""(.*)""")]
        public void ThenSystemDisplayMessageWithButton(string successMessage, string p1)
        {
            Assert.AreEqual(successMessage, prodBL.Validate(prod));
        }

        [Then(@"clicking on button ""(.*)"" will take seller on page (.*)")]
        public void ThenClickingOnButtonWillTakeSellerOnPage(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"farmer ""(.*)"" has the entered product ""(.*)""")]
        public void GivenFarmerHasTheEnteredProduct(string farmerName, string productName)
        {
            prod.FarmerName = farmerName;
            prod.ProductName = productName;
        }

        [Given(@"his email is ""(.*)"" and with phone ""(.*)""")]
        public void GivenHisEmailIsAndWithPhone(string email, int phone)
        {
            prod.Email = email;
            prod.ContactNo = phone;
        }

        [When(@"farmer click on button ""(.*)""")]
        public void WhenFarmerClickOnButton(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"System display the message ""(.*)"" with button ""(.*)""")]
        public void ThenSystemDisplayTheMessageWithButton(string successMessage, string p1)
        {
            Assert.AreEqual(successMessage, prodBL.Validate(prod));
        }

        [Then(@"clicking on the button ""(.*)"" will take seller on page (.*)")]
        public void ThenClickingOnTheButtonWillTakeSellerOnPage(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
