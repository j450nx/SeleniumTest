using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SeleniumTest
{
    internal class Sample1
    {
        IWebDriver driver = new EdgeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement basicAuth = driver.FindElement(By.CssSelector("#content > ul > li:nth-child(3) > a"));
            basicAuth.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
