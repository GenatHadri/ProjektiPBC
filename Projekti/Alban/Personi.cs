using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class Personi
    {
        private string Emri { get; set; }
        private string Mbiemri { get; set; }

        protected Personi(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }

    }
}
