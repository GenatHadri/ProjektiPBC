using Projekti.Rilind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Takimet
    {
        private Kerkesa kerkesa;
        private int nrTakimeve;

        public Takimet(Kerkesa kerkesa, int nrTakimeve, List<Shqyretimi> shqyretimet)
        {
            for (int i = 0; i < shqyretimet.Count; i++)
            {
                if (kerkesa == shqyretimet[i].Kerkesa && shqyretimet[i].Vendimi1 == false)
                {
                    throw new ProjektiException($"Takimet me studentin {kerkesa.Studenti.Emri1} {kerkesa.Studenti.Mbiemri1} nuk mund te zhvillohen per arsye se i " +
                        "eshte anuluar kerkesa nga komisioni!");
                }
            }
            if(nrTakimeve < 0 || nrTakimeve > 12)
            {
                throw new ProjektiException("Format i gabuar i numrit te takimeve!");
            }
            this.Kerkesa = kerkesa;
            this.NrTakimeve = nrTakimeve;
        }

        public int NrTakimeve { get => nrTakimeve; set => nrTakimeve = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }



        public override string ToString()
        {
            return "Profesori " + this.Kerkesa.Profesori.Emri1 + $" ka mbajtur {NrTakimeve} me studentin {this.Kerkesa.Studenti.Emri1}";
        }

        public string toString()
        {
            //public Takimet(Kerkesa kerkesa, int nrTakimit, List<Shqyretimi> shqyretimet)
            return this.Kerkesa.Id1 + ";" + this.nrTakimeve;
        }
    }
}
