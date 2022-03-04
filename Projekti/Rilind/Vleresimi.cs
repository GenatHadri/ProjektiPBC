using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Vleresimi
    {
        private Komisioni komisioni;
        private Kerkesa kerkesa;
        private int Nota;

        public Vleresimi(Komisioni komisioni, Kerkesa kerkesa, int nota)
        {
            if(kerkesa == null)
            {
                throw new ProjektiException("Kerkesa per paraqitjen e temes nuk eshte bere!");
            }

            this.Komisioni = komisioni;
            this.Kerkesa = kerkesa;
        }

        public int Nota1 { get => Nota; set => Nota = value; }
        internal Komisioni Komisioni { get => komisioni; set => komisioni = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }

        public override string ToString()
        {
            return "Komisioni me anetaret " + this.komisioni.P1.Emri + ", " + this.komisioni.P2.Emri + ", "
                + this.komisioni.P3.Emri + " ka vleresuar studentin " + this.kerkesa.Studenti.Emri 
                + $"me noten {this.Nota}";
        }
    }
}
