using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Universiteti
    {
        private int Id { get { return Id; } }
        private string EmriUniversitetit { get; set; }
        public string Email { get; set; }
        Departamenti departamenti { get; set; }

        public Universiteti(Departamenti departamenti)
        {
            this.departamenti = departamenti;
        }

        public Universiteti(string emriUniversitetit, string email, Departamenti departamenti)
        {
         
            EmriUniversitetit = emriUniversitetit;
            Email = email;
            this.departamenti = departamenti;


        }
    }
}
