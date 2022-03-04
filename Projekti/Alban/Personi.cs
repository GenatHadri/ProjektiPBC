using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class Personi
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        protected string Mbiemri { get; set; }
        protected string Email { get; set; }

        protected Personi(int id, string emri, string mbiemri, string email)
        {
            if (id < 0)
            {
                throw new ProjektiException("Formati i ID-se eshte gabim!");
            }
            if (emri == null || emri.Trim() == "")
            {
                throw new ProjektiException("Emri nuk lejohet te jete i zbrazet!");
            }
            if (mbiemri == null || mbiemri.Trim() == "")
            {
                throw new ProjektiException("Mbiemri nuk lejohet te jete i zbrazet!");
            }
            if (email == null || email.Trim() == "")
            {
                throw new ProjektiException("Email nuk lejohet te jete i zbrazet!");
            }
            this.Id = id;
            this.Emri = emri;
            this.Mbiemri = mbiemri;
            this.Email = email;
        }

        public override string ToString()
        {
            return Id + " : " + Emri + " " + Mbiemri + " - " + Email;
        }

        public override bool Equals(Object obj)
        {
            if (obj != null)
            {
                if (obj is Personi)
                {
                    Personi p = (Personi)obj;
                    return p.Id == Id;
                }
            }
            return false;
        }

    }
}
