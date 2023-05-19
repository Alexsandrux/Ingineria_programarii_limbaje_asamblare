using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6ExcelAddin
{
    public partial class FormDimensiune : Form
    {
        public FormDimensiune()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Dimensiune Matrice";
        }


        public int Dimensiune
        {
            get { return (int)numDimensiune.Value; }
        }
    }
}
