using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace September2020
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            // Login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            LoginToTurnUp(driver);
            NavigateToHomePage(driver);
            CreateNewTMTest(driver);
            EditTMTest(driver);
            DeleteTMTest(driver);


        }

        [SetUp]
        public static void LoginToTurnUp(IWebDriver driver)
        {
            Console.WriteLine("Hello World!");
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [Test]
        public static void NavigateToHomePage(IWebDriver driver)
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToTM(driver);
        }
        [Test]
        public static void CreateNewTMTest(IWebDriver driver)
        {
            TMPage tmPage = new TMPage();
            tmPage.CreateTM(driver);
        }
        [Test]
        public static void EditTMTest(IWebDriver driver)
        {
            TMPage tmPage = new TMPage();
            tmPage.EditTM(driver);
        }
        [Test]
        public static void DeleteTMTest(IWebDriver driver)
        {
            TMPage tmPage = new TMPage();
            tmPage.DeleteTM(driver);
        }
        [TearDown]
        public void TestClosure(IWebDriver driver)
        {
        }
    }

}
