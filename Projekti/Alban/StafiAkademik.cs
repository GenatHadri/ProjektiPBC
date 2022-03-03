using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class StafiAkademik:Personi
    {
        private int Id { get; set; }
        private string NrTel { get; set; }
        private int Angazhimi { get; set; }

        public StafiAkademik(int id, string emri, string mbiemri, string email, string nrTel, int angazhimi) : base(emri, mbiemri, email)
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
            this.Angazhimi = angazhimi;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} - {base.ToString()} ka angazhimin {this.Angazhimi}";
        }

    }
}
