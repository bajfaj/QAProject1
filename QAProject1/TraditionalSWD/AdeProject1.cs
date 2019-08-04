using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAProject1.TraditionalSWD
{
    [TestClass]
    public class AdeProject1
    {
        [TestMethod]
        public void UserNavigation()
        {
            IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://qar3ad.eu.fleet-dashboard.com");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.XPath("//*[@id='session_username']")).SendKeys("tester");

            Driver.FindElement(By.Id("session_password")).SendKeys("YVP&-gEh8N");

            Driver.FindElement(By.XPath("//*[@id='new_session']/fieldset/div[4]/div[1]/div/input")).Click();

            Driver.Quit();
        }
    }
}
