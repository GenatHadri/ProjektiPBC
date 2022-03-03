using Projekti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class Profesori : StafiAkademik
    {
        protected string Grada;

        public string _Grada { get { return Grada; } set { Grada = value; } }

        public Asistenti asistenti { get; set; }


        public Profesori(string Grada, string Emri, string Mbiemri, int ID, string Email, string NrTel, int Angazhimi, Asistenti asistenti) : base(ID, Emri, Mbiemri, Email, NrTel, Angazhimi)
        {
            if (Grada == null || Grada.Trim() == "")
            {
                throw new ProjektiException("Grada e profesorit eshte null!");
            }
            if (asistenti == null || Program.asistentiList.Contains(asistenti))
            {
                throw new ProjektiException("Asistenti eshte null apo ekziston");
            }
            this.Grada = Grada;
            this.asistenti = asistenti;
            Program.asistentiList.Add(asistenti);
        }
        //public bool CheckAsistenti(Asistenti asistenti)
        //{
        //    List<Asistenti> AsistentiList = new List<Asistenti>();
        //    foreach(var a in AsistentiList)
        //    {
        //        if (a == asistenti)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        public  override string ToString()
        {
            return $"{ this.Grada}.{ this.Emri} { this.Mbiemri} Email:{this.Email}";
        }
    }
}
