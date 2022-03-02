using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Tema
    {
        private string _Titulli;
        private Mentori _Mentori;
        private DateTime _Afati;

        public string Titulli { get { return _Titulli; } }
        public Mentori Mentori { get { return _Mentori; } }
        public DateTime Afati { get { return _Afati; } }


        public Tema(string titulli, Mentori mentori, DateTime afati)
        {
            _Titulli = titulli;
            _Mentori = mentori;
            _Afati = afati;
        }

        public override string ToString()
        {
            return $"{this.Titulli} - {this.Mentori.Emri} - {this.Afati.ToString("yyyy/MM/dd")}";
        }
    }
}
