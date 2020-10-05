using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace September2020.Pages
{
    public class CompanyPage
    {
        public void CreateCompany(IWebDriver driver)
        {

            IWebElement btnCreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            btnCreateNew.Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Id("Name")).SendKeys("Kris Company");
            driver.FindElement(By.Id("EditContactButton")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='k-content-frame']")));
            driver.FindElement(By.Id("FirstName")).SendKeys("Kris");
            driver.FindElement(By.Id("LastName")).SendKeys("Fernandez");
            driver.FindElement(By.Id("Phone")).SendKeys("0224026596");
            driver.FindElement(By.Id("submitButton")).Click();
            Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.Id("container")));


            
            ////var checkboxSameContact = driver.FindElement(By.XPath("//*[@id='IsSameContact']"));
            ////if (!checkboxSameContact.Selected)
            ////{
            ////    checkboxSameContact.Click();
            ////}        
            driver.FindElement(By.Id("Name"));
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[4]/a[4]")).Click();

            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris Company" ? "Company  created Successfully , Success" : "Creating Company Unsuccess , Fail");

        }
        public void EditCompany(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            Thread.Sleep(3000);

            IWebElement companyName = driver.FindElement(By.Id("Name"));
            companyName.Clear();
            companyName.SendKeys("Kris Company1Edit");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[4]/a[4]")).Click();

            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris Company1Edit" ? "Company  edited Successfully , Success" : "Editing Company Unsuccess , Fail");

        }
        public void DeleteCompany(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]")).Click();
            Thread.Sleep(3000);
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            alert.Accept();
            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='companiesGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris Company1Edit" ? "Deleted Unsuccessfully , Fail" : "Deleted Company Success , Success");

        }
    }
}
