using Gherkin.CucumberMessages.Types;
using LivingDoc.Dtos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBDDPOMProject.Common
{
    public class CommonUtils
    {

        public string takeScreenshot(IWebDriver driver, ScenarioContext sc)
        {
            string testresultpath= "C:/Users/LENOVO/source/repos/MyBDDPOMSolution/MyBDDPOMProject/TestResults/";
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            Screenshot scr = screenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testresultpath, sc.ScenarioInfo.Title + ".png");
            scr.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;




        }


    }
}
