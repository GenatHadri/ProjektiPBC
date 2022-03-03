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
        Profesori p1 { get; set; }
        Profesori p2 { get; set; }
        Profesori p3 { get; set; }
        Random rnd = new Random();

        public Komisioni()
        {
            int[] arr = GjejPoziten();
            p1 = profesorat[arr[1]];
            p2 = profesorat[arr[2]];
            p3 = profesorat[arr[3]];
        }

        private int[] GjejPoziten()
        {
            Random random = new Random();
            int[] arr = new int[3];

            arr[1] = random.Next(0, this.profesorat.Count);
            arr[2]= random.Next(0, this.profesorat.Count);
            if (arr[1] == arr[2])
            {
                arr[2] = random.Next(0, this.profesorat.Count);
            }
            arr[3] = random.Next(0, this.profesorat.Count);
            if (arr[2] == arr[3])
            {
                arr[3] = random.Next(0, this.profesorat.Count);
            }
            if (arr[3] == arr[1])
            {
                arr[3] = random.Next(0, this.profesorat.Count);
            }
            return arr;
        }

    }
}
