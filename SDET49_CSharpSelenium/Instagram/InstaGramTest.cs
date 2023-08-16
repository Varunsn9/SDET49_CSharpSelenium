using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SDET49_CSharpSelenium.Instagram
{
    [TestClass]
    public class InstaGramTest
    {
        [TestMethod]
        [TestCategory("InstaGram")]
        public void loginout()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[.='Phone number, username, or email']/following-sibling::input")).SendKeys("s.hemanth78@gmail.com");
            driver.FindElement(By.XPath("//span[.='Password']/following-sibling::input")).SendKeys("Hem@7411");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            //*[local-name()='svg'][@aria-label="Settings"]
         //clicking on more
            driver.FindElement(By.XPath("//*[local-name()='svg'][@aria-label=\"Settings\"]")).Click();
            //clicking on settings
            string settingxpath = "//*[@id=\"mount_0_0_mJ\"]/div/div/div[2]/div/div/div/div[2]/div/div/div[1]/div[1]/div/div/div/div/div/div/div[1]/div/a[1]";
        }

    }
}
