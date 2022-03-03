using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    internal class ProjektiException : Exception
    {
        public ProjektiException(string message) : base(message)
        {
        }
    }
}
