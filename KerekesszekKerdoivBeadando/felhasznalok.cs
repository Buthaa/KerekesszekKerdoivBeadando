using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerekesszekKerdoivBeadando
{
    class felhasznalok
    {
        int id;
        string felhasznalonev;
        string jelszo;

        public felhasznalok(int id, string felhasznalonev, string jelszo)
        {
            this.id = id;
            this.felhasznalonev = felhasznalonev;
            this.jelszo = jelszo;
        }

        public int Id { get => id; set => id = value; }
        public string Felhasznalonev { get => felhasznalonev; set => felhasznalonev = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
    }
}
