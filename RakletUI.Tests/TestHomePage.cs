using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace RakletTests
{
    public class TestHomePage
    {

        private readonly string HomeUrl = "https://hello.raklet.net/";
        private readonly string HomeTitle = "Membership Management Software for Associations, " +
            "Clubs, Non-Profits, Chambers, Alumni";


        //[Fact]
        //public void Test1()
        //{
        //    using(IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(HomeUrl);
        //        IWebElement loginButton = driver.FindElement(By.XPath("//a[@href='https://login.raklet.net/?']"));
        //        loginButton.Click();
                
        //    }
        //}

        [Fact]
        public void LoadHomePage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                Assert.Equal(HomeUrl, driver.Url);
                Assert.Equal(HomeTitle, driver.Title);
            }
        }

        [Fact]
        public void ReloadHomePage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                driver.Navigate().Refresh();

                Assert.Equal(HomeUrl, driver.Url);
                Assert.Equal(HomeTitle, driver.Title);
            }
        }
    }
}