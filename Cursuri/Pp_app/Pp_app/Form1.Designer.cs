﻿namespace Pp_app
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
            this.button1 = new System.Windows.Forms.Button();
            this.titlul = new System.Windows.Forms.TextBox();
            this.subt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbcf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deschide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlul
            // 
            this.titlul.Location = new System.Drawing.Point(297, 48);
            this.titlul.Name = "titlul";
            this.titlul.Size = new System.Drawing.Size(224, 20);
            this.titlul.TabIndex = 1;
            // 
            // subt
            // 
            this.subt.Location = new System.Drawing.Point(50, 152);
            this.subt.Multiline = true;
            this.subt.Name = "subt";
            this.subt.Size = new System.Drawing.Size(226, 130);
            this.subt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Creare slide titlu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(399, 152);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(261, 139);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 4;
            this.pb.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Adaugare slide imagine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(676, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "Get Imagine";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbcf
            // 
            this.tbcf.Location = new System.Drawing.Point(399, 122);
            this.tbcf.Name = "tbcf";
            this.tbcf.ReadOnly = true;
            this.tbcf.Size = new System.Drawing.Size(261, 20);
            this.tbcf.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 408);
            this.Controls.Add(this.tbcf);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subt);
            this.Controls.Add(this.titlul);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox titlul;
        private System.Windows.Forms.TextBox subt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbcf;
    }
}

