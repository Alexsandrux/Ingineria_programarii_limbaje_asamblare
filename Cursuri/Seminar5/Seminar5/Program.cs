using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace Seminar5
{
    internal class Program
    {
        class Persoana
        {
            public string Nume { get; private set; }
            public decimal Medie { get; private set; }

            public Persoana(string linie)
            {
                string[] vector = linie.Split(',');
                this.Nume = vector[0];
                this.Medie = decimal.Parse(vector[1], CultureInfo.InvariantCulture);
            }

            public override string ToString()
            {
                return string.Format("{0, -20} - {1, 4:0.00}", this.Nume, this.Medie);
            }
        }

            
            static void Main(string[] args)
            {
            string baseFileName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Materiale\\");
            string dataFileName = baseFileName + "students.txt";
            string wordFileName = baseFileName + "students.doc";
            string excelFileName = baseFileName + "students.xlsx";
            string excelTemplateFileName = baseFileName + "StudentsTemplate.xlsx";
            string siglaFileName = baseFileName + "sigla.jpg";

            var students = File.ReadAllLines(dataFileName).Select(linie => new Persoana(linie)).OrderByDescending(pers => pers.Medie).ThenBy(pers => pers.Nume).ToList();
            
            students.ForEach(pers => Console.WriteLine(pers));

            var wordapp = new Word.Application() as Word._Application ;

            var document = wordapp.Documents.Add();

            document.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            var rangeHeader = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;


            rangeHeader.InlineShapes.AddPicture(siglaFileName);
            rangeHeader.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            var rangeFooter = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

            rangeFooter.Text = string.Format("tiparit la data de {0}", DateTime.Now.ToString("dd MMMM yyyy"), new CultureInfo("ro-ro"));

            rangeFooter.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;


            var rangeDoc = document.Range();
            rangeDoc.Text = "Lista studenti";
            rangeDoc.set_Style("Heading 1");

            rangeDoc.Font.Color = Word.WdColor.wdColorBlue;
            rangeDoc.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            rangeDoc.InsertParagraphAfter();
            rangeDoc.InsertParagraphAfter();

            rangeDoc.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            var table = document.Tables.Add(rangeDoc, students.Count + 1, 3);

            table.Cell(1, 1).Range.Text = "Nr crt";
            table.Cell(1, 2).Range.Text = "Nume";
            table.Cell(1, 3).Range.Text = "Medie";

            for(int i = 0; i < students.Count; i++)
            {
                table.Cell(i + 2, 1).Range.Text = (i+1).ToString();
                table.Cell(i + 2, 2).Range.Text = students[i].Nume;
                table.Cell(i + 2, 3).Range.Text = students[i].Medie.ToString();

                table.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                table.Cell(i + 2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                table.Cell(i + 2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            }

            table.set_Style("Table professional");
            table.Columns.AutoFit();
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);

            //string fileNameDoc = wordFileName.Remove(wordFileName.Length - 1, 1);


            document.SaveAs2(wordFileName);

            wordapp.Quit();

            System.Diagnostics.Process.Start(wordFileName);

            

            // EXCEL

            var excelApp = new Excel.Application() as Excel._Application;

            var workbook = excelApp.Workbooks.Open(excelTemplateFileName);

            Excel.Worksheet sheetData = workbook.Sheets[2];

            var dataRange = sheetData.get_Range("A2");

            dataRange.Value2 = 1;

            dataRange.AutoFill((sheetData.get_Range("A2", "A" + (students.Count + 1))), Excel.XlAutoFillType.xlFillSeries);

            for(int i = 0; i < students.Count; i++)
            {
                (sheetData.Cells[i + 2,2] as Excel.Range).Value2 = students[i].Nume;
                (sheetData.Cells[i + 2, 3] as Excel.Range).Value2 = students[i].Medie;
            }

            sheetData.get_Range("C2", "C" + (students.Count + 1)).Name = "Valori";

            excelApp.DisplayAlerts = false;

            workbook.Close(SaveChanges: true, excelFileName);


            excelApp.Quit();

            System.Diagnostics.Process.Start(excelFileName);

            Console.ReadLine();


        }

        }
    
}
