using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace September2020.Helpers
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        [SetUp]
        public void LoginToTurnUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Console.WriteLine("Test Started");
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }

        [TearDown]
        public void TestClosure()
        {
            driver.Quit();
        }
    }
}
