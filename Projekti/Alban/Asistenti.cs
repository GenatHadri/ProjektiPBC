using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Asistenti : StafiAkademik
    {
        private string LlojiUshtrimeve { get; set; }

        public Asistenti(int id, string emri, string mbiemri, string email, string nrTel, int angazhimi, string llojiUshtrimeve) : base(id, emri, mbiemri, email, nrTel)
        {
            if (llojiUshtrimeve == null || llojiUshtrimeve.Trim() == "")
            {
                throw new ProjektiException("Angazhimi i asistentit eshte null!");
            }
            this.LlojiUshtrimeve = llojiUshtrimeve;
        }

        public override int Angazhimi()
        {
            return 20;
        }

        public override string ToString()
        {
            return "Asistenti " + base.ToString() + " me llojin e ushtrimeve " + LlojiUshtrimeve;

        }
    }
}
