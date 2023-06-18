using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Powerpoint = Microsoft.Office.Interop.PowerPoint;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;

namespace _2_ppt_word_excel_consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // WORD

            // opening the word app
            var wordApp = new Word.Application() as Word._Application;
            var documentDoc = wordApp.Documents.Add();
            wordApp.Visible = true;

            var rangeDoc = documentDoc.Range();

            documentDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            rangeDoc.Text = "Titlu Heading 2";
            rangeDoc.set_Style("Heading 2");
            rangeDoc.Font.Color = Word.WdColor.wdColorRed;
            rangeDoc.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            rangeDoc.InsertParagraphAfter();
            rangeDoc.Collapse(WdCollapseDirection.wdCollapseEnd);
            rangeDoc.Text += "Text1 dupa inserarea unui paragraf";
            rangeDoc.Text += "Text1 dupa inserarea aceluiasi paragraf\n";
            rangeDoc.Font.Color = WdColor.wdColorBlue;

            rangeDoc.Text += "Text2 fara inserarea unui paragraf";

            rangeDoc.InsertParagraphAfter();
            rangeDoc.Text += "Text3 fara a trimite un range la pozitie de inceput sau final (a-l colapsa)";


            // Difrenta intre wdCollapseEnd=0 si wdCollapseStart=1 este ca end te duce la finalul documentului iar start de duce exact la inceput
            rangeDoc.InsertParagraphAfter();
            rangeDoc.Collapse(0);


            rangeDoc.Text += "Text4 crearea corecta al unui nou paragraf";

            rangeDoc.InsertParagraphAfter();
            rangeDoc.Collapse(0);
            // creare Tabel

            var table = documentDoc.Tables.Add(rangeDoc, 5, 2);

            table.Cell(1, 1).Range.Text = "Nr. CRT";
            table.Cell(1, 2).Range.Text = "Valoare";


            for (int i = 1; i < table.Rows.Count; i++)
            {
                table.Cell(i + 1, 1).Range.Text = (i).ToString();
                table.Cell(i + 1, 2).Range.Text = "Valoare!";
            }



            //documentDoc.SaveAs2(path + "LucruWord.doc");

            // excel
            var excelApp = new Excel.Application() as Excel._Application;
            var workBook = excelApp.Workbooks.Add();

            Excel.Worksheet createdSheet = excelApp.Sheets.Add();
            createdSheet.Name = "New sheet";


            Excel.Worksheet existingSheet = excelApp.Sheets[2];
            existingSheet.Name = "Original sheet";

            var excelRange1 = createdSheet.get_Range("A2", "B7");
            excelRange1.Value2 = 11;
            createdSheet.Cells[1, 1] = "TEST!";


            excelApp.Visible = true;

            // ppt
            var pptApp = new Powerpoint.Application() as Powerpoint._Application;
            Powerpoint.Presentation presentation = pptApp.Presentations.Add(Office.MsoTriState.msoTrue);
            Powerpoint.CustomLayout customLayout = presentation.SlideMaster.CustomLayouts[Powerpoint.PpSlideLayout.ppLayoutText];
            var slide = presentation.Slides.AddSlide(1, customLayout);

            //slide.Shapes.Title.TextFrame.TextRange.Text = "Titlu";

            slide.Shapes[1].TextFrame.TextRange.Text = "Titlu";
            
            slide.Shapes[2].TextFrame.TextRange.Text = "text";
        }
    }
}
