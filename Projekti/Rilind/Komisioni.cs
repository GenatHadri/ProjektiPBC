using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    class Komisioni
    {
        private int Id;
        List<Profesori> profesorat = new List<Profesori>();
        private Profesori p1;
        private Profesori p2;
        private Profesori p3;
        private Random rnd = new Random();

        public Komisioni(int Id, List<Profesori> profesorat)
        {
        Function:
            this.profesorat = profesorat;
            p1 = profesorat[rnd.Next(0, profesorat.Count)];
            p2 = profesorat[rnd.Next(0, profesorat.Count)];
            p3 = profesorat[rnd.Next(0, profesorat.Count)];

            if (p1 == p2 || p2 == p3 || p3 == p1)
            {
                goto Function;
            }
            this.Id = Id;
        }

        public Profesori P1 { get => p1; set => p1 = value; }
        public Profesori P2 { get => p2; set => p2 = value; }
        public Profesori P3 { get => p3; set => p3 = value; }
        public int Id1 { get => Id; set => Id = value; }

        public override string ToString()
        {
            return "Komisoni eshte i perbere nga profesoret: " + this.p1.Emri1 + " " + this.p1.Mbiemri1 + ", " + this.p2.Emri1 + " " + this.p2.Mbiemri1 + ", " + this.p3.Emri1 + " " + this.p3.Mbiemri1;
        }

        public string toString()
        {
            return this.Id + ";" + this.P1.Id1 + ";" + this.P2.Id1 + ";" + this.P3.Id1;
        }

    }
}
