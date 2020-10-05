using OpenQA.Selenium;
using System;
using System.Threading;

namespace September2020
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]")).Click();
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            IWebElement btnCreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            btnCreateNew.Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            IWebElement typeCode = driver.FindElement(By.Id("Code"));
            typeCode.SendKeys("Kris_type8");
            IWebElement typeDescription = driver.FindElement(By.Id("Description"));
            typeDescription.SendKeys("Kris_type_Description8");
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span")).Click();
            IWebElement priceVal = driver.FindElement(By.Id("Price"));
            priceVal.SendKeys("100");
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris_type7" ? "Time record  created Successfully , Success" : "Creating time record Unsuccess , Fail");

        }
        public void EditTM(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]")).Click();
            IWebElement typeCode = driver.FindElement(By.Id("Code"));
            typeCode.Clear();
            typeCode.SendKeys("Kris_type7_Edit");
            IWebElement typeDescription = driver.FindElement(By.Id("Description"));
            typeDescription.Clear();
            typeDescription.SendKeys("Kris_type_Description7_Edit");
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span")).Click();
            IWebElement priceVal = driver.FindElement(By.Id("Price"));
            //priceVal.Clear();
            priceVal.SendKeys("1001");
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(3000);
            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris_type7_Edit" ? "Time record  edited Successfully , Success" : "Edit time record Unsuccess , Fail");
            Thread.Sleep(1000);
        }
        public void DeleteTM(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            alert.Accept();

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(3000);
            IWebElement expectedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(expectedCode.Text == "Kris_type7_Edit" ? "Delete Unsuccess , Fail" : "Delete Success , Success");
            Thread.Sleep(1000);


        }
    }
}
