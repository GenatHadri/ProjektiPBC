using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Lenda
    {
        public string Kodi { get; set; }
        public string Emri { get; set; }
        public int ECTS { get; set; }
        public int Nota { get; set; }

        public Lenda(string kodi, string emri, int eCTS)
        {
            this.Kodi = kodi;
            this.Emri = emri;
            this.ECTS = eCTS;
        }

        public override string ToString()
        {
            return $"Lenda {this.Emri} ka {this.ECTS} ECTS";
        }

        public override bool Equals(object obj)
        {
            return obj is Lenda lenda &&
                   Kodi == lenda.Kodi;
        }
    }
}
