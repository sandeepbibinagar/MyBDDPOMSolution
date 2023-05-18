using MyBDDPOMProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MyBDDPOMProject.StepDefinitions
{
    [Binding]
    public class CartStepDefinitions
    {
        private IWebDriver driver;
        private CartPage _cartPage;
        private ShopPage _shopPage;
      
        public CartStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I add four random items to my cart")]
        public void GivenIAddFourRandomItemsToMyCart()
        {
            _shopPage = new ShopPage(driver);
            _shopPage.addProductOne();
            _shopPage.addProductTwo();
            _shopPage.addProductThree();
            _shopPage.addProductFour();
                        
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            _cartPage = new CartPage(driver);
            _cartPage.ViewCartPage();
        }

        [Then(@"I find total four items listed in my cart")]
        public void ThenIFindTotalFourItemsListedInMyCart()
        {
            _cartPage = new CartPage(driver);
            _cartPage.checkTotalProductQuantityInCart();
        }

        [When(@"I search for lowest price item")]
        public void WhenISearchForLowestPriceItem()
        {
            _cartPage = new CartPage(driver);
            _cartPage.lowestPricedItemInCart();
        }

        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
            _cartPage = new CartPage(driver);
            _cartPage.RemoveItemFromCart();
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
            _cartPage = new CartPage(driver);
            _cartPage.checkTotalProductQuantityInCartAfterItemRemoval();
        }
    }
}
