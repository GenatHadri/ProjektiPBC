﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public abstract class Personi
    {
        public string Emri { get; set; }
        protected string Mbiemri { get; set; }
        protected string Email { get; set; }

        protected Personi(string emri, string mbiemri, string email)
        {
            if(emri == null || emri.Trim() == "")
            {
                throw new ProjektiException("Emri eshte null!");
            }
            if(mbiemri == null || mbiemri.Trim() == "")
            {
                throw new ProjektiException("Email eshte null!");
            }
            if(email == null || email.Trim() == "")
            {
                throw new ProjektiException("Email eshte null!");
            }
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
        }

        public string toString()
        {
            return Emri + " " + Mbiemri + " - " + Email;
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
