using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data.SqlClient;

namespace ProiectWordIPLA
{
    public partial class ThisDocument
    {

        Button badd, bincarcare;
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            badd = new Button();
            badd.Text = "Adauga o rezervare noua";
            badd.Click += new EventHandler(adaugaRezervareNouA);
            Globals.ThisDocument.ActionsPane.Controls.Add(badd);

            bincarcare = new Button();
            bincarcare.Text = "Adauga noul client";
            bincarcare.Click += new EventHandler(adaugaClientInBD);
            Globals.ThisDocument.ActionsPane.Controls.Add(bincarcare);

            bincarcare = new Button();
            bincarcare.Text = "Deschide meniul";
            bincarcare.Click += new EventHandler(deschideMeniu);
            Globals.ThisDocument.ActionsPane.Controls.Add(bincarcare);

            //insertWordBasicText();

        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void adaugaClientInBD(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string sinsert = @"INSERT INTO Clienti(Nume, Prenume, Email, Telefon) VALUES"
                        + " ('" + richTextNume.Text + "','" + richTextPrenume.Text + "','" + richTextEmail.Text + "','" + richTexTelefon.Text + "')";

            con.Open();

            SqlCommand cinsert = new SqlCommand(sinsert, con);

            cinsert.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Noul client a fost adăugat în tabelă.");
        }

        public void adaugaRezervareNouA(object sender, EventArgs e)
        {
            FormAdaugaRezervare formRezervare = new FormAdaugaRezervare();
            formRezervare.Show();
        }

        public void deschideMeniu(object sender, EventArgs e)
        {
            FormMeniu form = new FormMeniu();
            form.Show();
        }


        public void insertWordBasicText()
        {
            object start = 0;
            object end = 0;

            Word.Range rng = this.Range(ref start, ref end);
            rng.Text = "New Text";
        }






        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

        }

        #endregion

    }
}
