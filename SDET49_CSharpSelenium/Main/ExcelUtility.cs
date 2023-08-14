using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace SDET49_CSharpSelenium.Main
{
    [TestClass]
    public class ExcelUtility
    {
        string path = "C:\\NewDrive\\VisualStudioRepo\\SDET49_CSharpSelenium\\SDET49_CSharpSelenium\\Resources\\TestDataExcel.xlsx";
        public string ExcelData(string sheet,int row,int cell)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(path);
            string data=spreadsheet.Workbook.Worksheets.ByName(sheet).Cell(row, cell).ToString();
            int maxRow = spreadsheet.Workbook.Worksheets.ByName(sheet).NotEmptyRowMax;
           // Console.WriteLine(maxRow);
            spreadsheet.Close();

            return data;
            
        }
        [TestMethod]
        [TestCategory("ExcelData")]
        public void ExcelDataTest()
        {
            ExcelUtility excelUtility = new ExcelUtility();
            
            for(int i = 0; i < 6; i++) 
            {
                string data = excelUtility.ExcelData("Attributes", i, 0);
                Console.WriteLine(data);
            }
        }
       // [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {

        }
        //[AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }


    }

}
