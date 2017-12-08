using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace ParallelCalculation
{
   static class WriteInExcel
    {
        public static void Log(Dictionary<long,long> l)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "ThreadCount";
            xlWorkSheet.Cells[1, 2] = "Time";
            int k = 2;
            foreach (var item in l)
            {
                xlWorkSheet.Cells[k, 1] = item.Key;// k - 1;
                xlWorkSheet.Cells[k++, 2] = item.Value;

            }


            xlWorkBook.SaveAs(@"C:\Users\lhako\Desktop\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

    }
}
