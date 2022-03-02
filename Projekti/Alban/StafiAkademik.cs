using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    public class StafiAkademik:Personi
    {
        private int ID;
        //protected string Emri;
        //protected string Mbiemri;

        protected string Email;
        private string NrTel;
        private int Angazhimi;

        public int _ID { get { return ID; } }
        //public string _Emri { get { return Emri; } set { Emri = value; } }
        //public string _Mbiemri { get { return Mbiemri; } set { Mbiemri = value; }}
        public string _Email { get { return Email; } set { Email = value; } }   
        public string _NrTel { get { return NrTel; } }
        public int _Angazhimi { get { return Angazhimi; } set {

                if (value <= 30 && value > 0)
                    Angazhimi = value;
                else Console.Write("Nuk lejohet paraqitja e oreve!");
            } }
        
        public StafiAkademik(string Emri,string Mbiemri,int ID,string Email,string NrTel)
        {
            this.Emri = Emri;
            this.Mbiemri = Mbiemri;
            this.ID= ID;
            this.Email= Email;
            this.NrTel= NrTel;
           // this.Angazhimi= Angazhimi;
        }
        public  string ToString()
        {
            return $"{this.GetType().Name}:{this.Emri} {this.Mbiemri} \nEmail:{this.Email} ";
        }

        public override bool Equals(object obj)
        {

            return obj is StafiAkademik akademik &&
                   ID == akademik.ID &&
                   Emri == akademik.Emri &&
                   Mbiemri == akademik.Mbiemri &&
                   Email == akademik.Email &&
                   NrTel == akademik.NrTel &&
                   Angazhimi == akademik.Angazhimi;      
        }
    }
}
