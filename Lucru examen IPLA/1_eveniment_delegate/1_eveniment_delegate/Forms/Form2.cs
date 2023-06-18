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
    public partial class Form2 : Form
    {
        Animal animal;
        public Form2(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0) {
                animal.Varsta = int.Parse(textBox1.Text);
            }
        }
    }
}
