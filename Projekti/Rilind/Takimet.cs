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

        public Takimet(Kerkesa kerkesa, int nrTakimit)
        {
            if (nrTakimeve < 0 || nrTakimeve > 12)
            {
                throw new ProjektiException("Duhet te mbahen 12 takime per te bere vleresimin e temes!");
            }
            this.Kerkesa = kerkesa;
            this.nrTakimeve = nrTakimit;
        }

        public int NrTakimeve { get => nrTakimeve; set => nrTakimeve = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }

        public override string ToString()
        {
            return "Profesori " + this.kerkesa.Profesori.Emri + $" ka mbajtur {nrTakimeve} me studentin {this.kerkesa.Studenti.Emri}";
        }
    }
}
