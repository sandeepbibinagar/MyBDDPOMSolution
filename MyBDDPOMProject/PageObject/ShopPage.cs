using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace MyBDDPOMProject.PageObject
{
    public class ShopPage
    {

        private IWebDriver driver;

        public ShopPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By addtoCartLinkProduct1 = By.XPath("//*[@id='main']/div[2]/ul/li[1]/div/a[2]");
        By addtoCartLinkProduct2 = By.XPath("//*[@id='main']/div[2]/ul/li[2]/div/a[2]");
        By addtoCartLinkProduct3 = By.XPath("//*[@id='main']/div[2]/ul/li[3]/div/a[2]");
        By addtoCartLinkProduct4 = By.XPath("//*[@id='main']/div[2]/ul/li[4]/div/a[2]");


        public ShopPage addProductOne()
        {
            driver.FindElement(addtoCartLinkProduct1).Click();
            Thread.Sleep(2000);
            return this;
        }


        /*public ShopPage clickSamplePageLink()
        {
            driver.FindElement(By.XPath("//*[@id='primary-menu']/ul/li[4]/a")).Click();
            Thread.Sleep(2000);
            return this;
        }
*/

        public ShopPage addProductTwo()
        {
            driver.FindElement(addtoCartLinkProduct2).Click();
            Thread.Sleep(2000);
            return this;
        }

        public ShopPage addProductThree()
        {
            driver.FindElement(addtoCartLinkProduct3).Click();
            Thread.Sleep(2000);
            return this;
        }

        public ShopPage addProductFour()
        {
            driver.FindElement(addtoCartLinkProduct4).Click();
            Thread.Sleep(2000);
            return this;
        }

    }
}

