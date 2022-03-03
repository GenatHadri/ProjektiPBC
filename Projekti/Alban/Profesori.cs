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
        private string Grada;

        public Profesori(int id, string emri, string mbiemri, string email, string nrTel, int angazhimi, string grada) : base(id, emri, mbiemri, email, nrTel, angazhimi)
        {
            if (grada == null || grada.Trim() == "")
            {
                throw new ProjektiException("Grada e profesorit eshte e zbrazet!");
            }
            this.Grada = grada;
        }

        public string _Grada { get { return Grada; } set { Grada = value; } }


        public override string ToString()
        {
            return $"{base.ToString()} ka graden {this.Grada}";
        }
    }
}
