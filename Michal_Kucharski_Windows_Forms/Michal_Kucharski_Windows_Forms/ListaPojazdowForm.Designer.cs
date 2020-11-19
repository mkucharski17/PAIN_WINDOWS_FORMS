using System.ComponentModel;

namespace Michal_Kucharski_Windows_Forms
{
    partial class ListaPojazdowForm
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
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.btnFiltruj = new System.Windows.Forms.Button();
            this.listaPojazdowView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnWieksze = new System.Windows.Forms.Button();
            this.btnMniejsze = new System.Windows.Forms.Button();
            this.btnUsunFiltrowanie = new System.Windows.Forms.Button();
            this.btnRowne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(587, 42);
            this.toolBar1.TabIndex = 0;
            // 
            // btnFiltruj
            // 
            this.btnFiltruj.Location = new System.Drawing.Point(0, -1);
            this.btnFiltruj.Name = "btnFiltruj";
            this.btnFiltruj.Size = new System.Drawing.Size(86, 51);
            this.btnFiltruj.TabIndex = 2;
            this.btnFiltruj.Text = "filtruj";
            this.btnFiltruj.UseVisualStyleBackColor = true;
            this.btnFiltruj.Click += new System.EventHandler(this.btnFiltruj_Click);
            // 
            // listaPojazdowView
            // 
            this.listaPojazdowView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4});
            this.listaPojazdowView.Location = new System.Drawing.Point(0, 48);
            this.listaPojazdowView.Name = "listaPojazdowView";
            this.listaPojazdowView.Size = new System.Drawing.Size(581, 305);
            this.listaPojazdowView.TabIndex = 3;
            this.listaPojazdowView.UseCompatibleStateImageBehavior = false;
            this.listaPojazdowView.View = System.Windows.Forms.View.Details;
            this.listaPojazdowView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listaPojazdowView_ItemSelectionChanged);
            this.listaPojazdowView.DoubleClick += new System.EventHandler(this.listaPojazdowView_DoubleClick);
            this.listaPojazdowView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listaPojazdowView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "marka";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "predkosc maksymalna";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "data produkcji";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "rodzaj";
            // 
            // btnWieksze
            // 
            this.btnWieksze.Location = new System.Drawing.Point(83, 0);
            this.btnWieksze.Name = "btnWieksze";
            this.btnWieksze.Size = new System.Drawing.Size(86, 51);
            this.btnWieksze.TabIndex = 2;
            this.btnWieksze.Text = "wieksze";
            this.btnWieksze.UseVisualStyleBackColor = true;
            this.btnWieksze.Visible = false;
            this.btnWieksze.Click += new System.EventHandler(this.btnWieksze_Click);
            // 
            // btnMniejsze
            // 
            this.btnMniejsze.Location = new System.Drawing.Point(244, 0);
            this.btnMniejsze.Name = "btnMniejsze";
            this.btnMniejsze.Size = new System.Drawing.Size(86, 51);
            this.btnMniejsze.TabIndex = 2;
            this.btnMniejsze.Text = "mniejsze";
            this.btnMniejsze.UseVisualStyleBackColor = true;
            this.btnMniejsze.Visible = false;
            this.btnMniejsze.Click += new System.EventHandler(this.btnMniejsze_Click);
            // 
            // btnUsunFiltrowanie
            // 
            this.btnUsunFiltrowanie.Location = new System.Drawing.Point(327, 0);
            this.btnUsunFiltrowanie.Name = "btnUsunFiltrowanie";
            this.btnUsunFiltrowanie.Size = new System.Drawing.Size(86, 51);
            this.btnUsunFiltrowanie.TabIndex = 2;
            this.btnUsunFiltrowanie.Text = "usun filtrowanie";
            this.btnUsunFiltrowanie.UseVisualStyleBackColor = true;
            this.btnUsunFiltrowanie.Visible = false;
            this.btnUsunFiltrowanie.Click += new System.EventHandler(this.btnUsunFiltrowanie_Click);
            // 
            // btnRowne
            // 
            this.btnRowne.Location = new System.Drawing.Point(162, -1);
            this.btnRowne.Name = "btnRowne";
            this.btnRowne.Size = new System.Drawing.Size(86, 51);
            this.btnRowne.TabIndex = 2;
            this.btnRowne.Text = "rowne";
            this.btnRowne.UseVisualStyleBackColor = true;
            this.btnRowne.Visible = false;
            this.btnRowne.Click += new System.EventHandler(this.btnRowne_Click);
            // 
            // ListaPojazdowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 345);
            this.Controls.Add(this.listaPojazdowView);
            this.Controls.Add(this.btnRowne);
            this.Controls.Add(this.btnUsunFiltrowanie);
            this.Controls.Add(this.btnMniejsze);
            this.Controls.Add(this.btnWieksze);
            this.Controls.Add(this.btnFiltruj);
            this.Controls.Add(this.toolBar1);
            this.Name = "ListaPojazdowForm";
            this.Text = "ListaPojazdowForm";
            this.Load += new System.EventHandler(this.ListaPojazdow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRowne;

        private System.Windows.Forms.Button btnWieksze;

        private System.Windows.Forms.Button btnMniejsze;
        private System.Windows.Forms.Button btnUsunFiltrowanie;

        private System.Windows.Forms.Button btnFiltruj;
        private System.Windows.Forms.ListView listaPojazdowView;

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.ToolBar toolBar1;

        #endregion
    }
}