using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezeptverwaltung
{
    class Zutat
    {
        private string Zname;
        private string Zmenge;
        private string Zeinheit;

        public Zutat(string n, string m, string e)
        {
            Zname = n;
            Zmenge = m;
            Zeinheit = e;
        }

        public Zutat()
        {

        }

        public string GetSetZName
        {
            get { return Zname; }
            set { Zname = value; }
        }

        public string GetSetZmenge
        {
            get { return Zmenge; }
            set { Zmenge = value; }
        }

        public string GetSetZeinheit
        {
            get { return Zeinheit; }
            set { Zeinheit = value; }
        }

    }
}
