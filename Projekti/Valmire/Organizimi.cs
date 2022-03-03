using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti.Valmire
{
    internal class Organizimi 
    {
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
        //private void ListaDepartamenteve()
        //{
        //    Console.WriteLine("\nDepartamentet ne universitetin tone jane:");
        //    foreach (var d in Departamenti)
        //    {
        //        Console.WriteLine($"\nDepartamenti: {d},  Drejtimi {d.Drejtimi}");
        //    }

        //    Console.Clear();

        //}
    }
}
