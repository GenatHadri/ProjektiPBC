using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Lenda
    {
        private string Emri { get; set; }
        private int Ects { get; set; }

        public Lenda(string emri, int ects)
        {
            if(Emri == null || Emri.Trim() == "")
            {
                throw new ProjektiException("Emri i lendes eshte null!");
            }
            if(ects < 0 || ects > 6)
            {
                throw new ProjektiException("Formati i ect-se se lendes eshte gabim!");
            }
            Emri = emri;
            Ects = ects;
        }

        public override string ToString()
        {
            return Emri + " - " + Ects;
        }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                if(obj is Lenda)
                {
                    Lenda l = (Lenda)obj;
                    return l.Emri == this.Emri && l.Ects == this.Ects;
                }
            }
            return false;
        }

    }
}
