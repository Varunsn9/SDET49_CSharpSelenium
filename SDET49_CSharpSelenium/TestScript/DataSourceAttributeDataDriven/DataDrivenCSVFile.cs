using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET49_CSharpSelenium.TestScript.DataSourceAttributeDataDriven
{

    [TestClass]
    public class DataDrivenCSVFile
    {

        public static TestContext testContext;
        
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }
        [AssemblyInitialize]
        public static void method(TestContext _testContext)
        {
            testContext=_testContext;
           
        }

        [TestMethod]
        [TestCategory("TC"),Owner("Varun")]
        [Priority(1)]
        public void DataTesting()
        {
            if (TestContext.Properties["Browser"].Equals("Chrome"))
            {
                IWebDriver driver = new ChromeDriver();
            }
            else {
                Assert.Fail(TestContext.Properties["Browser"].ToString());
            }
           
            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.Properties["Browser"].ToString());
        }
      /*  [AssemblyInitialize]
        public static void AssIni(TestContext testContext)
        {

        }

        [AssemblyCleanup]
        public static void AssCup()
        {

        }*/
        [TestMethod]
        [TestCategory("TC"), Owner("Varun")]
        [Priority(0)]
        public void DataTesting1()
        {
            Console.WriteLine(TestContext.TestName);
            Console.WriteLine(TestContext.Properties["Browser"]);

        }
        [TestMethod]
        [Priority(1)]
        [TestCategory("TC"), Owner("Varun")]
        public void DataTesting2()
        {
            Console.WriteLine(TestContext.TestName);
            Console.WriteLine(TestContext.Properties["Browser"]);
        }

      
    }
}
