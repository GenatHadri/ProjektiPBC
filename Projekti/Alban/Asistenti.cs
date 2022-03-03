using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Asistenti:StafiAkademik
    {
        private int Pervoja { get; set; }

        public Asistenti(int id, string emri, string mbiemri, string email, string nrTel, int angazhimi) : base(id, emri, mbiemri, email, nrTel, angazhimi)
        {
        }


    }
}
