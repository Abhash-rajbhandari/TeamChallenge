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

        private IWebElement DocumentationButton => driver.FindElement(By.XPath("//li[@id='menu-item-642']"));
        
        public HomePage()
        {
            this.driver = BrowserDriver.BrowserDriver.GetWebDriver();
            //PageFactory.InitElements(driver, this);
        }


        public void ClickDocumentationPage(){
            DocumentationButton.Click();
        }
    }
}
