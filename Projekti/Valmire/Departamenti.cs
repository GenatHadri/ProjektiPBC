using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Departamenti
    {
        private int Id { get; set; }
        public int IdProfesorit { get; set; }
        public string EmriDepartamentit  { get; set; }
        public string Email { get; set; }

        Stafi  Stafi { get; set; }
        public string Drejtimi { get; set; }

        public Departamenti(int id, string emriDepartamentit, string email, string drejtimi): base()
        {
            
            if ( emriDepartamentit == null && emriDepartamentit.Trim() == "")
            {
                throw new ProjektiException("Emri i departamentit eshte null!");
            }
            if (email == null && email.Trim() == "")
            {
                throw new ProjektiException("Email eshte null!");
            }
            this.Id = id;
            
        }
       
    }
}
