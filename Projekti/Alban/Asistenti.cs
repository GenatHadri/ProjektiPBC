using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Asistenti:StafiAkademik
    {
        private int Pervoja;

        public int _Pervoja { get { return Pervoja; } set{ Pervoja = value; } }

        public Asistenti(int Pervoja, string Emri, string Mbiemri, string Email, int ID, int Angazhimi, string NrTel) : base(ID, Emri, Mbiemri,  Email, NrTel,Angazhimi)
        {
            this.Pervoja = Pervoja;
            
        }
        public override string ToString()
        {
            return $"{ this.Emri} { this.Mbiemri} Email:{this.Email}";
        }
    }
}
