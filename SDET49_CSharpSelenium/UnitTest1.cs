using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SDET49_CSharpSelenium.ObjRepo;
using System;
using System.Threading;

namespace SDET49_CSharpSelenium
{
    [TestClass]
    [TestCategory("WebDriverMethods")]
    public class UnitTest1
    {
        IWebDriver driver;
        GoogleSearchPage searchPage;

        

        [TestMethod]
        public void TitleProperty()
        {
            //IWebDriver driver = new ChromeDriver();
           // driver.Navigate().GoToUrl("https://www.google.com");
           // driver.Url = "https://www.google.com";
            driver.FindElement(By.Name("q")).SendKeys("Title");
            Console.WriteLine(driver.Title);
        }
        [TestMethod]
        public void UrlProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Url");
            Console.WriteLine(driver.Url);
        }
        [TestMethod]
        public void CloseMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Close");
            Console.WriteLine("Closing the browser using IwebDriver close method");
            driver.Close();
        }
        [TestMethod]
        public void OpenMethod()
        {
            driver= new ChromeDriver();
            searchPage=new GoogleSearchPage(driver);
            driver.Url = searchPage.url;
            searchPage.searchTextBox.SendKeys("google");
            searchPage.searchButton.Click();
        }
    }
    [TestClass]
    [TestCategory("NavigateSubMethods")]
    public class NavigateSubMethods
    {
        [TestMethod]
        public void GoToUrlMethod()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }
        [TestMethod]
        public void BackMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }
        [TestMethod]
        public void RefreshMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com"); Thread.Sleep(1000);
            driver.Navigate().Refresh(); Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }
        [TestMethod]
        public void ForwardMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com"); Thread.Sleep(1000);
            driver.Navigate().Back(); Thread.Sleep(1000);
            driver.Navigate().Forward(); Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }

    }
}
