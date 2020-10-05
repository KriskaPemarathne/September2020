using NUnit.Framework;
using September2020.Helpers;
using September2020.Pages;

namespace September2020.Test
{
    [TestFixture]   
    [Parallelizable]
    public class CompanyTests : CommonDriver
    {

        [Test]
        public void NavigateToHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToCompany(driver);
        }
        [Test]
        public void CreateNewCompanyTest()
        {
            CompanyPage companyPage = new CompanyPage();
            companyPage.CreateCompany(driver);
        }
        [Test]
        public void EditCompanyTest()
        {
            CompanyPage companyPage = new CompanyPage();
            companyPage.EditCompany(driver);
        }
        [Test]
        public void DeleteCompanyTest()
        {
            CompanyPage companyPage = new CompanyPage();
            companyPage.DeleteCompany(driver);
        }


    }
}
