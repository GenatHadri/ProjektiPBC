﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaDiplomes.NewFolder
{
    public class Asistenti:StafiAkademik
    {
        private int Pervoja;

        public int _Pervoja { get { return Pervoja; } set{ Pervoja = value; } }

        public Asistenti(int Pervoja, string Emri, string Mbiemri, string Email, int ID, int Angazhimi, string NrTel) : base(Emri, Mbiemri, ID, Email, NrTel)
        {
            this.Pervoja = Pervoja;
            
        }
    }
}
