using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word.Controls;
using ProiectWordIPLA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ProiectWordIPLA
{
    public partial class FormMeniu : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        public FormMeniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp =  new Excel.Application();
            excelApp.Visible = true;

            var workbook = excelApp.Workbooks.Add() ;
            var sheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1) ;

            DataGridViewRow c = dataGridViewClienti.SelectedRows[0];

            int idClient;

            try
            {
                idClient = Int32.Parse(c.Cells[0].Value.ToString());

            }
            catch { MessageBox.Show("Id-ul trebuie sa fie o valoare numerica"); return; }

            List<Rezervare> rezervari = new List<Rezervare>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            

            try
            {
                con.Open();

                sql = "select * from Rezervari where idClient = " + idClient;

                command = new SqlCommand(sql, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    try
                    {
                        int id = dataReader.GetInt32(0);
                        int idC = dataReader.GetInt32(1);
                        float val = (float)dataReader.GetDouble(2);
                        int nrCamera = dataReader.GetInt32(3);

                        DateTime d = dataReader.GetDateTime(4);

                        rezervari.Add(new Rezervare(id, idC, nrCamera, val, d));

                    }
                    catch { MessageBox.Show("Eroare la parsare"); }


                }

                con.Close();

            } catch (Exception ex) { MessageBox.Show(ex.StackTrace); }


            

            sheet.Cells[1, 1] = 
                dataGridViewClienti.SelectedRows[0].Cells[1].Value + 
                " " +
                dataGridViewClienti.SelectedRows[0].Cells[2].Value;

            sheet.Cells[2, 1] = "Id rezervare";
            sheet.Cells[2, 2] = "Camera rezervare";
            sheet.Cells[2, 3] = "Valoare";
            sheet.Cells[2, 4] = "Data Rezervare";
            double total = 0;
            for (int i = 0; i < rezervari.Count; i++)
            {
                sheet.Cells[2 + i + 1, 1] = rezervari[i].ID.ToString();
                sheet.Cells[2 + i + 1, 2] = rezervari[i].NumarCamera.ToString();
                total += rezervari[i].Valoare;
                sheet.Cells[2 + i + 1, 3] = rezervari[i].Valoare.ToString();
                sheet.Cells[2 + i + 1, 4] = rezervari[i].Data.ToString("dd/MM/yyyy");
            }

            sheet.Cells[rezervari.Count + 1 + 2, 3] = total;
            sheet.Cells[rezervari.Count + 1 + 2, 2] = "TOTAL";

        }

        private void FormMeniu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Rezervari' table. You can move, or remove it, as needed.
            this.rezervariTableAdapter.Fill(this.masterDataSet.Rezervari);
            // TODO: This line of code loads data into the 'masterDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.masterDataSet.Clienti);

        }

        private void clientSelectat(object sender, EventArgs e)
        {
            DataGridViewRow c = dataGridViewClienti.SelectedRows[0];
            int idClient;

            try
            {
                idClient = Int32.Parse(c.Cells[0].Value.ToString());

            }
            catch { MessageBox.Show("Id-ul trebuie sa fie o valoare numerica"); return; }


            DataView dv = (this.masterDataSet.Rezervari).DefaultView;
            dv.RowFilter = "idClient =" + idClient;
            dataGridViewRezervari.DataSource = dv;
        }

        private void CreeazaFactura(object sender, EventArgs e)
        {
            Word.Application wApp = new Word.Application();
            wApp.Visible = true;

            Word.Document wdoc = wApp.Documents.Add();


            Word.Paragraph wParagraph1 = wdoc.Paragraphs.Add();

            wParagraph1.Range.Text = "Factura rezervare " + dataGridViewRezervari.SelectedRows[0].Cells[0].Value.ToString();
            wParagraph1.Range.Font.Name = "Times New Roman";
            wParagraph1.Range.Font.Size = 16;
            wParagraph1.Range.Font.Bold = -1;
            wParagraph1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


            Word.Paragraph wParagraph2 = wdoc.Paragraphs.Add();

            wParagraph2.Range.Text += "\r\n\n\tClientul " +
                dataGridViewClienti.SelectedRows[0].Cells[1].Value.ToString() + " " +
                dataGridViewClienti.SelectedRows[0].Cells[2].Value.ToString() + " a rezervat camera " +
                dataGridViewRezervari.SelectedRows[0].Cells[3].Value.ToString() + " la data de " +
                dataGridViewRezervari.SelectedRows[0].Cells[4].Value.ToString() + " si are de platit suma de " +
                (float.Parse(dataGridViewRezervari.SelectedRows[0].Cells[2].Value.ToString()) * 1.2) + "lei .";
            wParagraph2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wParagraph2.Range.Font.Size = 12;
            wParagraph2.Range.Font.Bold = 0;

            Word.Paragraph wParagraph3 = wdoc.Paragraphs.Add();
            wParagraph3.Range.Text += "\n\nSemnatura pensiune,";
            wParagraph3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;


        }
    }
}
    