namespace ProiectWordIPLA
{
    partial class FormMeniu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new ProiectWordIPLA.masterDataSet();
            this.clientiTableAdapter = new ProiectWordIPLA.masterDataSetTableAdapters.ClientiTableAdapter();
            this.dataGridViewRezervari = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervariTableAdapter = new ProiectWordIPLA.masterDataSetTableAdapters.RezervariTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deschide Tabel Rezervari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.AllowUserToAddRows = false;
            this.dataGridViewClienti.AllowUserToDeleteRows = false;
            this.dataGridViewClienti.AutoGenerateColumns = false;
            this.dataGridViewClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numeDataGridViewTextBoxColumn,
            this.Prenume,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridViewClienti.DataSource = this.clientiBindingSource;
            this.dataGridViewClienti.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewClienti.MultiSelect = false;
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.ReadOnly = true;
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClienti.Size = new System.Drawing.Size(553, 174);
            this.dataGridViewClienti.TabIndex = 1;
            this.dataGridViewClienti.SelectionChanged += new System.EventHandler(this.clientSelectat);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Prenume
            // 
            this.Prenume.DataPropertyName = "Prenume";
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.MinimumWidth = 6;
            this.Prenume.Name = "Prenume";
            this.Prenume.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewRezervari
            // 
            this.dataGridViewRezervari.AllowUserToAddRows = false;
            this.dataGridViewRezervari.AllowUserToDeleteRows = false;
            this.dataGridViewRezervari.AutoGenerateColumns = false;
            this.dataGridViewRezervari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idClient,
            this.valoareDataGridViewTextBoxColumn,
            this.numarCameraDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridViewRezervari.DataSource = this.rezervariBindingSource;
            this.dataGridViewRezervari.Location = new System.Drawing.Point(592, 27);
            this.dataGridViewRezervari.MultiSelect = false;
            this.dataGridViewRezervari.Name = "dataGridViewRezervari";
            this.dataGridViewRezervari.ReadOnly = true;
            this.dataGridViewRezervari.RowHeadersWidth = 51;
            this.dataGridViewRezervari.RowTemplate.Height = 24;
            this.dataGridViewRezervari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRezervari.Size = new System.Drawing.Size(682, 174);
            this.dataGridViewRezervari.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "idClient";
            this.idClient.MinimumWidth = 6;
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarCameraDataGridViewTextBoxColumn
            // 
            this.numarCameraDataGridViewTextBoxColumn.DataPropertyName = "numarCamera";
            this.numarCameraDataGridViewTextBoxColumn.HeaderText = "numarCamera";
            this.numarCameraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarCameraDataGridViewTextBoxColumn.Name = "numarCameraDataGridViewTextBoxColumn";
            this.numarCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervariBindingSource
            // 
            this.rezervariBindingSource.DataMember = "Rezervari";
            this.rezervariBindingSource.DataSource = this.masterDataSet;
            // 
            // rezervariTableAdapter
            // 
            this.rezervariTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Creeaza Factura Rezervare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CreeazaFactura);
            // 
            // FormMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewRezervari);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.button1);
            this.Name = "FormMeniu";
            this.Text = "FormMeniu";
            this.Load += new System.EventHandler(this.FormMeniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private masterDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewRezervari;
        private System.Windows.Forms.BindingSource rezervariBindingSource;
        private masterDataSetTableAdapters.RezervariTableAdapter rezervariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}