using System;
using System.Windows.Forms;


namespace Michal_Kucharski_Windows_Forms
{
    public partial class ListaPojazdowForm : Form
    {
        private ListaPojazdowDocument ListaPojazdowDocument { get; }

        private Filtr _filtrPredkosci;
        
        private GlownyForm _glownyForm;
        public int LiczbaPojazdow { get; set; }

        public Pojazd WybranyPojazd { get; set; }

        public ListaPojazdowForm(ListaPojazdowDocument document, GlownyForm glownyForm)
        {
            InitializeComponent();
            ListaPojazdowDocument = document;
            _glownyForm = glownyForm;
            _filtrPredkosci = new Filtr();
            LiczbaPojazdow = ListaPojazdowDocument.Pojazdy.Count;
        }

        private void ListaPojazdow_Load(object sender, EventArgs e)
        {
            OdswierzListe();
            ListaPojazdowDocument.DodajPojazdEvent += DodajDocument;
            ListaPojazdowDocument.AktualizujPojazdEvent += AktualizujDocument;
            ListaPojazdowDocument.UsunPojazdEvent += UsunDocument;
            UstawRozmiarKolumn();
        }

        private void DodajDocument(Pojazd pojazd)
        {
            ListViewItem item = new ListViewItem {Tag = pojazd};
            ustawPojazd(item);
            if(PasujeDoFiltrow(pojazd))
                listaPojazdowView.Items.Add(item);
            LiczbaPojazdow++;
        }

        private void AktualizujDocument(Pojazd pojazd)
        {
            OdswierzListe();
        }

        private void UsunDocument(Pojazd pojazd)
        {
            foreach (ListViewItem item in listaPojazdowView.Items)
            {
                if (ReferenceEquals((Pojazd) item.Tag, pojazd))
                {
                    listaPojazdowView.Items.Remove(item);
                    LiczbaPojazdow--;
                    return;
                }
            }
            
            
        }

        private void OdswierzListe()
        {
            listaPojazdowView.Items.Clear();
            foreach (Pojazd pojazd in ListaPojazdowDocument.Pojazdy)
            {
                if (PasujeDoFiltrow(pojazd))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = pojazd;
                    ustawPojazd(item);
                    listaPojazdowView.Items.Add(item);
                }
            }
        }

        private void ustawPojazd(ListViewItem item)
        {
            Pojazd pojazd = (Pojazd) item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = pojazd.Marka;
            item.SubItems[1].Text = pojazd.MaxPredkosc.ToString();
            item.SubItems[2].Text = pojazd.DataProdukcji.ToShortDateString();
            item.SubItems[3].Text = pojazd.Rodzaj.ToString();
        }

        private void UstawRozmiarKolumn()
        {
            listaPojazdowView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listaPojazdowView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void btnFiltruj_Click(object sender, EventArgs e)
        {
            FilrtowanieForm filrtowanieForm = new FilrtowanieForm();
            if (filrtowanieForm.ShowDialog() == DialogResult.OK)
            {
                _filtrPredkosci.Predkosc = filrtowanieForm.UstawionyFiltrPredkosci;
                btnFiltruj.Text = filrtowanieForm.UstawionyFiltrPredkosci.ToString();
                btnMniejsze.Visible = true;
                btnWieksze.Visible = true;
                btnUsunFiltrowanie.Visible = true;
                btnRowne.Visible = true;
            }
        }

        private void btnWieksze_Click(object sender, EventArgs e)
        {
            listaPojazdowView.Items.Clear();
            _filtrPredkosci.RodzajFiltru = RodzajFiltru.Wieksze;
            foreach (Pojazd pojazd in ListaPojazdowDocument.Pojazdy)
            {
                if (pojazd.MaxPredkosc > _filtrPredkosci.Predkosc)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = pojazd;
                    ustawPojazd(item);
                    listaPojazdowView.Items.Add(item);
                }
            }

            LiczbaPojazdow = listaPojazdowView.Items.Count;
            _glownyForm.UstawLiczbePojazdow(LiczbaPojazdow);
        }

