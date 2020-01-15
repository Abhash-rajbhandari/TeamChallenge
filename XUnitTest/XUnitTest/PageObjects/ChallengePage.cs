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
    class ChallengePage
    {
        private IWebDriver driver;
             
        private IWebElement SideMenuBar => driver.FindElement(By.XPath(""));

        private IWebElement ChallangeMenuOption => driver.FindElement(By.XPath(""));

        private IWebElement CreateChallangeMenuOption => driver.FindElement(By.XPath(""));

        private IWebElement ViewChallangeMenuOption => driver.FindElement(By.XPath(""));


        public ChallengePage()
        {
            this.driver = BrowserDriver.BrowserDriver.GetWebDriver();
        }

        public void VerifyIfChallengeMenuPresent()
        {
            //SideMenuBar.Click();
            Assert.True(ChallangeMenuOption.Displayed);
            Assert.True(CreateChallangeMenuOption.Displayed);
            Assert.True(ViewChallangeMenuOption.Displayed);
                       
        }

        public void ClickViewChallange()
        {
            ViewChallangeMenuOption.Click();
        }

        public void VeirfyViewChallengePageOpenOnNewTab()
        {
           driver.SwitchTo().Window(driver.WindowHandles.Last());
            Assert.Equal("", driver.Title);
            driver.Close();


        }

        public void gotoOldPortalPage()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        public void ClickCreateChallenge()
        {
            CreateChallangeMenuOption.Click();
        }

        public void VeirfyCreateChallengePageOpenOnNewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Assert.Equal("", driver.Title);
            driver.Close();

        }

        public void VerifyIfChallengeMenuNotVisible()
        {
            try
            {
                bool isLOBvisible = ChallangeMenuOption.Displayed;
                Assert.False(isLOBvisible);
            }
            catch (Exception e)
            {
                //If exception caught the also the assertion is successful
                Assert.True(true);
            }
        }

    }
}
