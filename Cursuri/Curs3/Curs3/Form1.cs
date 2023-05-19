using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Curs3
{

    public partial class Form1 : Form
    {
        Word.Application wapl = null;
        Word.Document wdoc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // text start word aplc
        {
            wapl = new Word.Application();
            //wdoc = wapl.Documents;
        }

        private void button2_Click(object sender, EventArgs e) // text vizualizeaza
        {
            wapl.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) // text document
        {
            wdoc = wapl.Documents.Add();
        }

        private void button4_Click(object sender, EventArgs e) // text incarca
        {
            Word.Range wr = wdoc.Range();
            wr.Text = "\n\n" + textBox1.Text + "\n\n"; // id-ul textBox-ului
            wr.Font.Name = "Times New Roman";
            wr.Font.Size = 14;
            wr.Font.Bold = -1;  

            wr.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            wr.InsertAfter("la data" + DateTime.Now.ToShortDateString() + "\n");

            wr.Paragraphs[3].Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter; // incepe de la 1 nu de la 0
        }
    }
}
