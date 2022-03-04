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
            if(vendimi == null)
            {
                throw new ProjektiException("Vendimi eshte null!");
            }
            this.Komisioni = komisioni;
            this.Kerkesa = kerkesa;
        }

        public void AnuloKerkesen(Kerkesa kerkesa)
        {
            if(Vendimi == false)
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
            return "Komisioni me anetaret " + this.komisioni.P1.Emri + ", " + this.komisioni.P2.Emri + ", " + this.komisioni.P3.Emri;
        }
    }
}
