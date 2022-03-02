using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Departamenti
    {
        public string Emri { get; set; }
        public string Email { get; set; }

        public Departamenti(string emri, string email)
        {
            Emri=emri;
            Email=email;
        }

    }
}
