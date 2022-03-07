using Projekti.Rilind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Tema
    {
        private string Emri;
        private int TemaEcts;

        public Tema(string Emri)
        {
            if (Emri == null || Emri.Trim() == "")
            {
                throw new ProjektiException("Emri i temes eshte null!");
            }
            this.Emri1 = Emri;
            TemaEcts1 = 12;
        }

        public string Emri1 { get => Emri; set => Emri = value; }
        public int TemaEcts1 { get => TemaEcts; set => TemaEcts = value; }

        public override string ToString()
        {
            return "Tema: " + this.Emri + " ka " + this.TemaEcts1 + " Ects";
        }

        public string toString()
        {
            return this.Emri + ";" + this.TemaEcts1;
        }
    }
}
