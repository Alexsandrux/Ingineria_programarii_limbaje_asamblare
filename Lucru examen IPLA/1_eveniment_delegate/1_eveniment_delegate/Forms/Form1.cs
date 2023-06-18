using _1_eveniment_delegate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_eveniment_delegate.Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnModificaVarsta_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            animal.schimbare_varsta = new Animal.Delegat_Schimbare_Varsta((int i) => { tbIstoric.Text += animal.ToString() + "\n"; });

            Form2 form = new Form2(animal);
            form.ShowDialog();
        }
    }

}
