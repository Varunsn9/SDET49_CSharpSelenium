using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDET49_CSharpSelenium.ObjRepo
{
    /// <summary>
    /// This is a GoogleSearchPage WebElement Repo
    /// summary: this is a Google search page
    /// Remarks: with FindsBy attributes
    /// </summary>
    public class GoogleSearchPage
    {
        public string url = "https://www.google.com";
        //using FindsBy
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement searchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@value='Google Search'])[2]")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='logo']")]
        public IWebElement googleLogo { get; set; }
        
        public GoogleSearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
