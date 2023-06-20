using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXCEL = Microsoft.Office.Interop.Excel;

namespace _8_excelExample.Forms
{
    public partial class Form1 : Form
    {
        EXCEL._Application xclApp;
        EXCEL.Workbook xclWorkbook;
        public Form1()
        {
            InitializeComponent();

            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xclApp = new EXCEL.Application() as EXCEL._Application;
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xclWorkbook = xclApp.Workbooks.Add();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xclApp.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EXCEL.Worksheet sheet = xclApp.Sheets.Add();

            EXCEL.Worksheet existingSheet = xclApp.Sheets[1];

            var excelRange = existingSheet.get_Range("A1", "C5");
            //var excelRange = existingSheet.get_Range("R1C1", "R5C5");
            excelRange.Value2 = 1;
        }
    }
}
