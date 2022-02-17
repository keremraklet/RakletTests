using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakletTests.RakletUITests.PageObjectModels
{
    public class HomePage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://hello.raklet.net/";
        private const string PageTitle = "Membership Management Software for Associations, " +
            "Clubs, Non-Profits, Chambers, Alumni";
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            EnsurePageLoaded();
        }

        public void EnsurePageLoaded()
        {
            bool pageLoaded = (Driver.Url == PageUrl) && (Driver.Title == PageTitle);

            if (!pageLoaded)
            {
                throw new Exception("Failed to Load Page. Driver Url: " + Driver.Url 
                    + "Driver Title: " + Driver.Title);
            }
        }
    }
}
