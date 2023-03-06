using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3
{
    public partial class Form1 : Form
    {
        MM_Animatie anim;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anim = new MM_Animatie(300);

            string cale = Path.Combine(
                Path.GetDirectoryName(this.GetType().Assembly.Location),
                "pamant");

            for(int i = 1; i <= 15; i++)
            {
                string fisier = Path.Combine(cale, "c" + i + ".jpg");

                anim.Add_imag(fisier);
            }

            anim.Schimbare_cadru += new MM_EventHandler(Functie_schimbare_cadru);

            anim.Terminare_animatie += new MM_EventHandler(Functie_terminare_animatie);
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            anim.Play();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            anim.Stop();

        }

        public void Functie_schimbare_cadru(object sender, MM_EventArgs e)
        {
            pictureBox1.Image = e.img_cadru;
        }

        public void Functie_terminare_animatie(object sender, MM_EventArgs e)
        {
            MessageBox.Show("S-a terminat animatia");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(anim);
            form2.Show();
        }
    }
}
