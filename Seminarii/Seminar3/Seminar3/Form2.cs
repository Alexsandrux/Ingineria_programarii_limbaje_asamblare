using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3
{
    public partial class Form2 : Form { 
    
        MM_Animatie f2anim;
        public Form2(MM_Animatie f2anim)
        {
            InitializeComponent();
            this.f2anim = f2anim;
            f2anim.Schimbare_cadru += new MM_EventHandler(Functie_schimbare_cadru);
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            f2anim.Play();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            f2anim.Stop();
        }

        public void Functie_schimbare_cadru(object sender, MM_EventArgs e)
        {
            pictureBox1.Image = e.img_cadru;
        }

    }
}
