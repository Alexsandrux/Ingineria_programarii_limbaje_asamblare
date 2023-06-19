using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace _3_excelAddin
{
    public partial class Form1 : Form
    {
        Excel.Worksheet ws = null;
        int a1 = 0;
        int a2 = 0;

        int b1 = 0;
        int b2 = 0;


        public Form1()
        {
            InitializeComponent();

            TopMost = true;

            if(Globals.ThisAddIn.Application.ActiveSheet != null)
            {
                ws = Globals.ThisAddIn.Application.ActiveSheet;
                ws.SelectionChange += CurrentSheet_SelectionChanged;

            }

            Globals.ThisAddIn.Application.SheetActivate += (sh) => {
                ws = sh as Excel.Worksheet;
                ws.SelectionChange += CurrentSheet_SelectionChanged;
            };

            Globals.ThisAddIn.Application.SheetDeactivate += (sh) => {
                ws = sh as Excel.Worksheet;
                ws.SelectionChange -= CurrentSheet_SelectionChanged;
            };

        }

        private void CurrentSheet_SelectionChanged(Excel.Range range)
        {
            string adresa = range.get_Address(Type.Missing,
                Type.Missing, Excel.XlReferenceStyle.xlR1C1);

            
            
            string[] vs = adresa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries); 


            tbLeft.Text = "" + vs[0];

            if (vs.Length != 2)
            {
                tbRight.Text = "" + vs[0];
            }
            else
            {
                tbRight.Text = "" + vs[1];

            }
            


            string[] snc = vs[0].Split(new char[] {'R', 'C'},
                StringSplitOptions.RemoveEmptyEntries);
            a1 = Convert.ToInt32(snc[0]);
            b1 = Convert.ToInt32(snc[1]);

            if(vs.Length != 2) { a2 = a1; b2 = b1; } else
            {
                string[] snc2 = vs[1].Split(new char[] { 'R', 'C' },
    StringSplitOptions.RemoveEmptyEntries);
                a2= Convert.ToInt32(snc2[0]);
                b2 = Convert.ToInt32(snc2[1]);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b2 != 4)
            {
                MessageBox.Show("Nu ati selectat toate cele 4 coloane");
                return;
            }
            ws.Cells[1, 5] = "Profit unitar";
            ws.Cells[1, 6] = "Profit produs";

            //string[,] matrice = new string[a2, b2];
            //for (int i = a1 - 1; i < a2; i++)
            //{
            //    for(int j = b1 - 1; j < b2; j++) { 
            //        //matrice[i, j] = "" + ws.Cells[i + 1, j + 1].Value;




            //    }
            //}
            double sum = 0;
            for(int i = a1; i < a2 + 1; i++)
            {
                if (i == 1) continue;
                ws.Cells[i, 5] = Convert.ToDouble(ws.Cells[i, 3].Value) - Convert.ToDouble(ws.Cells[i, 4].Value);
                ws.Cells[i, 6] = Convert.ToDouble(ws.Cells[i, 5].Value) * Convert.ToDouble(ws.Cells[i, 2].Value);

                sum += (double)ws.Cells[i, 6].Value;

            }
            ws.Cells[a2 + 1, 6] = sum;
        }
    }
}
