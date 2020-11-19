using System;
using System.Collections.Generic;

namespace Michal_Kucharski_Windows_Forms
{
    public class ListaPojazdowDocument
    {
        public List<Pojazd> Pojazdy;

        public ListaPojazdowDocument(List<Pojazd> pojazdy)
        {
            this.Pojazdy = pojazdy;
        }

        public event Action<Pojazd> DodajPojazdEvent;
        public event Action<Pojazd> AktualizujPojazdEvent;
        public event Action<Pojazd> UsunPojazdEvent;

        public void DodajPojazd(Pojazd pojazd) {
            Pojazdy.Add(pojazd);
            DodajPojazdEvent?.Invoke(pojazd);
        }

        public void AktualizujPojazd(Pojazd staryPojazd, Pojazd nowyPojazd) {
            foreach(Pojazd pojazd in Pojazdy) {
                if (ReferenceEquals(pojazd, staryPojazd)) {
                    pojazd.Marka = nowyPojazd.Marka;
                    pojazd.MaxPredkosc = nowyPojazd.MaxPredkosc;
                    pojazd.DataProdukcji = nowyPojazd.DataProdukcji;
                    pojazd.Rodzaj = nowyPojazd.Rodzaj;
                    AktualizujPojazdEvent?.Invoke(pojazd);
                    return;
                }
            }
            
        }
        
        public void UsunPojazd (Pojazd pojazdDoUsuniecia) {
            foreach(Pojazd pojazd in Pojazdy) {
                if(ReferenceEquals(pojazd, pojazdDoUsuniecia)) {
                    UsunPojazdEvent?.Invoke(pojazd);
                    Pojazdy.Remove(pojazd);
                    return;
                }
            }
        }
        
    }
}