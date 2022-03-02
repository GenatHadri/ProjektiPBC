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

        public string _Grada { get { return Grada; } set { Grada = value; } }


        public Profesori(string Grada, string Emri, string Mbiemri, int ID, string Email, string NrTel, int Angazhimi) : base(Emri, Mbiemri, ID, Email, NrTel)
        {
            if (Grada == null || Grada.Trim() == "")
            {
                throw new ProjektiException("Grada e profesorit eshte null!");
            }
            this.Grada = Grada;

        }
        public  string ToString()
        {
            return $"{ this.Grada}.{ this.Emri} { this.Mbiemri} Email:{this.Email}";
        }
    }
}