        private void btnMniejsze_Click(object sender, EventArgs e)
        {
            
            listaPojazdowView.Items.Clear();
            _filtrPredkosci.RodzajFiltru = RodzajFiltru.Mniejsze;
            foreach (Pojazd pojazd in ListaPojazdowDocument.Pojazdy)
            {
                if (pojazd.MaxPredkosc < _filtrPredkosci.Predkosc)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = pojazd;
                    ustawPojazd(item);
                    listaPojazdowView.Items.Add(item);
                }
            }

            LiczbaPojazdow = listaPojazdowView.Items.Count;
            _glownyForm.UstawLiczbePojazdow(LiczbaPojazdow);
        }

        private void btnUsunFiltrowanie_Click(object sender, EventArgs e)
        {
            listaPojazdowView.Items.Clear();
            foreach (Pojazd pojazd in ListaPojazdowDocument.Pojazdy)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = pojazd;
                ustawPojazd(item);
                listaPojazdowView.Items.Add(item);
            }

            btnMniejsze.Visible = false;
            btnWieksze.Visible = false;
            btnUsunFiltrowanie.Visible = false;
            btnRowne.Visible = false;
            btnFiltruj.Text = "filtruj";
            LiczbaPojazdow = listaPojazdowView.Items.Count;
            _filtrPredkosci.Predkosc = -1;
            _filtrPredkosci.RodzajFiltru = RodzajFiltru.Brak;
            _glownyForm.UstawLiczbePojazdow(LiczbaPojazdow);
        }

        private void btnRowne_Click(object sender, EventArgs e)
        {
            listaPojazdowView.Items.Clear();
            _filtrPredkosci.RodzajFiltru = RodzajFiltru.Rowne;
            foreach (Pojazd pojazd in ListaPojazdowDocument.Pojazdy)
            {
                if (pojazd.MaxPredkosc == _filtrPredkosci.Predkosc)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = pojazd;
                    ustawPojazd(item);
                    listaPojazdowView.Items.Add(item);
                }
            }

            LiczbaPojazdow = listaPojazdowView.Items.Count;
            _glownyForm.UstawLiczbePojazdow(LiczbaPojazdow);
        }


        private void listaPojazdowView_DoubleClick(object sender, EventArgs e)
        {
            var staryPojazd = (Pojazd) listaPojazdowView.SelectedItems[0].Tag;
            WybierzPojazdForm wybierzPojazdForm = new WybierzPojazdForm(staryPojazd, ListaPojazdowDocument.Pojazdy);
            if (wybierzPojazdForm.ShowDialog() == DialogResult.OK)
            {
                Pojazd nowyPojazd = new Pojazd(wybierzPojazdForm.Marka, wybierzPojazdForm.MaxPredkosc,
                    wybierzPojazdForm.DataProdukcji, wybierzPojazdForm.rodzaj);
                ListaPojazdowDocument.AktualizujPojazd(staryPojazd, nowyPojazd);
            }
        }

        private void listaPojazdowView_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void listaPojazdowView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listaPojazdowView.SelectedItems.Count == 1)
            {
                WybranyPojazd = (Pojazd) listaPojazdowView.SelectedItems[0].Tag;
            }
        }

        private bool PasujeDoFiltrow(Pojazd pojazd)
        {
            switch (_filtrPredkosci.RodzajFiltru)
            {
                case RodzajFiltru.Wieksze:
                    return pojazd.MaxPredkosc > _filtrPredkosci.Predkosc;
                case RodzajFiltru.Mniejsze:
                    return pojazd.MaxPredkosc < _filtrPredkosci.Predkosc;
                case RodzajFiltru.Rowne:
                    return pojazd.MaxPredkosc == _filtrPredkosci.Predkosc;
                default: return true;
            }
        }
    }
}