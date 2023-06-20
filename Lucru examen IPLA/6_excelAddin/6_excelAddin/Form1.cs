using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace _6_excelAddin
{
    public partial class Form1 : Form
    {
        Excel._Application a;
        Excel.Worksheet aws;
        string[] adresaStanga;
        string[] adresaDreapta;
        public Form1()
        {
            InitializeComponent();

            TopMost = true;

            a = Globals.ThisAddIn.Application as Excel._Application ;

            aws = a.ActiveSheet as Excel.Worksheet;

            if(aws != null )
            {
                aws.SelectionChange += Aws_SelectionChange;
            }
        }

        private void Aws_SelectionChange(Excel.Range range)
        {
            string adresa = range.get_Address(Type.Missing, Type.Missing, Excel.XlReferenceStyle.xlR1C1);

            string[] adrese = adresa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            tbDownRight.Text = adrese[1];
            tbUpLeft.Text = adrese[0];

            this.adresaStanga = adrese[0].Split(new char[] { 'R', 'C' }, StringSplitOptions.RemoveEmptyEntries);
            this.adresaDreapta = adrese[1].Split(new char[] { 'R', 'C' }, StringSplitOptions.RemoveEmptyEntries);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r1 = Convert.ToInt32(adresaStanga[0]);
            int c1 = Convert.ToInt32(adresaStanga[1]);

            int r2 = Convert.ToInt32(adresaDreapta[0]);
            int c2 = Convert.ToInt32(adresaDreapta[1]);

            int sum = 0;
            for(int i = r1; i< r2 + 1; i ++)
            {
                for (int j = c1; j < c2 + 1; j++)
                {

                    sum += (aws.Cells[i, j].Value == null) ? 0 : (int)aws.Cells[i, j].Value;

                }

            }

            aws.Cells[r2 + 1, c2 + 1] = sum;
        }
    }
}
