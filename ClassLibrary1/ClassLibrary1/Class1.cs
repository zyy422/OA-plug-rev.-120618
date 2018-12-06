using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
namespace ClassLibrary1
{
    public class Class1
    {   
        public void addEncryption()
        {
            //Load Workbook
            Workbook book = new Workbook();
            book.LoadFromFile("test.csv", ",",1,1);
            book.SaveToFile("test.xlsx", ExcelVersion.Version2010);
            book.LoadFromFile("test.xlsx");
            //Protect Workbook
            book.Protect("optorun");
            //Save and Launch
            book.SaveToFile("test(final).xlsx", ExcelVersion.Version2010);
            
        }
    }
}
