using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class Personi
    {
        private int Id;
        private string Emri;
        private string Mbiemri;
        private string Email;

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
            this.Id1 = id;
            this.Emri1 = emri;
            this.Mbiemri1 = mbiemri;
            this.Email1 = email;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Emri1 { get => Emri; set => Emri = value; }
        public string Mbiemri1 { get => Mbiemri; set => Mbiemri = value; }
        public string Email1 { get => Email; set => Email = value; }

        public override string ToString()
        {
            return this.Id + " : " + this.Emri + " " + this.Mbiemri + " - " + this.Email;
        }

        public override bool Equals(Object obj)
        {
            if (obj != null)
            {
                if (obj is Personi)
                {
                    Personi p = (Personi)obj;
                    return p.Id1 == Id1;
                }
            }
            return false;
        }

    }
}
