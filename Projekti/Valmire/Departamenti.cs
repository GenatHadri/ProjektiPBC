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
        
        public string EmriDepartamentit  { get; set; }
        public string Email { get; set; }
        Profesori Profesoi { get; set; }

        List<Profesori> Profesoret = new List<Profesori>();
        Stafi Stafi { get; set; }
        public string Drejtimi { get; set; }

        public Departamenti(int id, string emriDepartamentit, string email, string drejtimi, Profesori profesori)
        {

            if (emriDepartamentit == null && emriDepartamentit.Trim() == "")
            {
                throw new ProjektiException("Emri i departamentit eshte null!");
            }
            if (profesori == null && emriDepartamentit.Trim() == "")
            {
                throw new ProjektiException("Emri i profesorit eshte null!");
            }
            if (!Profesoret.Contains(profesori))
            {
                throw new ProjektiException("Ky Profesor nuk eshte pjese e ketij departamenti !");
            }
            if (email == null && email.Trim() == "")
            {
                throw new ProjektiException("Email eshte null!");
            }
            
            
        }
       
    }
}
