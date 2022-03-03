using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Departamenti
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public int IdProfesorit { get; set; }
        public string EmriDepartamentit  { get; set; }
        public string Email { get; set; }


        public Departamenti(string emri, string email)
        {
            Emri=emri;
            Email=email;
        }

        Stafi  Stafi { get; set; }
        public string Drejtimi { get; set; }
        


    }
}
