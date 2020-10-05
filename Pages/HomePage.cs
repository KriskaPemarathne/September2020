using OpenQA.Selenium;
using System.Threading;

namespace September2020
{
    public class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // if login successfull
            IWebElement lblHeaderMenuAdministration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            lblHeaderMenuAdministration.Click();
            Thread.Sleep(1000);
            IWebElement lblSubMenuTimenMeterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            lblSubMenuTimenMeterial.Click();
            Thread.Sleep(3000);
        }
        public void NavigateToCompany(IWebDriver driver) {
            // if login successfull
            IWebElement lblHeaderMenuAdministration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            lblHeaderMenuAdministration.Click();
            Thread.Sleep(1000);
            IWebElement lblSubMenuTimenMeterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[6]/a"));
            lblSubMenuTimenMeterial.Click();
            Thread.Sleep(3000);
        }
    }
}
