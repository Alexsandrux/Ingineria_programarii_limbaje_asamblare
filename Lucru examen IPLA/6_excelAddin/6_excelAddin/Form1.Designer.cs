namespace _6_excelAddin
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
            this.tbUpLeft = new System.Windows.Forms.TextBox();
            this.tbDownRight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aduna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUpLeft
            // 
            this.tbUpLeft.Location = new System.Drawing.Point(94, 74);
            this.tbUpLeft.Name = "tbUpLeft";
            this.tbUpLeft.Size = new System.Drawing.Size(100, 22);
            this.tbUpLeft.TabIndex = 1;
            // 
            // tbDownRight
            // 
            this.tbDownRight.Location = new System.Drawing.Point(94, 139);
            this.tbDownRight.Name = "tbDownRight";
            this.tbDownRight.Size = new System.Drawing.Size(100, 22);
            this.tbDownRight.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 315);
            this.Controls.Add(this.tbDownRight);
            this.Controls.Add(this.tbUpLeft);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUpLeft;
        private System.Windows.Forms.TextBox tbDownRight;
    }
}