using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAProject1.Utilities;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace QAProject1.StepDefinations
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://qa1.giftrt.com/");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            Hooks.Driver.FindElement(By.LinkText("Login")).Click();
        }
        
        [Given(@"I enter a Valid Username")]
        public void GivenIEnterAValidUsername()
        {
            Hooks.Driver.FindElement(By.Id("user_email")).SendKeys("bajfaj2@gmail.com");
        }
        
        [Given(@"I enter a Valid Password")]
        public void GivenIEnterAValidPassword()
        {
            Hooks.Driver.FindElement(By.Id("user_password")).SendKeys("Jmicheal1");
        }
        
        [When(@"I click on the SignIn button")]
        public void WhenIClickOnTheSignInButton()
        {
            Hooks.Driver.FindElement(By.Id("btn_signin")).Click();
        }
        
        [Then(@"I am logged in successfully")]
        public void ThenIAmLoggedInSuccessfully()
        {
           Hooks.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
           // Thread.Sleep(5000);
            // Hooks.Driver.FindElement(By.LinkText("Overview")).Click();
          //  Hooks.Driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/a[1]")).Click();
           Assert.IsTrue(Hooks.Driver.FindElement(By.LinkText("Overview")).Displayed, "Overview Dashboard is not displayed");
        }

        [Given(@"I enter an InValid password")]
        public void GivenIEnterAnInValidPassword()
        {
            Hooks.Driver.FindElement(By.Id("user_password")).SendKeys("InvalidPassword");
        }

        [Then(@"I am not logged in")]
        public void ThenIAmNotLoggedIn()
        {
            // Hooks.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Thread.Sleep(5000);
         Assert.IsTrue(Hooks.Driver.FindElement(By.XPath("//*[@id='dng_id_t']")).Displayed, "Invalid Login Message Not Displayed");

         /*   WebDriverWait wait = new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(10));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            {
                web.FindElement(By.XPath("//*[@id='dng_id_t']"));
                return true;
            });
            */
          
        }

        [Then(@"I am not logged in with login button still available")]
        public void ThenIAmNotLoggedInWithLoginButtonStillAvailable()
        {
            Hooks.Driver.FindElement(By.LinkText("Login")).Click();
        }

        [When(@"I wait for Element")]
        public void WhenIWaitForElement()
        {
            // WaitForElements waitForElements = new WaitForElements();
            // WaitForElements.Wait(hooks.Driver, "dng_msg_t");
            // WaitForElements.Wait(Hooks.Driver, "dng_msg_t");
            WaitForElements.FluentWaitByXpath(Hooks.Driver, "//*[@id='dng_id_t']");
            // WaitForElements.FluentWaitWithByClause(Hooks.Driver, By.XPath("//*[@id='dng_id_t']"));
           // WaitForElements.FluentWaitWithFindElements(Hooks.Driver, Hooks.Driver.FindElement (By.XPath("//*[@id='dng_id_t']")));
        }
    }
}
