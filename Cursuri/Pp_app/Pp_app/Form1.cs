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

namespace Pp_app
{
    public partial class Form1 : Form
    {
        PP.Application papl;
        PP.Presentation pprs;
        PP.Slide pslide;

        public Form1()
        {
            InitializeComponent();
            papl = new PP.Application();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pprs = papl.Presentations.Add(Office.MsoTriState.msoTrue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nrs = pprs.Slides.Count;
            PP.CustomLayout cl = pprs.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutTitle];
            pslide = pprs.Slides.AddSlide(nrs+1, cl);
            pslide.Shapes.Title.TextFrame.TextRange.Text = titlul.Text;
            pslide.Shapes[2].TextFrame.TextRange.Text = subt.Text;
            pslide.Shapes[2].TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignLeft;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog df = new OpenFileDialog();
            df.InitialDirectory = @"e:\";
            df.Filter = "Imagini de tipul BMP, JPEG, PNG|*.bmp;*.jpg;*.png|Toate fisierele|*.*";
            df.FilterIndex = 1;
            if(df.ShowDialog() == DialogResult.OK) 
                {
                tbcf.Text = df.FileName;
                pb.Image = new Bitmap(df.FileName);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nrs = pprs.Slides.Count;
            PP.CustomLayout cl = pprs.SlideMaster.CustomLayouts[7];
            pslide = pprs.Slides.AddSlide(nrs + 1, cl);
            float lat = pslide.CustomLayout.Width;
            float inalt = pslide.CustomLayout.Height;
            pslide.Shapes.AddTextbox(Office.MsoTextOrientation.msoTextOrientationHorizontal, 10, 10, lat - 20, 60);
            pslide.Shapes[1].TextFrame.TextRange.Text = titlul.Text;
            pslide.Shapes[1].TextFrame.TextRange.Font.Size = 48;
            pslide.Shapes[1].TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignCenter;
            pslide.Shapes.AddPicture(tbcf.Text, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 10, 80, lat - 20, inalt - 90);
        }
    }
}
