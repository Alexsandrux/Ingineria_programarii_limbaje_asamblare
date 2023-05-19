using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Seminar6ExcelAddin
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnGenMatrice_Click(object sender, RibbonControlEventArgs e)
        {
            using (var form = new FormDimensiune())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    Excel.Worksheet sheet = Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet;

                    Excel.Range range = Globals.ThisAddIn.Application.ActiveCell;

                    int linie = range.Row;
                    int col = range.Column;

                    for(int i = 0; i < form.Dimensiune; i++)
                    {
                        for(int j = 0; j < form.Dimensiune; j++)
                        {
                            (sheet.Cells[linie + i, col + j] as  Excel.Range).Value2 = i + j;
                        }
                    }
                }
            } 
        }
    }
}
