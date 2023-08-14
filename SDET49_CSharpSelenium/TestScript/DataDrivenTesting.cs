using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET49_CSharpSelenium.TestScript
{
    [TestClass]
    public class DataDrivenTesting
    {
        [TestMethod]
        [TestCategory("DataDrivenTest")]
        [DataTestMethod]
        [DataRow("https://www.google.com",1,true)]
        [DataRow("https://www.amazon.in",2,true)]
        [DataRow("https://www.gmail.com",3,true)]
        public void DataDrivenTest(string Url,int num,bool test)
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            Console.WriteLine(driver.Title);
            Console.WriteLine(num);
            driver.Quit();
            driver.Dispose();
            Assert.IsTrue(test);
        }
        [TestMethod]
        [TestCategory("Ignore")]
        [Ignore]
        public void Ignore()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine(driver.Title);
            driver.Quit();
            driver.Dispose();
            
        }
    }
}
