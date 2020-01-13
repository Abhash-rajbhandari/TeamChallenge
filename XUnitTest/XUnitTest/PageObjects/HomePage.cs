using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace TeamChallenge.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage()
        {
            this.driver = BrowserDriver.BrowserDriver.GetWebDriver();
            PageFactory.InitElements(driver, this);
        }
    }
}
