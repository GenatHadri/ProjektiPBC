using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Studenti
    {
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Drejtimi { get; set; }
        public bool KaKryerPagesat { get; set; }
        public Lenda[] lendet;

        public Studenti(int iD, string emri, string mbiemri, string email, string drejtimi, bool kaKryerPagesat, Lenda[] lendet)
        {
            ID = iD;
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
            Drejtimi = drejtimi;
            KaKryerPagesat = kaKryerPagesat;
            this.lendet = lendet;
        }

        public bool MundTeParaqesTemen()
        {
            int totalEcts = 0;
            for (int i = 0; i < lendet.Length; i++)
            {
                totalEcts += lendet[i].ECTS;
                    
            }
            if(totalEcts > 50)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string lendetEJapura = null;
            for (int i = 0; i < lendet.Length; i++)
            {
                lendetEJapura += lendet[i].Emri + ", ";
            }
            return $"Studenti {this.Emri} {this.Mbiemri} eshte ne drejtimin {this.Drejtimi} dhe ka japur keto lende: {lendetEJapura}" +
                $"{(this.KaKryerPagesat ? "dhe": "por nuk")} ka kryer te gjitha pagesat";
        }

        public override bool Equals(object obj)
        {
            return obj is Studenti studenti &&
                   ID == studenti.ID;
        }


    }
}
