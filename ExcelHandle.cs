using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestAutomation
{
    class ExcelHandle
    {
        public void ExcelOperations()
        {
            Excel.Application xlapp;
            Excel.Workbook xlworkbook;
            Excel.Worksheet xlworksheeet;
            Excel.Range range;


            xlapp = new Excel.Application();
            xlworkbook =  xlapp.Workbooks.Open("‪D:\\Login.xlsx");
            xlworksheeet = (Excel.Worksheet)xlworkbook.Worksheets.get_Item(1) ;
            range = xlworksheeet.UsedRange;
            int rowcount = range.Rows.Count;
            int colcount = range.Columns.Count;
            Console.WriteLine("rowcount : "+ rowcount);
            Console.WriteLine("colcount : " + colcount);


            
            for(int i = 1; i <= rowcount; i++ )
            {
                for(int j = 1; j <= colcount; j++)
                {
                    String cellval = range.Cells[i, j].ToString();
                    Console.WriteLine("cellval : " + cellval);
                }
            }

            range.Cells[3, 3] = "Pass";
            xlworkbook.Save();

            xlapp.Quit();




        }
    }
}
