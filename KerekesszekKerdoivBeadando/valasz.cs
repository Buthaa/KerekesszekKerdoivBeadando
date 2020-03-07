using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerekesszekKerdoivBeadando
{
    class valasz
    {
        int id;
        string nev;
        bool nem;
        int eletkor;
        bool onRendelkezikE;
        string marka;
        string modell;
        int szekKora;
        int suly;
        string szine;
        string ulesTipus;
        int akkumlatorokSzama;
        int maxSebesseg;
        bool rendelkezikExtrakkal;
        bool pohartarto;
        bool tomorgumi;
        bool ulesmagasitas;
        bool ulesdontes;

        public valasz(int id, string nev, int eletkor)
        {
            this.id = id;
            this.nev = nev;
            this.eletkor = eletkor;
        }

        public valasz(int id, string nev, bool nem, int eletkor, bool onRendelkezikE)
        {
            this.id = id;
            this.nev = nev;
            this.nem = nem;
            this.eletkor = eletkor;
            this.onRendelkezikE = onRendelkezikE;
        }

        public valasz(int id, string nev, bool nem, int eletkor, bool onRendelkezikE, string marka, string modell, int szekKora, int suly, string szine, string ulesTipus, int akkumlatorokSzama, int maxSebesseg, bool rendelkezikExtrakkal, bool pohartarto, bool tomorgumi, bool ulesmagasitas, bool ulesdontes)
        {
            this.id = id;
            this.nev = nev;
            this.nem = nem;
            this.eletkor = eletkor;
            this.onRendelkezikE = onRendelkezikE;
            this.marka = marka;
            this.modell = modell;
            this.szekKora = szekKora;
            this.suly = suly;
            this.szine = szine;
            this.ulesTipus = ulesTipus;
            this.akkumlatorokSzama = akkumlatorokSzama;
            this.maxSebesseg = maxSebesseg;
            this.rendelkezikExtrakkal = rendelkezikExtrakkal;
            this.pohartarto = pohartarto;
            this.tomorgumi = tomorgumi;
            this.ulesmagasitas = ulesmagasitas;
            this.ulesdontes = ulesdontes;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public bool Nem { get => nem; set => nem = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public bool OnRendelkezikE { get => onRendelkezikE; set => onRendelkezikE = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int SzekKora { get => szekKora; set => szekKora = value; }
        public int Suly { get => suly; set => suly = value; }
        public string Szine { get => szine; set => szine = value; }
        public string UlesTipus { get => ulesTipus; set => ulesTipus = value; }
        public int AkkumlatorokSzama { get => akkumlatorokSzama; set => akkumlatorokSzama = value; }
        public int MaxSebesseg { get => maxSebesseg; set => maxSebesseg = value; }
        public bool RendelkezikExtrakkal { get => rendelkezikExtrakkal; set => rendelkezikExtrakkal = value; }
        public bool Pohartarto { get => pohartarto; set => pohartarto = value; }
        public bool Tomorgumi { get => tomorgumi; set => tomorgumi = value; }
        public bool Ulesmagasitas { get => ulesmagasitas; set => ulesmagasitas = value; }
        public bool Ulesdontes { get => ulesdontes; set => ulesdontes = value; }

        public override string ToString()
        {
            return (nev +" "+ eletkor+" "+"éves");
        }
    }
}
