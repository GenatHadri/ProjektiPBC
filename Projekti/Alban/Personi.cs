using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Personi
    {
        protected string Emri;
        protected string Mbiemri;
        public string _Emri { get { return Emri; } set { Emri = value; } }
        public string _Mbiemri { get { return Mbiemri; } set { Mbiemri = value; } }
    }
}
