using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace QAProject1.TraditionalSWD
{
    [TestClass]
    public class DashBoard9
    {
        [TestMethod]
        public void SubCategory7()
        {
            IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://qa1.giftrt.com/");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.LinkText("Login")).Click();

            Driver.FindElement(By.Id("user_email")).SendKeys("bajfaj2@gmail.com");

            Driver.FindElement(By.Id("user_password")).SendKeys("Jmicheal1");

            Driver.FindElement(By.Id("btn_signin")).Click();

            // Catergory menu not available

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(Driver.FindElement(By.LinkText("Overview")).Displayed, "Overview Dashboard is not displayed");

            Driver.Quit();
        }

        [TestMethod]
        public void BasicPersonalInformationDisplay8()
        {
            IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://qa1.giftrt.com/");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.LinkText("Login")).Click();

            Driver.FindElement(By.Id("user_email")).SendKeys("bajfaj2@gmail.com");

            Driver.FindElement(By.Id("user_password")).SendKeys("Jmicheal1");

            Driver.FindElement(By.Id("btn_signin")).Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.FindElement(By.LinkText("Account Details")).Click();

            Driver.FindElement(By.LinkText("Profile Details")).Click();

            Assert.IsTrue(Driver.FindElement(By.LinkText("My Account")).Displayed, "My Account Message Not Displayed");

            Driver.FindElement(By.LinkText("Account Details")).Click();

            Driver.FindElement(By.LinkText("Address Details")).Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#my_address > div.row.mb--40.mb-md--30 > div > h2")).Displayed, "My Address Message Not Displayed");
           
            Driver.Quit();

           /* SelectElement multiselect = new SelectElement(Driver.FindElement(By.XPath("//*[@id='drop-account']/a")));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            multiselect.SelectByText("Profile Details");

            Assert.IsTrue(Driver.FindElement(By.LinkText("My Account")).Displayed, "My Account Not Displayed");
            */

        }

        [TestMethod]
        public void AddEditDeleteInformation9()
        {
            IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://qa1.giftrt.com/");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.LinkText("Login")).Click();

            Driver.FindElement(By.Id("user_email")).SendKeys("bajfaj2@gmail.com");

            Driver.FindElement(By.Id("user_password")).SendKeys("Jmicheal1");

            Driver.FindElement(By.Id("btn_signin")).Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.FindElement(By.LinkText("Account Details")).Click();

            Driver.FindElement(By.LinkText("Profile Details")).Click();

            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("name_prefix")));
           // Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            multiselect.SelectByValue("M-Mr.");

            Driver.FindElement(By.Id("about")).Clear();
            Driver.FindElement(By.Id("about")).SendKeys("Automated Script Input");

            Driver.FindElement(By.Id("btn_save_details")).Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='suc_msg']")).Displayed, "Saved Success Message Not Displayed");

            Driver.Quit();

        }
    }
}
