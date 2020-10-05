using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Helpers;
using September2020.Test;
using System;

namespace September2020
{
    public class Program
    {
       
        public static void Main(string[] args)
        {


            // Login page

            CompanyTests companyTests = new CompanyTests();
            companyTests.LoginToTurnUp();
            companyTests.NavigateToHomePage();
            companyTests.CreateNewCompanyTest();
            companyTests.EditCompanyTest();
            companyTests.DeleteCompanyTest();


            TmTests tmTests = new TmTests();
            tmTests.LoginToTurnUp();
            tmTests.NavigateToHomePage();
            tmTests.CreateNewTMTest();
            tmTests.EditTMTest();
            tmTests.DeleteTMTest();

           

        }

        
    }

}
