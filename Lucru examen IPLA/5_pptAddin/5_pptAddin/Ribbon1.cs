using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PP = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace _5_pptAddin
{
    public partial class Ribbon1
    {
        PP._Application app;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application as PP._Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            if (app == null) { MessageBox.Show("App is null"); return; }
            PP.Presentation pp = app.ActivePresentation;
            PP.SlideRange slidesRange = pp.Slides.Range();
            PP.SlideShowTransition sst = slidesRange.SlideShowTransition;
            sst.AdvanceOnTime = Office.MsoTriState.msoTrue;
            sst.AdvanceTime = 2;

            pp.SlideShowSettings.StartingSlide = 1;
            pp.SlideShowSettings.EndingSlide = pp.Slides.Count;
            pp.SlideShowSettings.Run();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
