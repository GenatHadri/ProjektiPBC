using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Shqyretimi
    {
        private Komisioni komisioni;
        private Kerkesa kerkesa;
        private bool Vendimi;

        public Shqyretimi(Komisioni komisioni, Kerkesa kerkesa, bool vendimi)
        {
            if (kerkesa == null)
            {
                throw new ProjektiException("Kerkesa eshte null!");
            }
            if (komisioni == null)
            {
                throw new ProjektiException("Komisioni eshte null!");
            }
            this.komisioni = komisioni;
            this.kerkesa = kerkesa;
            this.Vendimi = vendimi;
        }

        public void AnuloKerkesen(Kerkesa kerkesa)
        {
            if (Vendimi == false)
            {
                kerkesa = this.kerkesa;
                kerkesa.Tema = null;
            }
        }

        public bool Vendimi1 { get => Vendimi; set => Vendimi = value; }
        internal Komisioni Komisioni { get => komisioni; set => komisioni = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }

        public override string ToString()
        {
            return "Komisioni me anetaret: " + this.komisioni.P1.Emri1 + " " + this.komisioni.P1.Mbiemri1 + ", "
                + this.komisioni.P2.Emri1 + " " + this.komisioni.P2.Mbiemri1 + ", "
                + this.komisioni.P3.Emri1 + " " + this.komisioni.P3.Mbiemri1 
                + $" ka vendosur qe te {(this.Vendimi?"pranoj":"anuloj")} kerkesen per zgjedhjen e temes se diplomes nga "
                    + this.kerkesa.Studenti.Emri1 + " " + this.kerkesa.Studenti.Mbiemri1 + "!";
        }

        public string toString()
        {
            return this.komisioni.Id1 + ";" + this.kerkesa.Id1 + ";" + (this.Vendimi ? "Pranohet" : "Anulohet");
        }

    }
}
