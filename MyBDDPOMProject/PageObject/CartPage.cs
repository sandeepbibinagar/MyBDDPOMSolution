using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBDDPOMProject.PageObject
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        By viewCartLink = By.XPath("//*[@id=\"primary-menu\"]/ul/li[1]/a");
        By productOneQuantity = By.XPath("/html/body/div/div/div[2]/div/main/article/div/div/form/table/tbody/tr[1]/td[5]/div/input");
        By productTwoQuantity = By.XPath("/html/body/div/div/div[2]/div/main/article/div/div/form/table/tbody/tr[2]/td[5]/div/input");
        By productThreeQuantity = By.XPath("/html/body/div/div/div[2]/div/main/article/div/div/form/table/tbody/tr[3]/td[5]/div/input");
        By productFourQuantity = By.XPath("/html/body/div/div/div[2]/div/main/article/div/div/form/table/tbody/tr[4]/td[5]/div/input");
        By productOnePrice = By.XPath("//*[@id=\'post-8\']/div/div/form/table/tbody/tr[1]/td[4]/span");
        By productTwoPrice = By.XPath("//*[@id=\'post-8\']/div/div/form/table/tbody/tr[2]/td[4]/span");
        By productThreePrice = By.XPath("//*[@id=\'post-8\']/div/div/form/table/tbody/tr[3]/td[4]/span");
        By productFourPrice = By.XPath("//*[@id=\'post-8\']/div/div/form/table/tbody/tr[4]/td[4]/span");
        By removeItemFromCart = By.XPath("//*[@id=\'post-8\']/div/div/form/table/tbody/tr[1]/td[1]/a");
        By removedMessage = By.XPath("/html/body/div/div/div[2]/div/main/article/div/div/div[1]/div/text()");

        public CartPage ViewCartPage()
        {
            driver.FindElement(viewCartLink).Click();
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductQuantityOne()
        {
            Int16.Parse(driver.FindElement(productOneQuantity).Text);
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductQuantityTwo()
        {
            Int16.Parse(driver.FindElement(productTwoQuantity).Text);
            Thread.Sleep(2000);
            return this;
        }


        public CartPage checkProductQuantityThree()
        {
            Int16.Parse(driver.FindElement(productThreeQuantity).Text);
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductQuantityFour()
        {
            Int16.Parse(driver.FindElement(productFourQuantity).Text);
            Thread.Sleep(2000);
            return this;
        }

        public int checkTotalProductQuantityInCart()
        {

            int result = Int16.Parse(driver.FindElement(productOneQuantity).GetAttribute("value")) + Int16.Parse(driver.FindElement(productTwoQuantity).GetAttribute("value")) + Int16.Parse(driver.FindElement(productThreeQuantity).GetAttribute("value")) + Int16.Parse(driver.FindElement(productFourQuantity).GetAttribute("value"));
            Console.WriteLine("Total list of Items in Cart: " + result);
            Thread.Sleep(5000);
            return result;
        }

        public int checkTotalProductQuantityInCartAfterItemRemoval()
        {
            int result = Int16.Parse(driver.FindElement(productTwoQuantity).GetAttribute("value")) + Int16.Parse(driver.FindElement(productThreeQuantity).GetAttribute("value")) + Int16.Parse(driver.FindElement(productOneQuantity).GetAttribute("value"));
            Console.WriteLine("Total list of Items in Cart After one Item Removal: " + result);
            Assert.IsTrue(result == 3);
            Thread.Sleep(2000);
            return result;
        }


        public CartPage checkProductPriceOne()
        {
            Int16.Parse(driver.FindElement(productOnePrice).Text);
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductPriceTwo()
        {
            Int16.Parse(driver.FindElement(productTwoPrice).Text);
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductPriceThree()
        {
            Int16.Parse(driver.FindElement(productThreePrice).Text);
            Thread.Sleep(2000);
            return this;
        }

        public CartPage checkProductPriceFour()
        {
            Int16.Parse(driver.FindElement(productFourPrice).Text);
            Thread.Sleep(2000);
            return this;
        }


        public int lowestPricedItemInCart()
        {
            string price1 = (driver.FindElement(productOnePrice).Text).Remove(0, 1);
            string priceOne = price1.Remove(2, 3);

            string price2 = (driver.FindElement(productTwoPrice).Text).Remove(0, 1);
            string priceTwo = price2.Remove(2, 3);

            string price3 = (driver.FindElement(productThreePrice).Text).Remove(0, 1);
            string priceThree = price3.Remove(2, 3);

            string price4 = (driver.FindElement(productFourPrice).Text).Remove(0, 1);
            string priceFour = price4.Remove(2, 3);

            int p1 = Int16.Parse(priceOne);
            int p2 = Int16.Parse(priceTwo);
            int p3 = Int16.Parse(priceThree);
            int p4 = Int16.Parse(priceFour);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine(p4);

            int[] num = { p1, p2, p3, p4 };
            return LowestNumber(num);

        }

        public int LowestNumber(int[] numbers)
        {
            int lowest = Int32.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < lowest)
                    lowest = numbers[i];
            }
            Console.WriteLine("Lowest priced item in cart is $ :" + lowest);
            return lowest;
        }

        public CartPage RemoveItemFromCart()
        {

            driver.FindElement(removeItemFromCart).Click();
            Console.Write("Item removed from the Cart");
            Thread.Sleep(5000);
            return this;

        }

    }
}
