using Microsoft.Office.Interop.Excel;
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

namespace ProiectWordIPLA
{
    public partial class FormAdaugaRezervare : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
        Dictionary<int, float> valoriCamere = new Dictionary<int, float>();

        public FormAdaugaRezervare()
        {
            InitializeComponent();
            valoriCamere.Add(1, 200);
            valoriCamere.Add(2, 150);
            valoriCamere.Add(3, 180);
            valoriCamere.Add(4, 220);
            valoriCamere.Add(5, 120);
            valoriCamere.Add(6, 330);
            valoriCamere.Add(7, 160);
            valoriCamere.Add(8, 250);
            valoriCamere.Add(9, 280);

            valoriCamere.Keys.ToList().ForEach(key =>  comboBoxCamere.Items.Add(key) ) ;
            comboBoxCamere.SelectedIndex = 1;
         }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.masterDataSet.Clienti);
            

        }

        private void filtreaza(object sender, EventArgs e)
        {
            DataView dv = (this.masterDataSet.Clienti).DefaultView;
            dv.RowFilter = "Nume LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void adauga_rezervare(object sender, EventArgs e)
        {
            DataGridViewRow c = dataGridView1.SelectedRows[0];
            SqlConnection con = new SqlConnection(connectionString);

            int idClient;

            try
            {
                idClient = Int32.Parse(c.Cells[0].Value.ToString());

            }
            catch { MessageBox.Show("Id-ul trebuie sa fie o valoare numerica"); return; }



            string sinsert = 
                @"INSERT INTO Rezervari(idClient, Valoare, numarCamera, data) VALUES(" + idClient.ToString() +
                ","+ textBoxValoare.Text +
                ","+ comboBoxCamere.Text +
                ",CONVERT(datetime, '" + dateTimePicker1.Text + "',101))";
            
            try
            {
                con.Open();

                SqlCommand cinsert = new SqlCommand(sinsert, con);

                cinsert.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("O noua rezervare a fost adaugata pentru clientul ales.");

            } catch { MessageBox.Show("Eroare la adaugare in baza de date"); }


        }

        private void comboBoxCamere_SelectedIndexChanged(object sender, EventArgs e)
        {
            float valoare = valoriCamere[comboBoxCamere.SelectedIndex + 1];
            textBoxValoare.Text = valoare.ToString();
        }
    }
}
