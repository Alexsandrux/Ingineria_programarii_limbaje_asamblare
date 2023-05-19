using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Curs6VSTOEXCEL
{
    public partial class Ribbon1
    {
        Excel.Application excelAplc;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            excelAplc = Globals.ThisAddIn.Application;

            excelAplc.WorkbookNewSheet += Eapl_WorkbookNewSheet;
        }

        private void Eapl_WorkbookNewSheet(Workbook Wb, object Sh)
        {
            Excel.Worksheet wsh = Sh as Excel.Worksheet;

            wsh.Cells[2, 2] = Wb.Name;
            wsh.Cells[4, 2] = wsh.Name;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet wsh = excelAplc.ActiveSheet;
            Excel.Range range = excelAplc.Selection;

            int noLines = range.Rows.Count;
            int noColumns = range.Columns.Count;

            int i, j, s;

            for(i = 1; i <= noLines; i++)
            {
                s = 0;
                for(j = 1; j <= noColumns; j++)
                {
                    if (range.Cells[i, j] == null) continue;
                    s += range.Cells[i, j].Value;
                }

                range.Cells[i, noColumns + 2].Value = s;
                range.Cells[i, noColumns + 2].Font.Bold = true ;
                
            }   


        }
    }
}
