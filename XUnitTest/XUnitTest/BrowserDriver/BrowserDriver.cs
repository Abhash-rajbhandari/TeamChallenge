using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TeamChallenge.BrowserDriver
{
    class BrowserDriver
    {
        public static IWebDriver webDriver;

        private static string browser = "Chrome";


        public static IWebDriver LaunchBrowser()
        {
            if (browser.Equals("Chrome"))
            {
                string _chromeDriverPath = @"C:\Users\rajbh\source\repos\XUnitTest\XUnitTest\Resources";
                webDriver = new ChromeDriver(_chromeDriverPath);
                return webDriver;
            }
            //Default Browser1
            else
            {
                string _chromeDriverPath = @"C:\Users\rajbh\source\repos\XUnitTest\XUnitTest\Resources\";
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
