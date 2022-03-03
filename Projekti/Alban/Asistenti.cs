using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Asistenti : StafiAkademik
    {
        private int Pervoja;

        public int _Pervoja { get { return Pervoja; } set { Pervoja = value; } }

        public Asistenti(int id, string emri, string mbiemri, string email, string nrTel, int angazhimi, int pervoja) : base(id, emri, mbiemri, email, nrTel, angazhimi)
        {
<<<<<<< HEAD
            this.Pervoja = Pervoja;

=======
            if (pervoja < 0)
            {
                throw new ProjektiException("Pervoja e asistentit nuk lejohet te jete me e vogel se 0!");
            }
            this.Pervoja = pervoja;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ka pervoje {this.Pervoja} vjeqare";
>>>>>>> b0511363c83aa4717543c4a13b4b3a74268a0614
        }
    }
}
