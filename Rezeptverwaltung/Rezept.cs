using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezeptverwaltung
{
    class Rezept
    {
        private string Rname;
        private decimal Rpersonen;
        private List<Zutat> Rzutaten;
        private string Rzubereitung;
        private decimal Rdauer;
        private List<string> Rkategorie;
        private string Rnotiz;
        private string RBildPfad;

        public Rezept(string n, decimal p, List<Zutat> zut, string zub, decimal d, List<string> hk, string no, string path)
        {
            Rname = n;
            Rpersonen = p;
            Rzutaten = zut;
            Rzubereitung = zub;
            Rdauer = d;
            Rkategorie = hk;
            Rnotiz = no;
            RBildPfad = path;
        }

        public Rezept()
        {
            Rname = "Neues Rezept";
            Rpersonen = 0;
            Rzutaten = null;
            Rzubereitung = "";
            Rdauer = 0;
            Rkategorie = null;
            Rnotiz = "";
            RBildPfad = "";
        }



        public string GetSetRName
        {
            get { return Rname; }
            set { Rname = value; }
        }

        public decimal GetSetRpersonen
        {
            get { return Rpersonen; }
            set { Rpersonen = value; }
        }

        public List<Zutat> GetSetRzutaten
        {
            get { return Rzutaten; }
            set { Rzutaten = value; }
        }

        public string GetSetRzubereitung
        {
            get { return Rzubereitung; }
            set { Rzubereitung = value; }
        }

        public decimal GetSetRdauer
        {
            get { return Rdauer; }
            set { Rdauer = value; }
        }

        public List<string> GetSetRkategorie
        {
            get { return Rkategorie; }
            set { Rkategorie = value; }
        }

        public string GetSetRNotiz
        {
            get { return Rnotiz; }
            set { Rnotiz = value; }
        }

        public string GetSetRBildPath
        {
            get { return RBildPfad; }
            set { RBildPfad = value; }
        }

    }
}