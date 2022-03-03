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
        Profesori Profesori { get; set; }
        Studenti Studenti { get; set; }

        public Tema(Profesori p, Studenti s, string Emri)
        {
            if (Emri == null || Emri.Trim() == "")
            {
                throw new ProjektiException("Emri i temes eshte null!");
            }
            this.Profesori = p;
            this.Studenti = s;
            this.Emri = Emri;
            TemaEcts = 12;
        }

        //Lenda eshte perdor per ti caktuar ects per validimin nese ka mundesi me paraqite temen

    }
}
