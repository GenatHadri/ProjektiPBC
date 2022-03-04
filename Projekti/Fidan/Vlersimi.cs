using Projekti.Rilind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Fidan
{
    internal class Vlersimi
    {
        private int Nota;
        private Tema tema;
        private Komisioni komisioni;
        private Kerkesa kerkesa;
        public Vlersimi(Komisioni komisioni, Kerkesa kerkesa, int nota)
        {
            if (Nota1 < 5 || Nota1 > 10)
            {
                throw new ProjektiException("nota eshte shenuar gabim");
            }
            this.tema = tema;
            this.Nota1 = Nota1;
        }
       
        public int Nota1 { get => Nota; set => Nota = value; }
        internal Tema Tema { get => tema; set => tema = value; }
        internal Komisioni Komisioni { get => komisioni; set => komisioni = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }


    }
}

