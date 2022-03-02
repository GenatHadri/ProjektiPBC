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

    }
}
