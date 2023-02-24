using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test case started.");
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("javatpoint tutorial");
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            searchButton.Click();
            driver.Close();
            driver.Quit();
            Console.Write("test case ended.");
        }
    }
}
