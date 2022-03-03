using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Tema
    {
        private string Emri { get; set; }
        private int TemaEcts { get; set; }

         public Tema (string Emri)
        {
            if( Emri == null || Emri.Trim() == "")
            {
                throw new ProjektiException("Emri i temes eshte null!");
            }
            TemaEcts = 12;
            this.Emri = Emri;
        }
    }
}
