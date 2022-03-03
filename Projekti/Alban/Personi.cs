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
        private string Email { get; set; }

        protected Personi(string emri, string mbiemri, string email)
        {
            if(emri == null || emri.Trim() == "")
            {
                throw new ProjektiException("Emri nuk lejohet te jete i zbrazet!");
            }
            if(mbiemri == null || mbiemri.Trim() == "")
            {
                throw new ProjektiException("Mbiemri nuk lejohet te jete i zbrazet!");
            }
            if(email == null || email.Trim() == "")
            {
                throw new ProjektiException("Email nuk lejohet te jete i zbrazet!");
            }
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
        }

        public override string ToString()
        {
            return this.Emri + " " + this.Mbiemri + " -- " + this.Email;
        }

        public bool krahasimi(Object obj)
        {
            if(obj != null)
            {
                if(obj is Personi)
                {
                    Personi p = (Personi)obj;
                    return p.Emri == this.Emri && p.Mbiemri == this.Mbiemri;
                }
            }
            return false;
        }

    }
}
