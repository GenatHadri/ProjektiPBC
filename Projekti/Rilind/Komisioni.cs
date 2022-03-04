using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    class Komisioni
    {
        List<Profesori> profesorat = new List<Profesori>();
        private Profesori p1;
        private Profesori p2;
        private Profesori p3;
        private Random rnd = new Random();

        public Komisioni(List<Profesori> profesorat)
        {
            int[] arr = GjejPoziten();
            P1 = profesorat[arr[0]];
            P2 = profesorat[arr[1]];
            P3 = profesorat[arr[2]];
            this.profesorat = profesorat;
        }

        public Profesori P1 { get => p1; set => p1 = value; }
        public Profesori P2 { get => p2; set => p2 = value; }
        public Profesori P3 { get => p3; set => p3 = value; }

        private int[] GjejPoziten()
        {
            Random random = new Random();
            int[] arr = new int[3];

            arr[0] = random.Next(0, this.profesorat.Count);
            arr[1] = random.Next(0, this.profesorat.Count);
            if (arr[1] == arr[2])
            {
                arr[1] = random.Next(0, this.profesorat.Count);
            }
            arr[2] = random.Next(0, this.profesorat.Count);
            if (arr[1] == arr[2])
            {
                arr[2] = random.Next(0, this.profesorat.Count);
            }
            if (arr[2] == arr[0])
            {
                arr[2] = random.Next(0, this.profesorat.Count);
            }
            return arr;
        }

        //public override string ToString()
        //{
        //    return "Komisoni eshte i perbere nga profesoret: " + this.p1.Emri + ", " + this.p2.Emri + ", " + this.p3.Emri;
        //}

        public string ToString()
        {
            return this.P1.Emri + ";" + this.P2.Emri + ";" + this.P3.Emri;
        }

    }
}
