using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class StafiAkademik:Personi
    {
        private string NrTel { get; set; }

        public StafiAkademik(int id, string emri, string mbiemri, string email, string nrTel) : base(id, emri, mbiemri, email)
        {
            if(id < 0)
            {
                throw new ProjektiException("Id nuk mund te jete me vlere me te vogel se 0!");
            }
            if(nrTel.Length < 12)
            {
                throw new ProjektiException("Formati i numrit te telefonit eshte gabim!");
            }
            this.Id = id;
            this.NrTel = nrTel;
        }

        public abstract int Angazhimi();

        public override string ToString()
        {
            return Id + base.ToString() + " me numer te telefonit: " + NrTel + " ka angazhimin " + Angazhimi() + "ore ";
        }

    }
}
