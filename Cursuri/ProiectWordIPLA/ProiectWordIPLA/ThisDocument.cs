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
using System.Text.RegularExpressions;

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

            if (richTextNume.Text == null)
            {
                MessageBox.Show("Numele nu poate fi gol");
                return;
            }
            if (richTextPrenume.Text == null)
            {
                MessageBox.Show("Prenumele nu poate fi gol");
                return;
            }
            if (richTextEmail.Text == null)
            {
                MessageBox.Show("Email-ul nu poate fi gol");
                return;
            }
            if (richTexTelefon.Text == null)
            {
                MessageBox.Show("Telefonul nu poate fi gol");
                return;
            }

            if (richTextNume.Text.Equals("NUME"))
            {
                MessageBox.Show("Numele trebuie sa fie completat");
                return;
            }
            if (richTextPrenume.Text.Equals("PRENUME"))
            {
                MessageBox.Show("Prenumele trebuie sa fie completat");
                return;
            }
            if (richTexTelefon.Text.Equals("TELEFON"))
            {
                MessageBox.Show("Telefonul trebuie sa fie completat");
                return;
            }
            if (richTextEmail.Text.Equals("E-MAIL"))
            {
                MessageBox.Show("E-mailul trebuie sa fie completat");
                return;
            }
            if (!Regex.IsMatch(richTextEmail.Text, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$"))
            {
                MessageBox.Show("Acesta nu este un format de e-mail acceptat!");
                return;
            }
            if (!Regex.IsMatch(richTexTelefon.Text, @"^0(\d{9})$") )
            {
                MessageBox.Show("Acesta nu este un format de telefon acceptat!");
                return;
            }

            string sinsert = @"INSERT INTO Clienti(Nume, Prenume, Email, Telefon) VALUES"
                        + " ('" + richTextNume.Text + "','" + richTextPrenume.Text + "','" + richTextEmail.Text + "','" + richTexTelefon.Text + "')";

            try
            {
                con.Open();

                SqlCommand cinsert = new SqlCommand(sinsert, con);

                cinsert.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Noul client a fost adăugat în tabelă.");

            } catch { MessageBox.Show("Eroare la citire din baza de date!"); }

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
