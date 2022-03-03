using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Program
    {

        public static List<Asistenti> asistentiList = new List<Asistenti>();
        static void Main(string[] args)
        {
           
            Asistenti asistenti=new Asistenti(2, "Bekim", "Gashi", "bg@gmail.com",732742, 20, "+38344332123");
            
           // Console.WriteLine(asistenti.ToString());
            Profesori p = new Profesori("MSc", "Filan", "fisteku", 142434, "ff@gmail.com", "+38344323123", 23, asistenti);
            Asistenti asistenti1 = new Asistenti(2, "Besi", "krasniqi", "bk@gmail.com", 9892742, 20, "+38349332678");
            Profesori p1 = new Profesori("MSc", "halil", "halili", 142434, "hh@gmail.com", "+38349323823", 23, asistenti1);


        }
    }
}
