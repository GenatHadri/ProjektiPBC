using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Rilind
{
    internal class Vleresimi
    {
        private Komisioni komisioni;
        private Kerkesa kerkesa;
        private int Nota;

        public Vleresimi(Komisioni komisioni, Kerkesa kerkesa, int nota, List<Takimet> takimet)
        {
            if (kerkesa == null)
            {
                throw new ProjektiException("Kerkesa per paraqitjen e temes nuk eshte bere!");
            }
            for (int i = 0; i < takimet.Count; i++)
            {
                if (takimet[i].NrTakimeve != 12 && takimet[i].Kerkesa == kerkesa)
                {
                    throw new ProjektiException($"Per te bere vleresimin e temes se diplomes duhet te kryhen " +
                        $"gjithsej 12 takime ne mes te profesorit {kerkesa.Profesori.Emri1} {kerkesa.Profesori.Mbiemri1}" +
                        $" dhe studentit {kerkesa.Studenti.Emri1} {kerkesa.Studenti.Mbiemri1}!");
                    this.Nota = 0;
                }
                else
                {
                    this.Nota = nota;
                }
            }

            this.Komisioni = komisioni;
            this.Kerkesa = kerkesa;
        }

        public int Nota1 { get => Nota; set => Nota = value; }
        internal Komisioni Komisioni { get => komisioni; set => komisioni = value; }
        internal Kerkesa Kerkesa { get => kerkesa; set => kerkesa = value; }

        public override string ToString()
        {
            return "Komisioni me anetaret " + this.komisioni.P1.Emri1 + " " + this.komisioni.P1.Mbiemri1 + ", " +
                this.komisioni.P2.Emri1 + " " + this.komisioni.P2.Mbiemri1 + ", " +
                this.komisioni.P3.Emri1 + " " + this.komisioni.P3.Mbiemri1 + ", "
                + (this.Nota == 0 ? $"nuk ka vleresuar studentin " +
                $"{this.kerkesa.Studenti.Emri1} {this.kerkesa.Studenti.Mbiemri1}" +
                $" per arsye se nuk ka perfunduar 12 takime!" : $"ka vleresuar studentin " +
                $"{this.kerkesa.Studenti.Emri1} {this.kerkesa.Studenti.Mbiemri1} me noten {this.Nota}!");
        }

        public string toString()
        {
            return this.komisioni.Id1 + ";" + this.kerkesa.Id1 + ";" + this.Nota;
        }
    }
}
