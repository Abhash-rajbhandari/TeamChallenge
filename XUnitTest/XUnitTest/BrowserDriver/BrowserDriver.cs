using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;


namespace TeamChallenge.BrowserDriver
{
    class BrowserDriver
    {
        public static IWebDriver webDriver;

        private static string browser = "InternetExplorer";


        public static IWebDriver LaunchBrowser()
        {
            if (browser.Equals("Chrome"))
            {
                //Put the chromedriver location here
                string _chromeDriverPath = @"C:\Users\rajbh\Documents\TeamChallenge\TeamChallenge\XUnitTest\XUnitTest\Resources\";
                //string _chromeDriverPath = "";
                webDriver = new ChromeDriver(_chromeDriverPath);
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
                return webDriver;
            }
            else if (browser.Equals("InternetExplorer"))
            {
                string _IEDriverPath = @"C:\Users\rajbh\Documents\TeamChallenge\TeamChallenge\XUnitTest\XUnitTest\Resources\";
                webDriver = new InternetExplorerDriver(_IEDriverPath);
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
                return webDriver;
            }
            //Default Browser1
            else
            {
                string _chromeDriverPath = @"";
                webDriver = new ChromeDriver(_chromeDriverPath);
                return webDriver;
            }
        }

        public static IWebDriver GetWebDriver()
        {
            return webDriver;
        }

        public static void Open(String url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

    }
}
