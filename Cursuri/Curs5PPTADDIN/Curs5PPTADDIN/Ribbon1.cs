using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PP = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;


namespace Curs5PPTADDIN
{
    public partial class Ribbon1
    {
        PP.Application pptApp;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            pptApp = Globals.ThisAddIn.Application;

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            PP.Presentation presentation = pptApp.ActivePresentation;
            PP.SlideRange ssr = presentation.Slides.Range();
            PP.SlideShowTransition sst = ssr.SlideShowTransition;

            sst.AdvanceOnTime = Office.MsoTriState.msoTrue;
            sst.AdvanceTime = 2;
            sst.EntryEffect = PP.PpEntryEffect.ppEffectBlindsVertical;

            presentation.SlideShowSettings.StartingSlide = 1;
            presentation.SlideShowSettings.EndingSlide = presentation.Slides.Count;
            presentation.SlideShowSettings.Run();
        }
    }
}
