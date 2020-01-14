using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TeamChallenge.Hooks
{
    [Binding]    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [Before]
        public void BeforeScenario()
        {
            Console.WriteLine("Hooks Before Class");
            IWebDriver wd = BrowserDriver.BrowserDriver.LaunchBrowser();
            wd.Navigate().GoToUrl("http://go.specflow.org/doc-hooks");
            
            


        }

        [After]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            BrowserDriver.BrowserDriver.GetWebDriver().Close();
            BrowserDriver.BrowserDriver.GetWebDriver().Quit();
        }
    }
}
