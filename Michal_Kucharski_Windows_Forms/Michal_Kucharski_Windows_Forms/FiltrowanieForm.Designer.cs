using System.ComponentModel;

namespace Michal_Kucharski_Windows_Forms
{
    partial class FilrtowanieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtFiltrowanaPredkosc = new System.Windows.Forms.TextBox();
            this.btnFiltruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "wpisz predkosc po ktorej chcesz filtrowac";
            // 
            // txtFiltrowanaPredkosc
            // 
            this.txtFiltrowanaPredkosc.Location = new System.Drawing.Point(134, 47);
            this.txtFiltrowanaPredkosc.Name = "txtFiltrowanaPredkosc";
            this.txtFiltrowanaPredkosc.Size = new System.Drawing.Size(68, 22);
            this.txtFiltrowanaPredkosc.TabIndex = 1;
            // 
            // btnFiltruj
            // 
            this.btnFiltruj.Location = new System.Drawing.Point(78, 75);
            this.btnFiltruj.Name = "btnFiltruj";
            this.btnFiltruj.Size = new System.Drawing.Size(175, 28);
            this.btnFiltruj.TabIndex = 2;
            this.btnFiltruj.Text = "zatwierdz";
            this.btnFiltruj.UseVisualStyleBackColor = true;
            this.btnFiltruj.Click += new System.EventHandler(this.btnFiltruj_Click);
            // 
            // FilrtowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 143);
            this.Controls.Add(this.btnFiltruj);
            this.Controls.Add(this.txtFiltrowanaPredkosc);
            this.Controls.Add(this.label1);
            this.Name = "FilrtowanieForm";
            this.Text = "FilrtowanieForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnFiltruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrowanaPredkosc;

        #endregion
    }
}