namespace Michal_Kucharski_Windows_Forms
{
    partial class GlownyForm
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
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.btnDodajWidok = new System.Windows.Forms.Button();
            this.barLiczbaPojazdow = new System.Windows.Forms.StatusBar();
            this.btnDodajPojazd = new System.Windows.Forms.Button();
            this.btnUsunPojazd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(1384, 42);
            this.toolBar1.TabIndex = 1;
            // 
            // btnDodajWidok
            // 
            this.btnDodajWidok.Location = new System.Drawing.Point(0, 0);
            this.btnDodajWidok.Name = "btnDodajWidok";
            this.btnDodajWidok.Size = new System.Drawing.Size(97, 42);
            this.btnDodajWidok.TabIndex = 2;
            this.btnDodajWidok.Text = "dodaj widok ";
            this.btnDodajWidok.UseVisualStyleBackColor = true;
            this.btnDodajWidok.Click += new System.EventHandler(this.DodajWidok_Click);
            // 
            // barLiczbaPojazdow
            // 
            this.barLiczbaPojazdow.Location = new System.Drawing.Point(0, 938);
            this.barLiczbaPojazdow.Name = "barLiczbaPojazdow";
            this.barLiczbaPojazdow.Size = new System.Drawing.Size(1384, 23);
            this.barLiczbaPojazdow.TabIndex = 4;
            this.barLiczbaPojazdow.Text = "liczba wszystkich pojazdow = 0";
            // 
            // btnDodajPojazd
            // 
            this.btnDodajPojazd.Location = new System.Drawing.Point(103, 0);
            this.btnDodajPojazd.Name = "btnDodajPojazd";
            this.btnDodajPojazd.Size = new System.Drawing.Size(94, 42);
            this.btnDodajPojazd.TabIndex = 2;
            this.btnDodajPojazd.Text = "dodaj pojazd";
            this.btnDodajPojazd.UseVisualStyleBackColor = true;
            this.btnDodajPojazd.Click += new System.EventHandler(this.DodajPojazd_Click);
            // 
            // btnUsunPojazd
            // 
            this.btnUsunPojazd.Location = new System.Drawing.Point(203, 0);
            this.btnUsunPojazd.Name = "btnUsunPojazd";
            this.btnUsunPojazd.Size = new System.Drawing.Size(87, 42);
            this.btnUsunPojazd.TabIndex = 6;
            this.btnUsunPojazd.Text = "usun pojazd";
            this.btnUsunPojazd.UseVisualStyleBackColor = true;
            this.btnUsunPojazd.Click += new System.EventHandler(this.btnUsunPojazd_Click);
            // 
            // GlownyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 961);
            this.Controls.Add(this.btnUsunPojazd);
            this.Controls.Add(this.barLiczbaPojazdow);
            this.Controls.Add(this.btnDodajPojazd);
            this.Controls.Add(this.btnDodajWidok);
            this.Controls.Add(this.toolBar1);
            this.IsMdiContainer = true;
            this.Name = "GlownyForm";
            this.Text = "Michal Kucharski Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.GlownyForm_MdiChildActivate);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnDodajPojazd;
        private System.Windows.Forms.Button btnDodajWidok;
        private System.Windows.Forms.Button btnUsunPojazd;

        private System.Windows.Forms.StatusBar barLiczbaPojazdow;

        private System.Windows.Forms.ToolBar toolBar1;

        #endregion
    }
}