using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsna_aplikacija
{
    internal class Osoba
    {
        private string ime;
        private string prezime;
        private string uloga;
        private string aktivnost;

        public string Ime {get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Uloga { get => uloga; set => uloga = value; }
        public string Aktivnost { get => aktivnost; set => aktivnost = value; }
    }
}
