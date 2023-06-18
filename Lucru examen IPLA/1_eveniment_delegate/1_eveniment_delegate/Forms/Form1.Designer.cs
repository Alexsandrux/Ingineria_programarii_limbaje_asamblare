namespace _1_eveniment_delegate.Forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificaVarsta = new System.Windows.Forms.Button();
            this.tbIstoric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Istoric";
            // 
            // btnModificaVarsta
            // 
            this.btnModificaVarsta.Location = new System.Drawing.Point(26, 235);
            this.btnModificaVarsta.Name = "btnModificaVarsta";
            this.btnModificaVarsta.Size = new System.Drawing.Size(279, 23);
            this.btnModificaVarsta.TabIndex = 1;
            this.btnModificaVarsta.Text = "Deschide form modificare varsta";
            this.btnModificaVarsta.UseVisualStyleBackColor = true;
            this.btnModificaVarsta.Click += new System.EventHandler(this.btnModificaVarsta_Click);
            // 
            // tbIstoric
            // 
            this.tbIstoric.Enabled = false;
            this.tbIstoric.Location = new System.Drawing.Point(391, 78);
            this.tbIstoric.Multiline = true;
            this.tbIstoric.Name = "tbIstoric";
            this.tbIstoric.Size = new System.Drawing.Size(346, 340);
            this.tbIstoric.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIstoric);
            this.Controls.Add(this.btnModificaVarsta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificaVarsta;
        private System.Windows.Forms.TextBox tbIstoric;
    }
}