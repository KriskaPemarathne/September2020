using OpenQA.Selenium;
using System;

namespace September2020
{
    public class LoginPage
    {
        public  void LoginSteps(IWebDriver driver)
        {
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");
            IWebElement passWord = driver.FindElement(By.Id("Password"));
            passWord.SendKeys("123123");
            IWebElement btnLogin = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            btnLogin.Click();
            IWebElement lblHelloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Console.WriteLine(lblHelloHari.Text == "Hello hari!" ? "Login Successfully , Success" : "Login Unsuccessfully , Fail");

        }
    }
}
