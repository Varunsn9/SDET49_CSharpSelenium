using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SDET49_CSharpSelenium.ObjRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace SDET49_CSharpSelenium.MouseActions
{
    [TestClass]
    [TestCategory("Actions")]
    public class ActionsTestClass
    {
        IWebDriver driver;
        Uri uri;

        GoogleSearchPage searchPage;
       
        [TestMethod]
        [DoNotParallelize]
        public void ActionsTest()
        {
            searchPage=new GoogleSearchPage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(searchPage.searchTextBox).SendKeys("Mouse Action Move to element");
            Thread.Sleep(2000);
            Console.WriteLine("Utilized SearchtextBox");
            
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            var pic=screenshot.GetScreenshot();
            pic.SaveAsFile("C:\\NewDrive\\VisualStudioRepo\\SDET49_CSharpSelenium\\SDET49_CSharpSelenium\\TestScript\\Varun.png",ScreenshotImageFormat.Png);

            action.MoveToElement(searchPage.searchButton).Click();action.Perform();
            Console.WriteLine("clicked on Search button");
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void KeysInput()
        {
          
            searchPage = new GoogleSearchPage(driver);
            driver.Manage().Window.Maximize();
            
            Actions action = new Actions(driver);
            //action.SendKeys("hello").Perform();
            action.MoveToElement(searchPage.searchTextBox).SendKeys("hello");
            Thread.Sleep(2000);//.Click().ContextClick().Perform();
            action.SendKeys(Keys.ArrowDown).Perform();
            action.SendKeys(Keys.ArrowDown).Perform();
           // action.MoveByOffset(100, 100).ContextClick().Perform();
            KeyboardSimulator keyboardSimulator = new KeyboardSimulator(new InputSimulator());
            keyboardSimulator.KeyPress(VirtualKeyCode.DOWN);
            
        }
        [TestInitialize]
        public void TestIniti()
        {
            driver = new ChromeDriver();
            Thread.Sleep(2000);
            Console.WriteLine("Browser has been launched");
          //  uri = new Uri("https://www.google.com");
            //driver.Navigate().GoToUrl(uri);
            Thread.Sleep(2000);
            Console.WriteLine("Navigated to Google");
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Thread.Sleep(2000);
            driver.Close();
            Console.WriteLine("Closed the browser");
            driver.Dispose();
        }
    }
}
