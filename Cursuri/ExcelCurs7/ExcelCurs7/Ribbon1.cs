using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelCurs7
{
    public partial class Ribbon1
    {
        public Excel.Application Application;
        public Form1 Form1;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            Application = Globals.ThisAddIn.Application;
            Form1 = new Form1(this);
        }


        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form1.TopMost = true;
            Form1.Show();

            Application.SheetSelectionChange += App_SheetSelectionChange;
        }

        public void App_SheetSelectionChange(object Sh, Range Target)
        {
            int n = Target.Count;

            string sadr = Target.Address[false, false];

            if(Form1.Visible)
            {
                Form1.Focus();
                if(n!=0)
                {
                    if(Form1.tb.Focused)
                    {
                        Form1.tb.Text = sadr;
                    }

                }
            }

        }
    }
}
