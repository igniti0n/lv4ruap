using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lv44
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;

    
        [TestFixture]
        public class UntitledTestCase
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                baseURL = "https://www.google.com/";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                Assert.AreEqual("", verificationErrors.ToString());
            }

        [Test]
        public void TheDrugiTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.LinkText("Tablets")).Click();
            driver.FindElement(By.LinkText("Samsung Galaxy Tab 10.1")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.Id("cart-total")).Click();
        }
        [Test]
        public void TheCetvrtiTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.LinkText("Laptops & Notebooks")).Click();
            driver.FindElement(By.LinkText("Show All Laptops & Notebooks")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'HP LP3065')])[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div[2]/div/button/i")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
        }
        
        [Test]
        public void TheTreciTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.Name("search")).Click();
            driver.FindElement(By.Name("search")).Click();
            driver.FindElement(By.Name("search")).Clear();
            driver.FindElement(By.Name("search")).SendKeys("samsung galaxy tab a");
            driver.FindElement(By.Name("search")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("(//a[contains(text(),'Samsung Galaxy Tab 10.1')])[2]")).Click();
        }


        [Test]
        public void ThePetiTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.LinkText("Software")).Click();
            driver.FindElement(By.LinkText("Components (2)")).Click();
            driver.FindElement(By.LinkText("- Monitors (2)")).Click();
            driver.FindElement(By.LinkText("Apple Cinema 30\"")).Click();
        }
        



        [Test]
            public void TheUntitledTestCaseTest()
            {
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i")).Click();
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.Id("input-firstname")).Click();
                driver.FindElement(By.Id("input-firstname")).Clear();
                driver.FindElement(By.Id("input-firstname")).SendKeys("ivann");
                driver.FindElement(By.Id("input-lastname")).Click();
                driver.FindElement(By.Id("input-lastname")).Clear();
                driver.FindElement(By.Id("input-lastname")).SendKeys("stajcerrr");
                driver.FindElement(By.Id("input-email")).Click();
                driver.FindElement(By.Id("input-email")).Clear();
                driver.FindElement(By.Id("input-email")).SendKeys("istajcerr@etfos.hr");
                driver.FindElement(By.Id("input-telephone")).Click();
                driver.FindElement(By.Id("input-telephone")).Clear();
                driver.FindElement(By.Id("input-telephone")).SendKeys("123345657");
                driver.FindElement(By.Id("input-password")).Click();
                driver.FindElement(By.Id("input-password")).Clear();
                driver.FindElement(By.Id("input-password")).SendKeys("asdfghjk1234");
                driver.FindElement(By.Id("input-confirm")).Click();
                driver.FindElement(By.Id("input-confirm")).Clear();
                driver.FindElement(By.Id("input-confirm")).SendKeys("asdfghjk1234");
                driver.FindElement(By.Name("agree")).Click();
                driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
                driver.FindElement(By.LinkText("Continue")).Click();
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }


