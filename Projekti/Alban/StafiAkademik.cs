using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class StafiAkademik : Personi
    {
        private string NrTel;

        public StafiAkademik(int id, string emri, string mbiemri, string email, string nrTel) : base(id, emri, mbiemri, email)
        {
            if (nrTel.Length < 12)
            {
                throw new ProjektiException("Formati i numrit te telefonit eshte gabim!");
            }
            this.Id1 = id;
            this.NrTel = nrTel;
        }

        public string NrTel1 { get => NrTel; set => NrTel = value; }

        public abstract int Angazhimi();

        public override string ToString()
        {
            return base.ToString() + ", me numer te telefonit: " + this.NrTel;
        }

    }
}
