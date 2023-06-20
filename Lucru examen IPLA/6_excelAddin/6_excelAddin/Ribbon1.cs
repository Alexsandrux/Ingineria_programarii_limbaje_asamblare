using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6_excelAddin
{
    public partial class Ribbon1
    {
        public delegate void delegateTest(int i);
        public delegateTest func;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            func += (int i) => { MessageBox.Show("Hello"); } ;
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            func?.Invoke(1);
        }
    }
}
