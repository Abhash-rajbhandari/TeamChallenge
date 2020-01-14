using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TeamChallenge.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;

        private IWebElement OpenLoginUIButton => driver.FindElement(By.XPath(""));

        private IWebElement EmailAddressBox => driver.FindElement(By.XPath(""));

        private IWebElement Password => driver.FindElement(By.XPath(""));

        private IWebElement LoginButton => driver.FindElement(By.XPath(""));



        public LoginPage()
        {
            this.driver = BrowserDriver.BrowserDriver.GetWebDriver();
        }

      
        public void logintoPortal(String Username, String  password){
            OpenLoginUIButton.Click();
            EmailAddressBox.SendKeys("");
            Password.SendKeys("");
            LoginButton.Click();

        }

        
    }
}
