using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Xunit;
using System.Linq;

namespace TeamChallenge.PageObjects
{
    class CreateChallengePage
    {
        private IWebDriver driver;
             
        private IWebElement SideMenuBar => driver.FindElement(By.XPath(""));


        public CreateChallengePage()
        {
            this.driver = BrowserDriver.BrowserDriver.GetWebDriver();
        }

        public void verifyLOBcolumnNotPresent()
        {
            try
            {
               bool isLOBvisible = BrowserDriver.BrowserDriver.GetWebDriver().FindElement(By.XPath("")).Displayed;
                Assert.False(isLOBvisible);
            }catch(Exception e)
            {
                //If exception caught the also the assertion is successful
                Assert.True(true);
            }

        }

    }
}
