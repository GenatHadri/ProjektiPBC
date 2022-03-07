using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Kerkesa
    {
        private int Id;
        private Profesori profesori;
        private Studenti studenti;
        private Tema tema;

        public Kerkesa(int Id, Profesori profesori, Studenti studenti, Tema tema)
        {
            if(profesori == null)
            {
                throw new ProjektiException("Profesori eshte null!");
            }
            if(studenti == null)
            {
                throw new ProjektiException("Studenti eshte null!");
            }
            if(tema == null)
            {
                throw new ProjektiException("Tema eshte null!");
            }
            if (Id < 0)
            {
                throw new ProjektiException("Id-ja e kerkeses nuk munde te jete negative!");
            }
            this.Id = Id;
            this.profesori = profesori;
            this.studenti = studenti;
            this.tema = tema;
        }

        public Profesori Profesori { get => profesori; set => profesori = value; }
        public int Id1 { get => Id; set => Id = value; }
        internal Tema Tema { get => tema; set => tema = value; }
        internal Studenti Studenti { get => studenti; set => studenti = value; }

        public override string ToString()
        {
            return "Studenti " + this.studenti.Emri1 + " " + this.studenti.Mbiemri1 +$" ka paraqitur kerkesen per zgjedhjen e temes \"{this.tema.Emri1}\"!";
        }

        public string toString()
        {
            return this.Id + ";" + this.profesori.Id1 + ";" + this.studenti.Id1 + ";" + this.tema.Emri1;
        }
    }
}
