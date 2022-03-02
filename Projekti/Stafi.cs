using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class Stafi
    {
        private int Id { get; set; }
        public int _Id { get { return Id; } }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string nrTel { get; set; }
        public string Angazhimi { get; set; }

        public Stafi(int id, string emri, string mbiemri, string email, string nrTel, string angazhimi)
        {
            Id = id;
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
            this.nrTel = nrTel;
            Angazhimi = angazhimi;
        }
    }
}
