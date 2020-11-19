using System;

namespace Michal_Kucharski_Windows_Forms
{
    public enum  RodzajFiltru{
        Mniejsze,
        Wieksze,
        Rowne,
        Brak
    }

    public class Filtr
    {
        public RodzajFiltru RodzajFiltru = RodzajFiltru.Brak;
        public int Predkosc  = -1;
    }
}