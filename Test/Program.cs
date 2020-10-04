using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace September2020
{
    public class Program
    {
       static IWebDriver driver;
        public static void Main(string[] args)
        {

             driver = new ChromeDriver();
            // Login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            LoginToTurnUp();
            NavigateToHomePage();
            CreateNewTMTest();
            EditTMTest();
            DeleteTMTest();


        }

        [SetUp]
        public static void LoginToTurnUp()
        {
            Console.WriteLine("Hello World!");
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [Test]
        public static void NavigateToHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToTM(driver);
        }
        [Test]
        public static void CreateNewTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.CreateTM(driver);
        }
        [Test]
        public static void EditTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.EditTM(driver);
        }
        [Test]
        public static void DeleteTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.DeleteTM(driver);
        }
        [TearDown]
        public void TestClosure()
        {
            driver.Quit();
        }
    }

}
