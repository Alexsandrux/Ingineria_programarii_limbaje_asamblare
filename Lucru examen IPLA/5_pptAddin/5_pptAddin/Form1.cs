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

namespace _5_pptAddin
{
    public partial class Form1 : Form
    {
        PP._Application app;
        public Form1()
        {
            InitializeComponent();

            app = Globals.ThisAddIn.Application as PP._Application;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PP.Presentation ap = app.ActivePresentation;
            var slideRange = ap.Slides.Range();
            
            PP.CustomLayout customLayout = ap.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutText];

            var slide = ap.Slides.AddSlide(1, customLayout);

            slide.Shapes[1].TextFrame.TextRange.Text = tbTitle.Text;
            slide.Shapes[2].TextFrame.TextRange.Text = tbText.Text;

        }
    }
}
