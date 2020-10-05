using NUnit.Framework;
using September2020.Helpers;

namespace September2020.Test
{
    [TestFixture]
    [Parallelizable]
    public class TmTests : CommonDriver
    {

        [Test]
        public void NavigateToHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToTM(driver);
        }
        [Test]
        public void CreateNewTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.CreateTM(driver);
        }
        [Test]
        public void EditTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.EditTM(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            TMPage tmPage = new TMPage();
            tmPage.DeleteTM(driver);
        }

    }
}
