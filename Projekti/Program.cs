using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Departamenti d1 = new Departamenti(152800, "Biologji", "biologji@uni-pr.edu", "Arsimor");
            Departamenti d2 = new Departamenti(152801, "Matematike", "matematike@uni-pr.edu", "Shkencat Kompjuterike ");
            Departamenti d3 = new Departamenti(152802, "Matematike", "matematike@uni-pr.edu", "Matematik financiare");
            Departamenti d4 = new Departamenti(152802, "Matematike", "matematike@uni-pr.edu", "Matematik e pergjithshme ");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Lenda l1 = new Lenda("183209", "Shkenca Kompjuterike1", 5);
            Lenda l2 = new Lenda("234034", "Web Technologies and Services", 5);
            Studenti s1 = new Studenti(181943836, "Genat", "Hadri", "gh43836@ubt-uni.net", "Shki", true, new Lenda[] { l1, l2});

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(s1);
             
=======
>>>>>>> b0511363c83aa4717543c4a13b4b3a74268a0614
        }
    }
}