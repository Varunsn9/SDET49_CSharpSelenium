using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET49_CSharpSelenium.TestScript
{
    [TestClass]
    [TestCategory("DataSourceAndDynamicData")]
    public class DynamicDataandDataSource
    {

        [TestMethod]
        [DynamicData(nameof(Names),DynamicDataSourceType.Method)]
        public void DynamicData(string names,string value, string position) 
        {
            Console.WriteLine($"Attributes are  {names} and Positions are {value} , position is {position}");
        }


        public static IEnumerable<object[]> Names()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("C:\\NewDrive\\VisualStudioRepo\\SDET49_CSharpSelenium\\SDET49_CSharpSelenium\\Resources\\TestDataExcel.xlsx");
            var sheet = spreadsheet.Workbook.Worksheets["Attributes"];
            var maxROW = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;

            for (int i = 0; i <= maxROW; i++)
            {
                string name = sheet.Cell(i, 0).ToString();
                string value = sheet.Cell(i,1).ToString();
                string position = sheet.Cell(i,2).ToString();
                yield return new object[] { name , value , position};
            }
        }
    }
}
