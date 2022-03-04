using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Studenti:Personi
    {
        private string Departamenti { get; set; }

        public Studenti(int id, string emri, string mbiemri, string email, string departamenti) : base(id, emri, mbiemri, email)
        {
            if(departamenti == null || departamenti.ToString() == null)
            {
                throw new ProjektiException("Departamenti eshte null!");
            }
            this.Departamenti = departamenti;
        }

        //public Studenti(int id, string emri, string mbiemri, string email, string departamenti, List<Lenda> lendet)
        //{
        //    this.Departamenti = departamenti;
        //}

        //public bool MundTeParaqesTemen()
        //{
        //    int totalEcts = 0;
        //    for (int i = 0; i < lendet.Length; i++)
        //    {
        //        totalEcts += lendet[i].Ects;
                    
        //    }
        //    if(totalEcts > 50)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public override string ToString()
        {
            return "Studenti " + base.ToString() + ", departamenti: " + this.Departamenti;
        }

    }
}
