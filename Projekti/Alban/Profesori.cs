using Projekti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Profesori : StafiAkademik
    {
        private string GradaAkademike { get; set; }

        public Profesori(int id, string emri, string mbiemri, string email, string nrTel, string grada) : base(id, emri, mbiemri, email, nrTel)
        {
            if (grada == null || grada.Trim() == "")
            {
                throw new ProjektiException("Grada e profesorit eshte e zbrazet!");
            }
            this.GradaAkademike = grada;
        }


        public override int Angazhimi()
        {
            return 24;
        }

        public override string ToString()
        {
            return base.ToString() + ", me grade akademike " + GradaAkademike + " ka angazhim " + Angazhimi() + " ore!";
        }

        public string toString()
        {
            return this.Id1 + ";" + this.Emri1 + ";" + this.Mbiemri1 + ";" + this.Email1 + ";" + this.NrTel1 + ";" + this.GradaAkademike;
        }
    }
}
