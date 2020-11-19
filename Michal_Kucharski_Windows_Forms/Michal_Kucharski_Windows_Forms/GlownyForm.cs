using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michal_Kucharski_Windows_Forms
{
    public partial class GlownyForm : Form
    {
        private ListaPojazdowDocument _listaPojazdowDocument =
            new ListaPojazdowDocument(PrzykladowePojazdy.GetPrzykladowePojazdy());

        private int _liczbWidokow;

        public GlownyForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            _liczbWidokow = 0;
            UstawLiczbePojazdow(_listaPojazdowDocument.Pojazdy.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaPojazdowForm listaPojazdowForm = new ListaPojazdowForm(_listaPojazdowDocument, this);
            listaPojazdowForm.MdiParent = this;
            listaPojazdowForm.Show();
            listaPojazdowForm.FormClosing += ZamkniecieJednejListy;
            _liczbWidokow++;
        }

        private void ZamkniecieJednejListy(object sender, FormClosingEventArgs e)
        {
            if (_liczbWidokow <= 1 && e.CloseReason != CloseReason.MdiFormClosing) e.Cancel = true;
            else _liczbWidokow--;
        }

        private void DodajPojazd_Click(object sender, EventArgs e)
        {
            WybierzPojazdForm wybierzPojazdForm = new WybierzPojazdForm(null, _listaPojazdowDocument.Pojazdy);
            if (wybierzPojazdForm.ShowDialog() == DialogResult.OK)
            {
                Pojazd pojazd = new Pojazd(wybierzPojazdForm.Marka, wybierzPojazdForm.MaxPredkosc,
                    wybierzPojazdForm.DataProdukcji, wybierzPojazdForm.rodzaj);
                _listaPojazdowDocument.DodajPojazd(pojazd);
                UstawLiczbePojazdow(((ListaPojazdowForm) ActiveMdiChild).LiczbaPojazdow);
            }
            Invalidate();
        }

        private void DodajWidok_Click(object sender, EventArgs e)
        {
            ListaPojazdowForm listaPojazdowForm = new ListaPojazdowForm(_listaPojazdowDocument, this);
            listaPojazdowForm.MdiParent = this;
            listaPojazdowForm.Show();
            listaPojazdowForm.FormClosing += ZamkniecieJednejListy;
            _liczbWidokow++;
        }

        public void UstawLiczbePojazdow(int liczbaPojazdow)
        {
            barLiczbaPojazdow.Text = ($"Liczba wszystkich pojazdow = {liczbaPojazdow}");
        }

        private void GlownyForm_MdiChildActivate(object sender, EventArgs e)
        {
            UstawLiczbePojazdow(((ListaPojazdowForm) ActiveMdiChild).LiczbaPojazdow);
        }

        private void btnUsunPojazd_Click(object sender, EventArgs e)
        {
            var pojazd = ((ListaPojazdowForm) ActiveMdiChild).WybranyPojazd;
            var usunPojazdresult = MessageBox.Show($"chcesz usunac wybrany pojazd:\n{pojazd}", "Usuwanie pojazdu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (usunPojazdresult == DialogResult.Yes)
            {
                _listaPojazdowDocument.UsunPojazd(pojazd);
                UstawLiczbePojazdow(((ListaPojazdowForm) ActiveMdiChild).LiczbaPojazdow);
            }
        }
    }
}