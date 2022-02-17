using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RakletTests.RakletUITests.PageObjectModels;
using System;
using Xunit;

namespace RakletTests
{
    public class TestHomePage
    {
        [Fact]
        public void LoadHomePage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {

                var homePage = new HomePage(driver);
                homePage.NavigateTo();

            }
        }

        [Fact]
        public void ReloadHomePage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                var homePage = new HomePage(driver);
                homePage.NavigateTo();

                driver.Navigate().Refresh();

                homePage.EnsurePageLoaded();
            }
        }
    }
}