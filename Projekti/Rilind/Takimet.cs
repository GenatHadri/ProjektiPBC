using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Takimet
    {
        Studenti studenti { get; set; }
        Profesori profesori { get; set; }
        DateTime data { get; set; }

        public Takimet(Studenti studenti, Profesori profesori, DateTime data)
        {
            this.studenti = studenti;
            this.profesori = profesori;
            this.data = data;
        }


    }
}
