using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.DevTools.V111.Network;

namespace MyBDDPOMProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver driver;
        private IObjectContainer _container;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }


        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://cms.demo.katalon.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                Thread.Sleep(2000);
                driver.Quit();
            }
        }

        [AfterStep]
        public void AfterStep(ScenarioContext sc)
        {
            
        }
    }
}