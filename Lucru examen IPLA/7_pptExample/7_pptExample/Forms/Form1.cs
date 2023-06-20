using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace _7_pptExample.Forms
{
    public partial class Form1 : Form
    {
        PP._Application pApp;
        PP.Presentation presentation;

        public Form1()
        {
            InitializeComponent();

            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pApp = new PP.Application() as PP._Application ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presentation = pApp.Presentations.Add(Office.MsoTriState.msoTrue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PP.CustomLayout customLayout = presentation.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutText];
            PP.Slide slide = presentation.Slides.AddSlide(1, customLayout);

            slide.Shapes[1].TextFrame.TextRange.Text = textBox1.Text;

            slide.Shapes[2].TextFrame.TextRange.Text = textBox2.Text;

        }
    }
}
