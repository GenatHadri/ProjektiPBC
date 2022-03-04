using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Kerkesa
    {
        private Profesori profesori;
        private Studenti studenti;
        private Tema tema;

        public Kerkesa(Profesori profesori, Studenti studenti, Tema tema)
        {
            this.Profesori = profesori;
            this.Studenti = studenti;
            this.Tema = tema;
        }

        public Profesori Profesori { get => profesori; set => profesori = value; }
        internal Tema Tema { get => tema; set => tema = value; }
        internal Studenti Studenti { get => studenti; set => studenti = value; }

        public override string ToString()
        {
            return "Studenti " + this.Studenti.Emri + " ka paraqitur kerkesen per te zgjedhjen e temes "
                + this.Tema.Emri1;
        }
    }
}
