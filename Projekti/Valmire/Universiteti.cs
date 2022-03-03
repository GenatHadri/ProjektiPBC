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
        Departamenti Departamenti { get; set; }
        List<Departamenti> Departamentet { get; set; }

        public Universiteti(string emriUniversitetit, string email, Departamenti departamenti)
        {
            if (emriUniversitetit == null && emriUniversitetit.Trim() == "")
            {
                throw new ProjektiException("Emri i universitetit eshte null!");
            }
            if (!Departamentet.Contains(departamenti))
            {
                throw new ProjektiException("Universiteti nuk e permban departamentin!");
            }

            if (email == null && email.Trim() == "")
            {
                throw new ProjektiException("Email eshte null!");
            } 

            EmriUniversitetit = emriUniversitetit;
            Email = email;
           
        }
        public string ToString()
        {
            return $"{this.GetType().Name}Universiteti :{this.EmriUniversitetit} Departamentet: {this.Departamenti} \nEmail:{this.Email} ";
        }

        public override bool Equals(object obj)
        {
            return obj is Universiteti universiteti && EmriUniversitetit == universiteti.EmriUniversitetit;
        }

        public List<Departamenti> departamentet = new List<Departamenti>()
        {
            new Departamenti (1234, "Matematike", "math@uni-pr.edu","Shkenncat Kompjuterike "),
            new Departamenti (1235, "Matematike", "math@uni-pr.edu","Matematik e Pergjithshme "),
            new Departamenti (1236, "Matematike", "math@uni-pr.edu","Matematike Financiare "),
            new Departamenti (1238, "Kimi", "kimi@uni-pr.edu","Kimi arsimore  "),
            new Departamenti (1238, "Kimi", "kimi@uni-pr.edu","Kimi e pergjithshme "),

        };


        public int Fillo()
        {

            Console.WriteLine();

            Console.WriteLine("\t\t >< Shtyp 1 per te pare departamentet qe i perman universiteti: ");

            int pergjigjia = int.Parse(Console.ReadLine());

            return pergjigjia;
        }
        private void ListaDepartamenteve()
        {
            Console.WriteLine("\nDepartamentet ne universitetin tone jane:");
            foreach (var d in Departamentet)
            {
                Console.WriteLine($"\nDepartamenti: {d.EmriDepartamentit},  Drejtimi {d.Drejtimi}");
            }

            Console.Clear();

        }


    }
}
