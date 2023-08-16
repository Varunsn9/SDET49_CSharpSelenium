using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SDET49_CSharpSelenium.ObjRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET49_CSharpSelenium.TestScript
{
    [TestClass]
    public class LoginPageObjRepo
    {
        [TestMethod]
        [TestCategory("WebDriverWait")]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            webDriverWait.Until(ExpectedConditions.TitleIs("Google"));
               
        }
    }
}
