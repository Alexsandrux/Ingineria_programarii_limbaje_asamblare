using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCurs7
{
    public partial class Form1 : Form
    {
        public Ribbon1 rb;
        public Form1(Ribbon1 frb)
        {
            InitializeComponent();
            rb = frb;

        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
            if(tb.Text != string.Empty)
            {
                string val = textBox1.Text;
                rb.Application.ActiveSheet.Range[tb.Text].Value = val;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rb.Application.SheetSelectionChange -= rb.App_SheetSelectionChange;
            rb.Form1.Hide();
        }
    }
}
