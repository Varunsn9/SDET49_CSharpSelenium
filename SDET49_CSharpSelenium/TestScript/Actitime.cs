using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SDET49_CSharpSelenium.TestScript
{
    [TestClass]
    public class Actitime
    {
        [TestMethod]
        [TestCategory("Actitime")]
        [DataTestMethod]
        [DataRow("admin","manager")]
        [DataRow("trainee", "trainee")]
        public void LoginAndLogout(string username,string password)
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.actitime.com");
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Name("pwd")).SendKeys(password);
            driver.FindElement(By.XPath("//div[.='Login ']")).Click();
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.TitleIs("actiTIME - Enter Time-Track"));
            driver.FindElement(By.XPath("//a[@id='logoutLink']")).Click();
        }
    }

}
