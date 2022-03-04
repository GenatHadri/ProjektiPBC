using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Lenda
    {
        public string Emri { get; set; }
        public int Ects { get; set; }
        private bool Obligative { get; set; }

        public Lenda(string emri, int ects, bool obligative)
        {
            if (emri == null)
            {
                throw new ProjektiException("Emri i lendes eshte null!");
            }
            if (ects < 0 || ects > 6)
            {
                throw new ProjektiException("Formati i ect-se se lendes eshte gabim!");
            }
            if (obligative == null)
            {
                throw new ProjektiException("Caktoni nese lenda eshte obligative!");
            }
            this.Obligative = obligative;
            this.Emri = emri;
            this.Ects = ects;
        }

        //public override string ToString()
        //{
        //    return Emri + " - " + Ects;
        //}

        public string toString()
        {
            return this.Emri + ";" + this.Ects;
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Lenda)
                {
                    Lenda l = (Lenda)obj;
                    return l.Emri == this.Emri && l.Ects == this.Ects;
                }
            }
            return false;
        }

    }
}
