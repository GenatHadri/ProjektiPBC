using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Fidan
{
    internal class Vlersimi
    {
       private int Nota { get; set; }
        public Tema t {get; set; }

        public Studenti Studenti;
        public Vlersimi(Studenti studenti, Tema t , int Nota)
        {
          
            if (studenti == null)
            {
                throw new ProjektiException("studenti eshte null");

            }
            if (t == null)
            {
                throw new ProjektiException("tema eshte null");
            }
            if (Nota < 5 || Nota > 10)
            {
                throw new ProjektiException("nota eshte shenuar gabim");
            }
            this.Studenti = studenti;
            this.t = t;
            this.Nota = Nota;
        }
    }
}
