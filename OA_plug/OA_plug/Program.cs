using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
namespace OA_plug
{
    class Program
    {
        static void Main(string[] args)
        {
            Workbook book = new Workbook();
            book.LoadFromFile("test.csv", ",", 1, 1);
           // book.SaveToFile("test.xlsx", ExcelVersion.Version2010);
            //book.LoadFromFile("test.xlsx");
            //Protect Workbook
            Worksheet sheet = book.Worksheets[0];
            sheet.Protect("production", SheetProtectionType.All);
            //System.DateTime currentTime = new System.DateTime();
            string name = "output-";
            string str = System.DateTime.Now.ToString("D");
            string filename = ".xlsx";
            string mystr = name+ str + filename;
            //Save and Launch
            book.SaveToFile(mystr, ExcelVersion.Version2010);
            System.IO.File.Delete("test.csv");
        }
    }
}
