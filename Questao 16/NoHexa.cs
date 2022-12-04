using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class NoHexa
    {
        public string Hexa { get; set; }
        public NoHexa Proximo { get; set; }
        public NoHexa(string hexa)
        {
            Hexa = hexa;
            Proximo = null;
        }
    }
}