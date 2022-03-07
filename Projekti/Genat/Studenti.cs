using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Studenti : Personi
    {
        private string Departamenti { get; set; }

        public Studenti(int id, string emri, string mbiemri, string email, string departamenti) : base(id, emri, mbiemri, email)
        {
            if (departamenti == null || departamenti.ToString() == null)
            {
                throw new ProjektiException("Departamenti eshte null!");
            }
            this.Departamenti = departamenti;
        }

        public override string ToString()
        {
            return base.ToString() + ", departamenti: " + this.Departamenti;
        }

        public string toString()
        {
            return this.Id1 + ";" + this.Emri1 + ";" + this.Mbiemri1 + ";" + this.Email1 + ";" + this.Departamenti;
        }

    }
}
