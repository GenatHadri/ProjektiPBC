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
            Lenda l1 = new Lenda("183209", "Shkenca Kompjuterike1", 5);
            Lenda l2 = new Lenda("234034", "Web Technologies and Services", 5);
            Studenti s1 = new Studenti(181943836, "Genat", "Hadri", "gh43836@ubt-uni.net", "Shki", false, new Lenda[] { l1, l2});

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(s1);
        }
    }
}
