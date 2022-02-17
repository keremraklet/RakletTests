using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RakletTests.RakletUITests
{
    public class TestStartPage
    {

        [Fact]
        public void BeInitiatedFromHomePage_NavBar()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://hello.raklet.net/");

                IWebElement startButton = driver.FindElement
                    (By.XPath("//a[@href='https://login.raklet.net/quickregister']"));

                startButton.Click();

                Assert.Equal("https://login.raklet.net/quickregister", driver.Url);
                Assert.Equal("Raklet", driver.Title);

            }
        }

    }
}
