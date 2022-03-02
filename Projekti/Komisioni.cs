using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaDiplomes.NewFolder;

namespace Projekti
{
    class Komisioni
    {
        Profesori profesori { get; set; }
        public Komisioni(Profesori p1, Profesori p2, Profesori p3)
        {
            if(p1 == p2 || p2 == p3 || p3 == p1)
            {
                throw new ProjektiException("Nuk mund te jene 2 ose 3 profesora te njejte ne komision!");
            }
        }
    }
}
